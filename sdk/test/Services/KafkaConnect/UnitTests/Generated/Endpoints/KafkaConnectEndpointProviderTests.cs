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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.KafkaConnect.Endpoints;
using Amazon.KafkaConnect.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class KafkaConnectEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_a637e6907e3744268db57c0470d73ad2_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_84265bc3c3e64f0f8f502cd836fd3dc8_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_1ebc4ba4c47649eda12d2dcfb4f35757_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_21f7f1cccb0f43e78b08bcdbc3044447_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_569be21d8e004fc781d8d6ef1134f0be_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_90d2e730ea8e42beac9d5ae2afaaba40_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_b502f1ec2cf14a90b54cd8442aaf52c9_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_98e2c57ea96b48feb5ecfa0e43289c1e_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_4afe9af3ba8246c1b230f8651ec23025_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_d386c8c1acc2425181e6443ca114dce2_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_09d07b11a3724855b0c38fc423bfda56_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_8284dd45b90d416baeb14a2eb33ec097_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_5e05f212b2354f78802bfc622827a9db_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_0479fed2867c49be9e7c6b1d86b96d1f_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_77f0b5e8aec24743a72018b67111c2b2_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_9bb2f156973e41c1a001c1958c8495cc_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_a3fa8f658ce6452f8450cc727bdac156_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_cec98fde619a4f67ab5c1d5df5f56545_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_4abddcf21461489bb2db05e7548414bd_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_5bf44c2a1fc749949a1eb63718b22abf_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_1ccf5dc1d396490da1e1ea1d5e767921_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_2bfbb6d26de74fbfa9705a36323d7469_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_22ce0b3e04a242ceb16ba73462419ce9_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_c7b342e9d021457d9ceca0c04c33a00f_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_1e52ee9c2b954496a9b52a63f15a5dab_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_d7ac3b1f8018441cbfbcc8e78ac82bb0_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_8da266aecb304557b74dbec40ee503d9_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_bc7bb2e53d35477aa119ed4e8f0ce3f3_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_a2e037b4b33b45858a14fc3efd281b1a_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_9f3d106feaf14b609ab8889de52a999d_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_c073fa12e7f24113965902af5014cbfb_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_3fb41e050e71491fa2b816e8bc18d46a_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_52cd30f6e74f4f40a3f44709c8b7fbf1_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_a98101c7cf29463f8c2472db2e8f9eeb_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_1c8fdd5841234a239558ddbd9d2c09f6_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_ede3c2137c4447368cc343db82111d4a_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_7f3e478ec6e44272843e1ec8d3a540de_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_1b4e00e1f352429e82949e9b3378dad3_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_ef46ebb5482b4069a33ce20eb96475d4_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_6cea9399f3224eedb45df6d02c78b944_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_4c00b7e13b12407290bd7c416d215431_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_08b8777d1a7441558411e36820435871_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_931bd2b978f84837ace6d9a18f93570d_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_7f510a1a83344813bfb1b5e8200f260e_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_6052283e85254f0aab796076b6409b76_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_f51a29af64f946d1806576fc7d41dd5f_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_ddf9bf2eeaf0427fa1015acc22d82ec9_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_b440a4dff837455d8bc9bb4df689b0fc_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_c3f2a1cf3b9b4edf826b7b8189f876c3_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_20af7ebc0c2d4a5fa1c8ac2ff4da968e_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_22d0b37aa4a8490ab746f3f1ed2a2d03_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_ed34be6d6ef94d31a4b589962e498f17_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_7f230cb5c5354635a5597134d5d845f2_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_47688c98902e4be8833275e3c4d9bba9_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_c0cad7b476974a029b88537242e19b9c_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_5c358448db8d4ca9b93a8317abd50d77_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_a8fd1d40643b4f51839a146735efcf50_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_bf91c48cdff84aaea2f7e5ca90c1c552_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_97c6555556b5485695093b2a0c23b378_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_2e7e7f25c4fa4d7899b7d8e8aab8d12e_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_a2cf568acc0f40a7a744466d5f335d91_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_a93116201c24492faac2144332df0755_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_1f324ad4d9854367b4634be57d8ed081_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_a8d426304a734773bdc3cb6e2004100b_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_6e9b217329594534941b28f642ff01b3_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_78ad56e038f64781860efd3871a03523_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_0d3f65d114ce42e5a0e6fa4bea6dca0a_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_e824e79035814b12a61815b1e2d5b9f0_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_8e5f5633435945db933dfdfa7413bedf_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_15d503e55c8f4dd0ad06bbd7014d82a2_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_780d780e6ebf4c6184654558b526d3a9_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_68812144582a4fba8aeb504ce932b5a3_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kafkaconnect.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_166da3b88e1e43c9adfd48847ff0540b_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_dfb832c3c6904a5c9e626f588c314e04_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KafkaConnect")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_6f189380a07845fe966da7ba2ab4e6a4_Test()
        {
            var parameters = new KafkaConnectEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKafkaConnectEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}