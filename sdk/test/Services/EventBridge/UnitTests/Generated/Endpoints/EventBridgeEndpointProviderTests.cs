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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.EventBridge.Endpoints;
using Amazon.EventBridge.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class EventBridgeEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_4d26912c92ac4ceda16ffb4a1be55bbc_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_d6f82d11d17b4c5384b714b0aba2341d_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_02564165744a479aafaa211d905d827d_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_e59dc388904d468c9986cfa6b8180c6f_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_c5ffeae4c4db4bad84b01ccda1c5b3d6_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_a9f27ca0c9254f7c968ca23268499006_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_a4c8b72bc039421c93de55d25aee916a_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_de032bd632da44819fb08872e2532997_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_58ded8dd2f15483cb43cfbbaf4de00d1_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_d02eb003203140cba53054999e8f8716_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_ff713c408da9418496a3ebc413c29f95_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_6dfad91e74bb4b6185e6b5c89e3f6532_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_2a23d0db5e854a12afdd328f065fe726_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_3e07281d585948eca1a769db2010c8a8_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_d3d334f437fa4d40a6ae82251cb6eb9b_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_bdfc69a9d9144f9eb354ba90edbe9a3b_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_ec4d648f5c6d463c9129236e60e47a19_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_391eabdaf07e49c5a49f21e729a542f7_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_ba06bdad825840fdbf293bf36cd2737f_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_595a1560b39b4c9da65deb4e35ae6537_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_16a064bdaf9749ea87213894f0b503df_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_60626311e951496d8d85f11c3a0b0274_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_e2aa30d5b5684aa7be3a035714d592dd_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_ea317d1b03cb4da0858c97829e399f38_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_b011cc7030424d989e213211a552fb87_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_db5deec106f8426ea60579d8f15ea54a_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_2a08890fa7fa4156b9f2fbe014bac5ef_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_3b80f2cb67124343abda2d941d8b4bae_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_f9622abbd3064178a3ba34056aa95bb8_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_8ab14db694ce458cadd4886a2c094f54_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_2d3c972a85d841428b40a33e36252a4c_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_23b38ba7eae44b3b8beb168c969b2e75_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_8e6c7a8252ce4d92b18bbb929f89d754_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_87ab1048e42c42049590a8de7e02894a_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_1eda62d5b5524b7a9090ee8f8d1bde6b_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_82f4b2cf8ecc4c3f8e373f2850995775_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_b93b1ca00ebd4553a3f9356bd913ca2c_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_0e2807f115964408855db1d0481dde71_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_47c578dfdb5640418c94ee96eeb06b75_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_297a456d2d784a539da3086a20270e59_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_f351938f85bc40de99c21e1cb989b07e_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_fb9d35fed4614dcb82c30b9c8ad5afb8_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_38a34e5ea5d54a94bc44c69203b2e1bf_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_13d6e57c757c448fa1894ae2bff8de3d_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_30e8f32d02184b218997f7115f928ce0_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_9cb0f2c9eca145989f80d9bc8dd0d652_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_6f8335c0306e4af99057e8c8d5dbe730_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_cbe1fdf5d3924e5c9aebb9fdd8a473e8_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_bd92fe25b58b4330a0a5f3f21e570ec5_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_ef4e14ae97ca43c397eaf00c8f64f29c_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_28ee9c237fe24f37878cbf761bc74e62_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_373ca24974244fe1ba778d6a79c7de17_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_ae524d22a46047389b822901bf69ef39_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_a0b1f364e5194934bf4a0cc2802f2454_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_fa5060efb8654241bf9db2092f441913_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_4d87d6bf321c41b692869eaeaf447d9a_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_bf7fdf0495e6489eafc351badb1a573b_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_c36cdd8da27b497799ec829893850369_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_892b53b8307e4a148c4c4476e078f6f0_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_510a9dada96447989ae820ffc63f9391_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_449f8888832649f8ad78fb0da031aedf_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_e62ed9981df14f6fbfcd4555aab6517d_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_6e6680463aac4fa2ab7d60ed6122d173_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_5213722a876a487f80e5df8ee1655489_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_b828892cd6db458f81b1265010a14da9_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_ba6545e10c274a489872be5883bf385f_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_667bfd68a57542eda55f311bdccc55de_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_4ac5b9a96fb34e8d80dd31965518f0e5_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_53eeb57ed05242d8a5523f1ee6494bdd_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_1b28978ce0c843e8843a12b8b8cc1cd5_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_aec114fe59bd4cbabf884d06e7351a94_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_3054808b78ec4979a874342a4cb1e7fe_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_cf960eabd982456e8a64559de38ba01c_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_296989b8e3234043b22ea682a8f8fbc1_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_7a99c92c2ba84cf2aeb93105b7640876_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_e70da433c86c4de2b83d1aacca853d45_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_6011738d52e44176b3dd0bfcffeb4c71_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_80a5b8dee8a3488c8dd5dfafffe207c5_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_187aea110e9c4bbbb0b35ae078b72b46_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_2cfac6db104a43ff98d8ddd046651901_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_b65732aafa074a3c93388414d01e8c96_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_2aef4b70b43e4f28b1852d97cc2a4a11_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_6ef18a9805a041aba6be365171a53a64_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_06c1c85e29744dcda404fe06cb263f36_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_9d3e2acff99c451d9dddf08569d0f49b_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_5959b87a172d44b1836123d87ca61a44_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_5a88c036b1d445e5afac0f6467d5ae9b_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_72ee4c0cf937474d90bcd8fb643d04e0_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_f34e28fbb7434922b64a0fe89bf123a1_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_ef77301b471c444389fc036aca393bde_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_7b0dd3534a5c41b38b042a22c2f4ff7c_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_b3a766936b69439f81c4a099603686a1_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_bb6fed7e758d4fa69c5bf76ca4fb94f8_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_248a9d8bf6f2484db9a0301646a5e5de_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_9d1254397b7c496796d98d955ee44d32_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_be975699fe25469f9e21f6e44ded0c88_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_f2c63046e0fe4a88adb1774440b210d0_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_7c8b0781ada14a1b808d61a50f761035_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_7181a5b881c44768bee6ac0ba488051d_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_3acb9c911d77409787bc7a442535f912_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_d2bdc8b583cd4525b02038bfd0a4fb39_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_a095a22504454d8696d18b51239288ed_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_e332ebf3a44b40f5a753b9c80fe664a0_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_8d62c0dd6a9d456cbf74b408fb494b53_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_e3c87eb860f549179833c29c9a7d21cf_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_c450e1b2c48f4a6ab26d9dfa8507bf48_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_07791e9289054d2c959ae96c602d4b2c_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_4da2e1c7927f4fafbd1877b111c45168_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_72e774c1277345f387c4f2538cad5039_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_0e81a999438b4a6785126aea0f229ca9_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_ee9f0fb2476d4f1fb0c2a5b2672df638_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_c0031838f3c24d7aa9f1c9f1813c37ae_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_3a1080cf2eb24675a3d7299419d647bd_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_7e2b481bdc964f1a9ea5f54c767feac7_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_b810c0356c0544beba3a4bb8ab54365d_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_3dbae7fe32584e478fc1226b455d2b88_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_enabled_986afc5530b8401bb79246e5199185f8_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_disabled_22cf61edf5a043dd903bc7cae85782e5_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_enabled_2632396448e244f78fd9e4e3d4e053ee_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_disabled_c1c97bd37c42407faa32f28caea22a7c_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_68aeefbc086047f5acfa4b1426546ae6_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_4ffd4ffd702a47a58cbb4c794112cbf9_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_6574f83fbb7b4dd5adbf06d9b0a9826e_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_4558aab78c2b4e639d7be3be8d2503ba_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_9478b45538a7408aa2b1a3b33e05a36b_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_4ff7105207574be389ecefb897c65c06_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_f7be2c5b962b40ceb5f86958083a3cdb_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_8218dfeb686d4aad85979bad6aa49216_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_01b565f481024d0ab73a5ff94c887bc3_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_2e4e54e00f69455ba8ee77ff6f08dc65_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_9d7d0178ce0440f18e5fad5de494c885_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_c40d44e189354b79ae9a909302351224_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_fcdfc6b1d8424fb4b7eda2fd3da2dd38_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_26c5518ed1e543c0b79fe014be8d9bb8_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_1a2605e806c241d3bf4afaf781308e57_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_04f97e04e4614938ab8ab29c3bdb8382_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_95f145a9f85b4b26af1e021848784738_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_c1b0e84670f940c6a0c383a6372de52a_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_9d771c952e094a7fa8c733331a419926_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("Valid endpointId with fips disabled and dualstack disabled")]
        public void Valid_endpointId_with_fips_disabled_and_dualstack_disabled_8321ce8c72614cb69f5d9745295239fa_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["EndpointId"] = "abc123.456def";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://abc123.456def.endpoint.events.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("Valid EndpointId with dualstack disabled and fips enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS is not supported with EventBridge multi-region endpoints.")]
        public void Valid_EndpointId_with_dualstack_disabled_and_fips_enabled_9d3878fa604247a4b8b20fac8e63e709_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["EndpointId"] = "abc123.456def";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("Valid EndpointId with dualstack enabled and fips enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS is not supported with EventBridge multi-region endpoints.")]
        public void Valid_EndpointId_with_dualstack_enabled_and_fips_enabled_cacfc5d30bc44fb6aaa2206847d609e7_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["EndpointId"] = "abc123.456def";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("Invalid EndpointId")]
        [ExpectedException(typeof(AmazonClientException), "EndpointId must be a valid host label.")]
        public void Invalid_EndpointId_4a8f348b30aa4c9eae2ee615dd17b1e2_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["EndpointId"] = "badactor.com?foo=bar";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("Invalid EndpointId (empty)")]
        [ExpectedException(typeof(AmazonClientException), "EndpointId must be a valid host label.")]
        public void Invalid_EndpointId_empty_f5385262c7a24e86b2448b3fb0d8cbc4_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["EndpointId"] = "";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("Valid endpointId with fips disabled and dualstack true")]
        public void Valid_endpointId_with_fips_disabled_and_dualstack_true_a3ae8d68799341b69cb7c67fdf392ea8_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["EndpointId"] = "abc123.456def";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://abc123.456def.endpoint.events.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridge")]
        [Description("Valid endpointId with custom sdk endpoint")]
        public void Valid_endpointId_with_custom_sdk_endpoint_ea784c2896f3404c89fbb2f9cc885dcb_Test()
        {
            var parameters = new EventBridgeEndpointParameters();
            parameters["EndpointId"] = "abc123.456def";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonEventBridgeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

    }
}