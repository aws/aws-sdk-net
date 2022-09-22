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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.OpsWorksCM.Endpoints;
using Amazon.OpsWorksCM.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class OpsWorksCMEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_5c76d636ee254cd1abded1318d5459d5_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_dda2cc3da5d340e58d49718ecd13a18e_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_eb0d4e2873684057be991631a4496029_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_33034a99a6904a18955d07cb4b40da6f_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_6e68088b82934f91b079e614ffd9334a_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_ea7810ad7f5b4b0199742d33861ce7a6_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_5a7dca0d2f4e4ad29e4f8ec583297e07_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_a8544e11a5f64f659819aefcd97f6b96_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_606be07816cf4ee29d85b89a44d7a8d6_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_a417eaa66f8f46a58b0510a9391eef8f_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_1ddbee080aee4f01a4006d3706f14e0c_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_4922e334fc4842d985529b9760f837c2_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_0283fd8640f44cc9b624cc8530e74582_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_c2938f3ad320472990aa3a750ecd9c24_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_3b3c5fe85bc545478d9737b66ba9e4f9_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_e13c78082202463fb6c1ba613aeee849_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_00a7ff2c885f422fa887cbd35b62c3f3_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_854ec18052244567b2c32b3f0734ba2c_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_7dd71d7e2b8d40fe9f9bf027a5d393b8_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_27d0639921174f5fb0569724bf56dcb1_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_7717a87b1a0e4ca98a45531505108727_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_7ac40d31901b45b6ad23efec0b1564bd_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_1cbb6f90705e446da53563479980469c_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_09d60c7438254a71a202ba3ffbe3f848_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_a9dc3551457e46b0bd0094a83b9e0d06_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_ae91dc6826a342bd9bf7efddb9bfdbb2_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_01f6de24cb7f4bf1a691017d8490f87b_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_6f5bdeea7dff4cdfa7a68e38bfac2754_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_d14fe97bee844a8caec9042dab29cdb5_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_806823ae6d324b108764c7c4605bf327_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_15bcda2f81fa4afdae316b9d75f6e910_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_1726690b971843b790e64cb979bc1a91_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_d0945dd47df544ff874f8c2bb949ae2a_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_821b65a048e54fcbbff3f6bb28b354df_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_9fc3d0f3a6ba4b68a8c3d8343032de55_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_ed6d2a109ffd487799be86bf0b594657_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://opsworks-cm.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_523dfd9a4e1d4cf193b7607362e3028c_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_881b8a8c56a7487fb73863daa01b7233_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("OpsWorksCM")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_801faf2c288647bb8388ca08eee16fb0_Test()
        {
            var parameters = new OpsWorksCMEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonOpsWorksCMEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}