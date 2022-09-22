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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ResilienceHub.Endpoints;
using Amazon.ResilienceHub.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ResilienceHubEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_a060879820214da1a964d47c5b9aa620_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_0bc17c0bb3454e118f405532e512cb78_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_fcf8dc63090344d78e5831d8a014c266_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_cef4cc292a9e47fc9205689abc62bdd8_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_a5a30e3a50774adf9b731e158219d46a_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_1b82375b4f7d426ea75213592d740aed_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_709d5780a35c4255a24beb816d2fc5f0_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_f3c1f2528c8b4d04a75af28e071e7e7b_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_83c7f84ce2354041adc1b16002f4a053_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_8e33cab96422402a89b85d118c9f5cda_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_f4d0c34ee19c41cfb9b1668846ff247d_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_a00cd8cc26064ce9853a282122ab7b61_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_27c0a8e94580426ca075a13e54d86e56_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_b2d4120c1ac24b74a337ad79a223a51d_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_00c1f61cb4d04e53944de47878ea194b_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_5b8222f3d8a94dd4bfda81fd88edb37d_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_5770c8c28ba84334a81fcde0626de699_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_45f7f20eadf34faf8d394a3b0de2e74f_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_4e6a2ea39d50468ca9b2385ac373caf3_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_c77bb6dad1ae4371b0cd889e33684cdd_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_56cf08d2ae154d218a799fab7c682c28_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_4d104d74886845f7bb247642d8067919_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_244b0ceacaeb4cc69558f46d435fe9d4_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_c35f1bdc345c4bf786a1ceafdae5fec8_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_796511c693744116bb2ca946809f3ff8_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_aeeb04ff795d419f8da8641763045a3a_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_e6a20d0389424697b09164ce1d3588b7_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_dd10aaae49464370af48c419fc297875_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_2784e5297405425ea5f6ac2adb2c481c_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_89c360bf3ff14cfb812a15bf60fbefc7_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_7b298d2cbf1740c0b9177a3d93eef5f5_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_b98f9cfa33c7412f873dde3ef4b01e84_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_b1a96c40d2284ea3b2313f247d15bab4_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_103beda192564e619977e731d4c1dff5_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_2056402848104dcbba9f51f1f6fb14bf_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_18ab951e36954bea854f2e3350134e7d_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_552c428ac64d499287214ba181a90a85_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_534b932ad44f49c4a1d153c9ef9eee1f_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_222e221bd0414ffa822cb8c1c8ae381a_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_798819119cbd40f292161d7e5e141e87_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_9fe5f13f03414c079ab9d738d1f1d290_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_13d787ef904640ca9fa8d38770208c26_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_28c367e4ec434263920922fbad6bfd5a_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_a9e60e640dd94c1b9266de752f17825d_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_d76c6f8e7e994226b1500ec3bf2eb8bb_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_1941fa655e114a888d5be1a77da7976e_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_59e312cbb8314e3ba4f779cd10618229_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_562ce81713964a9c892706f83f8c1aba_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_c6fe3e7796474d648b367fee4189996d_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_4016f7dd1c2c412d956eb6b07cca5c63_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_794c85037888456c814944c940e598ed_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_13fbc4e9e0244f0686f5fb7aca567f30_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_970c4398ac3a47be9d22559f79b83b6a_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_3c96bf324be6487eb5a805e38a48c2cc_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_bd9d0acd4bb04b6eb8b2aaee44c2e3f4_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_f5548a75b903431485274cbdd6237688_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_2e21c29f9535471c8436d6228cce8ae6_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_83b69ab3396140aa988da80d37ed2c4f_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_11f69451758b4d31b1db6156913dad42_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_06ef0b7f04fd4f31b7e5efac5ef6f400_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_d46dc3b701d24b7cb82241eb64297c25_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_d178750cc3e0433bb70bdafb598cd449_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_5f4b4ec9e22a48499d47d5a506a9eced_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_5f382d6846934f91be4aecaade87c0de_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_92b0442eb75d435ca0d33fa2a481291a_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_1ca9ce5fd71b456b817f61f5bd712e50_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_9ee06055038e418f893b3ec149879db9_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_9f18ad3e7e2f4b4aa961a5946418f5ff_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_29aac57961b54d0fb8233301e8a8831b_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_2115057f1dee4a86ac591d8c3387de0c_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_2b37636f481f4833bcba2f54bafd97ce_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_29d18046e16b46b98d27f1d445d03bd8_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_d03f05ca891a410392ba2a13fe2e7f48_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_47d1594ce68644cd8594d9e7aa117c75_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_e283f82e524e43c3b3a8f71b4eec86a6_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_876b35a4d68a43708f751a48f051827a_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_10e6533f72a6406892da710b18eba319_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_46abb61b86774d4f8dc693f556f7ed28_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_70f18dc655474582adfffa4203f71833_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_85babd945a7b4f30aad0e570f11d883e_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resiliencehub.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_26cdca81aec7409bb1f4aa2dbbaea465_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_ea7ec5629d1c43cead951186a5b5cb1c_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResilienceHub")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_71600e3ce3ae417d8befe29a3d0f00d0_Test()
        {
            var parameters = new ResilienceHubEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonResilienceHubEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}