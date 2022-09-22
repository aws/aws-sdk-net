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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ResourceGroupsTaggingAPI.Endpoints;
using Amazon.ResourceGroupsTaggingAPI.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ResourceGroupsTaggingAPIEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_06777a72e80347e68c551c9577518a67_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_fe16adfd85334da99afac89952c450c8_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_0300ae47fea34105a6c1aa660fe26b0e_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_a4f5f429034c4aa6a99d220db32b2977_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_934bc7a8505f4696aec87f0cb1bda4ed_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_c4fe3757b79f40ceab26bc4c54de9c10_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_da9c44f77dfa428a9ca0e33e7958f8d7_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_b526c23f88f54ec6a17b67dc467ef294_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_d1c8312952dd4e2e9352e2797ddd5c32_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_05e7b7eaeb1943859bb33441f2bf5001_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_3e5b7747e01d416398dbba2a503d7e0e_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_ae4afbade4bd44b59e50cda7568973d1_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_e88d2bbf37074cc6a1c2696b35ebd830_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_313d525e87924fab83a0187acc696de9_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_68877c3156004490abb0a08426582a00_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_bbbf3a6e5dd14b68b025b2e0131482d5_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_68b4361cff7d4ce09abe3d9f819dc451_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_5dc172804fd04c50b19f3d65e13cdafb_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_332d1f9db1a64fd89d804b35a5ce305e_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_4f51847741fb428abd8f0859e002cc11_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_27c54fbd801d4f9b8ab830213e16d9ce_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_954f6a168f99478e8cf7a7264c8ef18f_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_820aeb65b3ca471685f229d6cda19188_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_276eec8c1d874518a74bb1d0b610049f_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_6227ce66b9ff42dc91e3194a814ef86a_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_24d853305c9f491ebe1aa168132f19d7_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_6eb2604bb0e44791b0c0abc11ebd5264_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_b71a8f6a13a4404088fd06e2fdee18c5_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_f3e68f8d14fa44ae90d489e5511fc0b1_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_a31b8e73b33a4191a6b11fc2c7b6ebb3_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_dc35c0ba885c4ed9a1d5cd43f4d27980_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_bd180840a8e14f598d2d12d1b637591c_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_8b94a41d605f4caf8b8efa9ea4554219_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_36d384e754d44f0bb537a7c32711fad0_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_faaa86e90015467a90f6fbfc95b86e07_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_d84e16c30ebe44f28413a881e7fd4c74_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_7edb8a232e2e4364ace46729e1221373_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_04819a03e08d4203b3669e82727c5bf0_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_9476f8640d99451a991082db5c2a7d7f_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_951bf60394e54ee089d39f21f9a66a78_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_84a77588121e497b8230487ec7d25027_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_68ab1c69ad2c460d8c45bad008f766a9_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_f8e729ea12fe47f3b9e5082ddd23195c_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_74bafdc6db5f454bbd5731466483f004_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_d5cbdca731f04aca8f9219dd2a963a35_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_6edcb72854244faeb7530486187ca3f6_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_05a2f5c82e1a474d9dabfb4df6198888_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_bf573deef67d493dabdf597c242d18d0_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_6a16cb3bd33f49b5803547e5b6e2ca43_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_d19fe281db964fa1a6eb6e284294426a_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_e6c002bbc35042839ff9647a605b1929_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_13c34f875bca41e892b9f85ae06f4d94_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_a4004f59efee4293821db8a7ebbb8cfd_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_2c8d0f53239d4a00bccab5b9de8bf153_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_055a8f46b92c40d6b6addd0f149120f6_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_f63a20fa0b4048d7b41f972374cd7c3b_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_9f2557adb51643d6a46e42359e5bdf44_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_bc79100a66754aa89a8ed7e9aade1bb7_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_405aa0c9dbcc462baf61e000477586cf_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_bb5bea69d6084531a8c88c4c7af171da_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_bfdf457aca2140a7bc338b618d26142a_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_b4466da9c058427cb5ac8e50a92396db_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_552db39f17bf4d93877ae72e201d35fd_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_e3cddf53b58c47c184de1a216da63fec_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_b3122af869fa47d0b75b4740186ab95c_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_78d75fcb4c28405da5189664fe32cd39_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_b233a09db3694110bad0ed5020a25afb_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_96f2a4c01e8b405bb1ab86d1474f8cd0_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_3746dc326af84b489d95835fff045e91_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_4fcdea6e40a54b46b0387e53f173a144_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_f2f2bfffc1dd4ebba87fc0cf2fd6bca4_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_3bfb8e3afcc94e1380f98e69bb82c14b_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_25e7ea7b6b064d7a99053ccf3b9f08d0_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_620e426d64f942e3be54f09d5016c24d_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_cc12eda9cec44a54aa535cf8ff928791_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_71e3aeaa422e479f9e2dcdd4f8c33e98_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_fec4803c56b6493aaf661257386d70e4_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_c16ed371f2294b26bacf0094c92dd532_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_57389fdf2f2846a494c8280bc1b9cac7_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_8c618d9b386740e99c3dcec71708c849_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_feff197f0f0b42aa9fb7931ef2c7b651_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_a573bd9dca3940c98fe7e5a832ae3c17_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_3412ab1e47e64ad49b22bccd78037a82_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_c8c96311e5bd404595d6f40f19122afb_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_9a3672270de34dd0a3c9989ae7b6aa45_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_4bb3842ff2a246d0bb0776f5a153fcec_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_48c95e96e6054a2d9d4d0ce650086da6_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_33bbe4e77ae84462ac2936b4d9f1cbcf_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_8fdcd6d6f23e49dba556e0652f3753ff_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_4cbe532e32a04b2fa409f874e2838fd4_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_d87522f5736948aaba4ad6efc57023ec_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_63f14abb3ab24e0f871904ad0032d693_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_008c820486334781bd927fec3e31dd9f_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_6f4710bdeca743c59cfe40ea74c0eb67_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_8d77e165982348028a844a11c3d2ef33_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_51b6703a74e34ee79fe728e3f0492cd3_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_4ed5b2683b2b4c788c4a3d699fdccf35_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_89fe3a7043fb41438d1d0c56ea93e594_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_2adec828ae554802aeb722b7aad45585_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_8abcf515e72a4258bab3b6e1741ba886_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_57673623fde14dfeac07dd003df1580e_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_5b23d5d7738f4427b1f31e64787248ab_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_487b17229d7e43ef9035a12b297168c5_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_29156e8973de4336b51863404ab29245_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_7fee690a96c84d64bf7b594e2d85b2a5_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_aef1d91021904a22a8837213c586a3f5_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_a85a18a25530452e88e6472da4b8f392_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_eb860fa5a07f46419b7d8f3181bd5558_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_4ee68594a3b042ae94206ed0c7f236dc_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_b5bbf963c2184cf5887fb10b5aa36e89_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_e5adf2ad35794f83bfef7cf1ae046894_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_e121d9be66a0410991ffd1869afb44e8_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_enabled_43b75609f0734b8fbd5e0ebb9371e8a3_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_disabled_aa7cc970f052472a8ffd282864218637_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_enabled_4b994c2d74ac43e29860870706465250_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_disabled_1d389a3e438d4de29e21b59e6fcdd966_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_060ea2e5ebba4eafa229f5c2afd04f80_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_67148d7a5a06484eb0d00fef4e30720e_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_4960e1e547884319b0d596d2f98baeaa_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_aae0abfebaa04a359df5c7fefd4037b6_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_01fa1be981384a4188e97edfbbf5338a_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_917078568c2c439cb623ad9cb317b45a_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_dfc92a758106427f9a6e51ffe6dbabdd_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_23ce9d7e832040aea27fc8640fb35fa0_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_720275312498483f82207a16037b6e85_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_0b3290e121da4e4697c2aeeb1f0e48c8_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_f304f109abbd4b519d1adf4a7e7cd9f4_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_d359d73c440d42e39e3faf50abaffc46_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_f659d5010b974bd390f24e9827ecbae4_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_4a1cc782960e4f10ac8fc4846abb85c5_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_09daed38e0e647e48f36b72a6af71c53_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_a3bcc70fed274689a459b236f1f105ec_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://tagging.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_04e2aecbd3cc443aab427d9bb6b0263a_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_bdea75300e324edfb1fb25fb2e692dae_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_1f8c234cca794e319ef6ddf3471c13b9_Test()
        {
            var parameters = new ResourceGroupsTaggingAPIEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonResourceGroupsTaggingAPIEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}