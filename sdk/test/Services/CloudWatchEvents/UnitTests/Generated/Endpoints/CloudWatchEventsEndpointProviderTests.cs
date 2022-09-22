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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.CloudWatchEvents.Endpoints;
using Amazon.CloudWatchEvents.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class CloudWatchEventsEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_12a587cda8b64f98ad184e5748331eac_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_edc440d4363e4a45aefed81e0b7bedc5_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_7c51405a06db4d1ba58791c8b17d8204_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_b9a68c8815e84e1c8c86cd02d4807c87_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_9ea51889cb46479bae7f90b2d247af47_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_246ac84ff0f3491ba20f0f6f788ef988_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_af518eff7e1d443b8a5bb456cec40573_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_4b803a4dc42f49fda6c5fe24379d0f23_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_4fcfeb2dc99b471d8121b4d71dc15be1_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_4a9601047d1c4fd19190dec466d11588_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_cd617472e1814feba4bcff8d474d23dc_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_0021e0eafb2b43728f43ddd20e60b253_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_120c813430714fd7a5f26a69a63935c0_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_e6ac905361bd4aefac84fb3883370e9d_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_84e9e55931ec47038834f1a14c76db9e_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_dbb9396890aa40058b3efad9056e856d_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_9cccf452cb1947c891413641c5e2d88c_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_6471f86ab9d14b1f8cd87024ef741f53_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_2109c21428384134b15936ca97d9d01f_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_c51bd0aedde54f9fa00565b1100fb35c_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_5bcf81bdcdd047e5872a4712c6b5c846_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_e81a62edfefb46deac0758a5d9d14ce4_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_f6b1891712e8406780a524a0252df40b_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_3d6dcbc65f574d14a3a1b86d77790b26_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_0017ba0e16184c1082ac736f992a3970_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_4e4351dd4b2645e88890d71adf94422d_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_f5a1bbbd6527492f9f8afe5c2531bbd3_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_1985629d837d4f41ac8cd29ee8ee9bcc_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_d896f4111eb9460f94a4835af8e9974e_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_11ca6a6ffc4b4fd4912c110a4320d300_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_0f6cea17c975403b846d2e02a48a03b2_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_36e31cc501f74af0b407c4da0ad6c94a_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_4e7315cf4fec4eec85d358d550b0a5b8_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_b44c05de8d5740e5b4fa3979005d0440_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_9b692a1ac9044927b6ecf59c407c27d7_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_d05f78143bd94da79545e43caa37e822_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_f3ce38f349be4f2d906420cd2c8c7b2b_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_2f995a6b4a1549e0b7e370a912c576cf_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_ae18628c4f434c009a8afa826772b4a3_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_8630bbb66a784d9b88024da125c0f80d_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_5058d41bd9bb4edb9f10272bc07cb0a6_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_d44b674424c74fa9abb956e5fd4cd66d_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_e8c03a9084444614a478e4a0a51a1bbb_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_410d6958ba594ae892696ac05334fb5f_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_56b0d47e7ba34674a56815061229d53c_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_f3216a378d8e41f8a369f754d5722ef5_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_dcf65ce4ba4b4400a327e0b745366dc6_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_c81f907c7e42449c97c5df46485bce6f_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_eb72c67e9e9846a7bb6d47d4652039ed_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_06efe21fbfd045e09a90ef8646c1c63c_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_55524fdbf0a44ea7bd3ab65a384cec47_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_383b817cda7c49f9a3bf84924bc8988b_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_d3571cbbb8d44f72b2530d36b3602042_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_7e364bb883da4702be234ca365ed23c7_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_ae8a99aeb3754427a493f95cf7df5048_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_b7e602df25a54a02805117a6c27622a5_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_99866a71a8e3442cb098d278c5fe0baa_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_163f0c0aabfd4c6880611bdce359ab28_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_6f4bf422f02d4ff5a9bf39b8185ba80b_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_6e37ed55ed4048f2b6be30fb3eb72f77_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_6fcc05f2922e49f8873d8c9fba393fbb_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_b626a765ef6f4e71afde9940ed11a9c0_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_d386f2007e9a4ab0b977b9ecef8a4d63_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_eca48c428d1f4ecfb4b1355ce589328d_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_7bafc810e3c942e6b09db4ab2e95f536_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_0fb644598d26412d90db040f1c046852_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_f2908a279ac7449c880cbad7b85780de_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_a4cff0ad11ff4f438a7c6ef2eac3153c_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_7e6a58abf4504fa9baa5414fae34cb81_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_cf909e1dd4974677b1cf9aaa7fbb9caf_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_77223f4df5ce404895caf3cbbdf6cb56_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_ccbe6b4c94f144d5b9b0ee1e3bc75126_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_03a85b060c7246e5a57cf2c244b31d40_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_a412e5f5f46e44b3a78c890991d83d9a_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_48b2652e84b64f90aeab80a83bb60037_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_030825f506e64eed9a6d0dee5d25fbaa_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_758b4529bb7b4c18b532b1466ca3cbcc_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_e2bc3484b3de4a3dbc43a65ae35f39a2_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_b00ff0810ad047718d3ebc8d56848133_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_c130e9961bdc43f49d2387061869c185_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_45704b827cd84144af1dd9987abcac28_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_2b3d8e260fa14a8f9c0811475e85f418_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_6725ba21521f4c3b82c67540679b4104_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_1a22948c295e4317bb2ff02a38b34e91_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_83ecc8fec3d343018ff282da02a630fb_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_84d32dc13d634680a0f54c37e8b0720b_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_9f266daf5b5a40af9ccc5d37ee8415c7_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_cdfe983a8e3e4c60b82a6a669c19fc11_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_d3892465ba5540e29b689b6f8705f406_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_da8034ae620748f881ddd0af01c079cf_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_80868c83bfbd4ddaafca75e884da132b_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_f43894791a3642d29b18c82270212f52_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_ed1ae0ea4fb14bab9a9e97eb253243d7_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_5f1c488d6cc64c33b5e548db7367a967_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_f008c5f305c34f059cf1d9a09ab45012_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_b470642154bb4ef7927f9589d22bae2e_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_ede6658add9b40679b037565e8703750_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_368a42947e5e47cab5c9042f3afa76ae_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_d0f33968aa2f40b6ae8e6d4bc57961b1_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_47b3aa365a8e4709b16706fef99c724e_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_a81edd971e4c41bdbf4c49c3f9cd0ef0_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_0bdfd45807ec41a9ad6e80574771ad4d_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_3e738a3f4ff341e19460bb2f6f6bff48_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_91c58b4a9d2549f28c84d0474c359264_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_bd3f8f2659e14b44a36bec60a620e8b4_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_df4256daa3674c3884489d8994dd50e5_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_f82dca92811f45a6b596330af5bb4ed6_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_aa0296aa83974d4ba41eff2ec16d601f_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_12be84c32bc742089261648f6217a381_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_64f700f3e05d44388fdfe854422faeb7_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_e108254194b246c2b9e2d824368621fb_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_b56323f11bee43a4861a425ea557fe38_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_519cc6e2a1ea4f07a14ab0e3a7ffb636_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_1b06daf7456240ba91c09090b03194ce_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_7c35570453a747cf8b60aa60709b9157_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_f0b19bebcb78457485c167ce1f40630e_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_enabled_0811278a55b346b18b27126290401186_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_disabled_56c09bcb706c4590b3b527f623ed440e_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_enabled_bb2fb7f900074dd59d5fb0e3ec57320e_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_disabled_b5645ee0a70443fc96de31fc4cfc9642_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_688b6154b1fa4b56baba4075821e3d64_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_2c9b5a59008844108b4d984ada501e4a_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_7447a1115fbf4807abad66faa2f58b0f_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_e1fcb41240ff44e1b79f017fa4309635_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_e2a31404de9145688986deac26fb1ab3_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_71e5fec01ccb4967b2e0290ec93e8933_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_51062e7bc1ba4189a65e9d2df06a732f_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_5919d28e11c34cf9994f564cdd12c4ae_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_ca63b410275241b3813203efa671097f_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_9a5e0e0eb2884d8f95f37800a5bf67cd_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_0fa99b98c33b49b2a3ecd581bbcc4843_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_a93c01ae81fb44a3bf82d2e36a4dcffa_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_4f352bb49d514b04a8c1a1ebc59982d0_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_fa861f128a154f65a2048af936abe863_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_07a5caa9a06d495ab5f294a8a0d36d9d_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_e89bfd31fae743858b00ba7b16891316_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://events.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_c3affec6e7224e81b526b4f7d56cf671_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_4492764c63664628ae7a359e7ff12806_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatchEvents")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_ef70ae837e3349bab7bcd7d2ccefdb9a_Test()
        {
            var parameters = new CloudWatchEventsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCloudWatchEventsEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}