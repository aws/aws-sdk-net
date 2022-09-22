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
 * Do not modify this file. This file is generated from the iot1click-projects-2018-05-14.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.IoT1ClickProjects.Endpoints;
using Amazon.IoT1ClickProjects.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class IoT1ClickProjectsEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_10a3173a70d74e03b4028b69a0013007_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_85239ff2b0d04eaeb9d6477d83dca582_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_774a03134414437b916b28c18f466ca3_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_8918f2301f7f4128859db07a8f463c48_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_aa1e5069dbeb4eb2918de91391b6d9d7_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_61d2b4cf44884a36810eddcf43c4ea53_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_fc472d5512124957a5d6c745aad553b8_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_c3e31b48a958497fb0719abbe6cf891d_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_68d013a201ae4f37beb777600ece025d_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_9130e47981c2488690687a52cb66b0fc_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_511bb22f3959400482995ccc0ea0bf8a_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_03064e7dd4564ca99dd584f548aa4b51_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_8a42862f29e7426384c0be47cdbc58d9_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_3b5b2fc035c1495b8001995c2ebebc7c_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_243896a5140146488c889f9aaa75bf42_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_085551c94da14b99bbf861ad83699407_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_d7cc807abdde45b492a54975de85a0e2_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_aefe36b4b1f8403eae321b617ce5e813_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_4c981cd5e7364171a78b032c397907bb_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_017b6f571da34bcca23882eb27153918_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_d72a990ec7c847ef97c417941ef616b0_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_8c27ee38cbff485395755957540ff2ee_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_8367220e8c3845b68a97405ee8dfbfd9_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_ba1508bd9acc4cae80797cfc13440326_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_ae7c2059cd294310a13a5a5f838f213f_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_245890b09a38458090c38f95b3c3244f_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_ade687b5c1684eddb2ee88e9850ed7ec_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_981702468b624c3394e4eff19ad9222a_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://projects.iot1click.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_1b8cc6bc18034280aa855799fd57ab97_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_e911af5c556d44d99618d84177ab0606_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoT1ClickProjects")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_a2a25b8875aa489f93ce0ad5ec683710_Test()
        {
            var parameters = new IoT1ClickProjectsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonIoT1ClickProjectsEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}