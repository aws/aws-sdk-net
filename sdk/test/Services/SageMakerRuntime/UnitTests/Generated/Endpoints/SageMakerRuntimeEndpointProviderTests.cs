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
 * Do not modify this file. This file is generated from the runtime.sagemaker-2017-05-13.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.SageMakerRuntime.Endpoints;
using Amazon.SageMakerRuntime.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class SageMakerRuntimeEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_637da95877274e6795fed58a29ccad31_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_9c7b8f554ccf4fe6a2bc6f5a41c55264_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_c183b8c0b57649c095b9f4a66117bc25_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_cdebc422fc45420bb18c67177724c9e5_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_fb28aa0551494166aeefa279a15253f5_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_5335795dc1a34b749fee0f6e38e8948d_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_cd9d199b2c954c23aa92cec5dd9fb528_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_d819bfc3144c441f86fec3d4ffe6ce19_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_b15785f5667640b7aec7c52f3e4d31bc_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_f4be9d888d6940c4b18fb631c620772d_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_94aee3d99a7646a6b57caa97509d9771_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_97df1a8386b44984b03bd69542117dae_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_7555d2a72c3d4df3a710bf649bc12e2f_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_13b605afd43c427e8ff49943df4ed0b6_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_ac3288173bc8447397e0a41e8958f4b5_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_e1d89d51d7f4457e80a144ece56364c2_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_9e796d675cfd48ea869fdf34eb451fd8_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_8c83b3393b46426c8d7dea7713571de6_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_289462a7d0fa4a919e8d57c273f05587_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_0e964fb0607045f88d266bb39eb75f5a_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_f4981b3794f94b61aaaf0ec63725fae2_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_46b6371ce3d24049a00a7942ed36c9e3_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_2b7f54c4e9f3462ca35d266fb2d30760_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_492a1886341c45bfbd82e704a9a2408a_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_2d9bf515271d410b8d47b0b2a76521ad_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_2f90c9ca96df4820a81809269e60f6cf_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_cc6dc4201a5a4b879dc82432f57716f5_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_d253ec6b94bd4bb9864fc1f5a101bd9d_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_b625c698209e4fd7929c608756eb5f04_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_e0f8f8ed98c14875848540b22c9f026a_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_20367e06693d42c9a7cdb7cf4d3c41e0_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_e644ce0f44ec4dfb9c9072f09c622d8a_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_158545ac372746c78ad2495e8b25f253_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_cde1fc2b1b6f4612aa5974f4e145ec2d_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_fab26f3b68614cd38d02ef97ea98e4d5_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_f1e1d9475de6431994f3d1025e486f25_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_828e7b92e0824bc785226cd3619856a8_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_5ee2cd29d26b4b9ebac4c7bed659121d_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_d207089bbd764586b8852ff2d8bce0d5_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_366ce53059634a138967b4d1f5bf88ca_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_f8d02dc939d1484d9c3fc7e056ad0717_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_7556d308e3e14fb0818115d345d8c1f9_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_c2d6be9e3eb540609d4f27e24c0bbc8b_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_8b970d724ba1438ab5e7d45e33f5f92e_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_fc3480ce330347a4bb4ef0e8681310cc_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_becbc47e616c4b17bfb35b277114cd20_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_9c384dae23d2449d9741885b02010737_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_da0aa88ce1de44d2b646ca5df681a1f6_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_9d8a4b7f68ce4f03896f1f20aeba9864_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_8ee1ac1784b6482ba93da76b469aa79a_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_56c7543095484cb4aa473b5afd9eeadb_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_fcbe4a695be64e018042f25fe8a949a8_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_c8b12e1a98d747aeabebe077b72bc46c_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_53ca816ddffa4530a735412e60b68449_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_94a881d948094faaaa1c0d12fac6d1c6_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_93be987c150d48f69d62fc678dc733b1_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_ee3c04f4e8fc4a16b1fe7439ecdd2dad_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_41eca653782e4cfebe47611767c27f80_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_92a21c2c19694f1ea49f65d767fd5c2a_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_1fc8d6508aec4b699b60088318bfeff7_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_5a8d6f96acc94dc398382efd015a6f59_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_cdaff80d4096427c80e76431b97bc57d_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_1b3be8ea0a554c8bb8d4b04fc98f442b_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_5f9460c12a8f4a4d8b02923f398f01cb_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_ce5f0fea2e544559b2bc77cfa8b01b21_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_9a4fe33adc1a4df1b96f4d8c054ac6a6_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_066de9f8d1414240975dd73992e210f6_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_63aa95d1551345a2a00d68d843d716cf_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_ba3e03e00e0f4ac3a29f69f4a228729f_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_6bda22068eec482aa0b6c730170025c0_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_83755ec105e8438ba31eb8d8b0c41412_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_f3efd22c472f4a15b6c1cd81a9800ebe_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_8d8299df667a4c99837f18d2ff371192_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_3f3083c8be214f468b165f601112677b_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_7e84a3e118544d25b25676fa42e89c51_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_18bff5a39ab143dab2cf70a914323a5a_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_f9055ecc423b4deabed257ede2276705_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_2101aded212847d5b2d71e986b460469_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_03e1304c520c47a3afb46210205f4706_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_672add110af7410c95aac9aae13d545a_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_1ae90c2afded4b2dbe527fea03ca1837_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_f3712d0664694b41a969dab5ff082804_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_33525b60fbd142cdbb42b6dab84b20c7_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_5bda1c22451d46e396eb3f236c25261d_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_4df295a1f8cd45e9829dd7ed797986ad_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_c02f78bd8a114c399871a63706d268da_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_a1205744dce04ce7ad6660d1ad58b395_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_94891b256a3d42dcb2e684d059c71d8c_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_cd1367681f534a89a701b4f3fac8e6c6_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_ef56d0c9b57941f5a11027d418f2134a_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_dba470c50d044202b9ab688add6fac80_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_472327521cd145279f3367ac5e1cabd9_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_d3993842dd2e4d94950002d9912ddfef_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_ebdb83cf0c884b00b86605b0f50c7b48_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_1537fe2dad3d4219801632765b0a3b96_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_8aa87029f1244ef1be276a8313fe31f4_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_1fd0e30512fd43dcae98deec29461850_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_2fa632f9d2184921af9d5b3f2150dbab_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime-fips.sagemaker.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_08a146b6627b4f089ac8b86c6a822a5b_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_fec3e63f8b1c4fdebd862b95c556be95_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_4a61ad768d3b4d4596835c258429c4ae_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_42017b042a9b4fda9b8fb32024044431_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_bea7f042dafa4b668ad67d27c3170365_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_511126f24cd64b649c87ed7c67212bc9_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_9457fd89cf6f47348a9ff134a29e124f_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_0ff97db8b00843e0aabc9c5048935f2c_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_7b5ed73ac4724c15a0b2899018953592_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_81660621dd6546ea96397fe287b0217f_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://runtime.sagemaker.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_f3305e0610b7417b8cc95e6b0cbce2dd_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_8a47b2a7b4164ff3b49884d346cf9f51_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerRuntime")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_ab7a5bcd8a5d4ebcac08233d63f6f07a_Test()
        {
            var parameters = new SageMakerRuntimeEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSageMakerRuntimeEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}