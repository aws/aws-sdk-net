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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.WorkSpacesWeb.Endpoints;
using Amazon.WorkSpacesWeb.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class WorkSpacesWebEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_6550c04a500344909787d6c9740bcf5c_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_0e85f84498ad47f2ad71653d3d1716e6_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_e2856e4e61464956ae46756caf03851b_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_16c7282e272c4e22bb56605cfc4048ab_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_2de85e460ebf4b1ab4a40f5729520134_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_5818fc70887441e0a72b59f54ccf9d9a_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_3a6a48484c7a414da038d87da0bf246d_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_29f09454051449f8b1f90ed4753c2106_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_fe3b10d81b1f4cc3b2ec9d7fd167322c_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_34537da5049943218461268d9deb8b70_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_29e70c3807e349b291e6eac1adb4a8c9_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_50f83c456f214d02b3514e199dc226dc_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_38d0312a88a74293b26e6931f639f38c_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_7484a5a35d5641859a9e09aca6deb417_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_982c20c670c1487a8ad6d0110fac9651_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_2b4911ef7c4449528af4854b26eb4ba2_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_61015aeaaa89491e804d1030e4a282cd_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_3400572728d549828265795265fe6524_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_b636578779e241fa875037d5c04bcb3c_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_0a7f7dd7456341238379f20667513e23_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_700f1626fbf043e2a372af776eb9ff1a_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_c7e7538881e24361936441ba8a632343_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_0a119c42037146e8b7723a4a0bd5b1fe_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_7a2e9a069cba402f9f48cad4b4a81f60_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_b78d8286dece44cf91ebb3537b89d48c_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_74318bc4e87a46dd8a5ebe93b476ac82_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_86a295e01ce74b11844763006b8a9337_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_3f51096865b944419df49d48e70fa017_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_01412dade71b4e7fabdb06bb839d545e_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_1a49e453e0724121b5749dd41b35f40a_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_221ac59cb5a944c596818fa72b7648ad_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_5815da1177c642c7af285867956ac236_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_6eff292dc1d040fbbd48f48c55036661_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_87ff7219ff154a6e864686fadc38ec58_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_cb05a95bcfd040d6bd876d25fe493243_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_c3702a42afb1432bb3dfad3977e6011b_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_4754801d18f04c1d81191b57ab166148_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_470dbada0c2849c3ab2208a7cac58ff5_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_6b37bb50581c44b6b6f6824b46905b88_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_ff10cb71cc504ea784d9dca2edc972eb_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_991d52d5e4b944d19de42b7b1f9dadc0_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_20184ceebb1840b289a521ad80119ad3_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_1b83efeb812646a9bac4eb8f6281ce0e_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_1adf0a47f7244abaa60cf4caa7262560_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://workspaces-web.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_fac819964a6a4d69acbacd6d45020aa4_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_06fd33adca3b4e39ac32fa08ef751d11_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("WorkSpacesWeb")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_837224a2aa754221a4200d9a8e775d57_Test()
        {
            var parameters = new WorkSpacesWebEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonWorkSpacesWebEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}