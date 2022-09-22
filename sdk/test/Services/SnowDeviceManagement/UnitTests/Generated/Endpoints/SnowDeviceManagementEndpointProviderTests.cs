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
 * Do not modify this file. This file is generated from the snow-device-management-2021-08-04.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.SnowDeviceManagement.Endpoints;
using Amazon.SnowDeviceManagement.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class SnowDeviceManagementEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_be09b60938334915ab7ec37309afb445_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_f78b897330f2459bbaa4c272c707bd2a_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_991070ddb62441009a9b4151b09cb104_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_8d41360889674eb89c6a4ea33d121f1f_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_42b367b33eec441995d22c75e5d78b33_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_1822b612dbba4f60be8aa5ba19f4dc3d_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_e310353a3ec14dd0978e21220a12d271_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_91ed757a9efb447f8f7d844e403f22f3_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_49a4d0a624ce418b823225aba17e9c61_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_916b43935075481dbc7f76b14cb3bfaf_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_54b381ed84a84ff89901136ff58bfe74_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_5af6eafaa8964380956ddd25c2d4ac5a_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_586d10dfe1824a61af051e4a126711d6_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_caaa2ec6bcc646898c40878b060a4ff7_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_92defcdf43e3465baf26fd2322b2b68d_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_c67f981d45044eb0b631598d24d5f296_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_8949bb6e8d5142b5a35e08fd69abc4b3_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_b734d98c29604093b72a277e60946411_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_7ad4f550a36145fabdd195114389786c_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_9f046a066f864ee8a8133b1981c4606a_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_8bf7e187aa384b68bef7233f8ba61043_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_505ad9c92ebf47df9cf3fb2a2017979e_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_7e9fd61ae53e47329c9c10cf1d752bf1_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_6980732a9772459089a9893203bb8a57_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_df56ca27e2c342869e2de6606c7750b3_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_5a76b02300c74550888c8893b42bf270_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_d3e5663b90544ecebf7f7a4fb867c259_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_1cd947b33e37448a886ed7289bc4b765_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_8978fe2d6f074e7784c2f3787c5c03e6_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_335c9fd01dae4c88aeac3a3cdf47ff18_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_854898da75db4ba0816cdb443a9ab0c5_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_88e941210f334c0a937a5db0e6efae09_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_1677713844f5452e933d96a58f9190dd_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_b1f63fa1e93846aaa1ee8993db9c5f31_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_4aebc30fe7ec4ba18709a0c3a7806d0b_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_491290905cfb4b72887d25528beb09b3_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_1e2c0d086b47475a8fff441180b66d64_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_72a198179ced475c8fc9563f0750bd18_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_6f359ff1a28541daa35b0eb371dd229e_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_1609fe64c70d4ce6aeacc8b33633b5ba_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_cf45538577434291be6fc208d852ca8e_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_1656358647cd4daba247d8be64b14a95_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_d41071fa5c1b4fef9485e6d111cb6db8_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_29d095390fb74837a905868e3550f806_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_edc09ceb3d694828aa88d620537e837e_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_c1de8d185c5b40eb9b96d094ce1573dc_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_60491ded693449e7a483fa5f1c0149d0_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_f1c1df69ae9840e3a6f1c683e6cffbec_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_1d93835f714445158923371ae7278d3f_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_2c33d850a8c743d28fa2dfe6de806bbc_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_7585a95727524eac964e98637da75194_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_e3f25c4aa4fb4209bb6ccf540824a3f3_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_9131cabe736c43218109c89bee053873_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_a07238ade39142869dc288609b345718_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_c0e89143a08449e3b10d1391d9055cef_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_1a5cf8187a514360a7a2410fbeb91dcb_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_b220162f7ede41329a3eb54f5e1c746c_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_6392df13d64e4f56997e3d0e29504e5f_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_eb861e377f104db2b71876c14fa05d80_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_e3b271059da845fdbf30d7388c8a2bbb_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_6fc95850d1d548999c20f337788eecf9_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_89a8491eab6e44e5a1e9049221f64f54_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_1550239146dd4ec6aa60220ddd695aab_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_955b06f8ab464dbb8c0ad72a00ed144d_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_1a168992bd6442da9e634d0f10229ae4_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_fec8ef1140a442feb1687b36f0cc4b80_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_e1e0d42657b847e686958bd993c0b100_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_e246f5ca82fd4076956de3fedde2ea29_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_243a987ef0f34dacb84febb0ff342b25_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_6744e0171943478b992a04cc6c26a141_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_a2110f6476ef4fcbab9c0f238372014a_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_02f4b61ca0004023b05a4def9e3f9678_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_948c62ba60374342bb405c590834e20c_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_052ed44c628c4aa4bd03f005fb1b0383_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_b8c994cf897243738fe5741ab8828d2e_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_31c0c9c3f94a445099b386a96ce34082_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_09d7e1d8d15b40c7b6a254d46b6a3f0d_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_e75f52ce314143cc9ab51be8509ff120_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_f8ac448ff0194aa68266b95f36366483_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_664288fb4d18414bb2cff98530aa1a93_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_4e3179a5459e4d82bba5f082ef7be7f6_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_8914370d89e74716bc9468b137f73413_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_d88ce188c05c4ef9bce7a38c6a175bcb_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_be2223bb02a2409da92b16610ba2c281_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_ef678b04cef4421e90b38f71a60e5944_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_8317c08a8ace43feab20e529eda01659_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_9e7f30084c224328908982f75f6f272a_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_796930a06a5c4da396c87ea8c44ce2af_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_a1cdb0dd662a44ebb20259eda9f88f4d_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_db0b190e657f4af7aa7723f4ecbf50db_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_9e79239871c341a99aebfd8e16ab545e_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_e73e3c83274a4ccdb1640b6c57f4996f_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_6ccaeaac2db24f8cb581e14ab1835e61_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_4d6b1f6e4af4493c827b32978fa264de_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_2f528c43ee764e819948f030faa2e2f8_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_3386cc2fe1984498801990ab0e5d3ee6_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://snow-device-management.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_c21bf813b62b4cb883dc669b6334aa0e_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_52c672b280aa421d81844929e61e26dd_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SnowDeviceManagement")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_29e8e5e87231450faa59a4860c3ad44d_Test()
        {
            var parameters = new SnowDeviceManagementEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSnowDeviceManagementEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}