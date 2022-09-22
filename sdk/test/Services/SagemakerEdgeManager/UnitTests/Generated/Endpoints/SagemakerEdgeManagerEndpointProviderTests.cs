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
 * Do not modify this file. This file is generated from the sagemaker-edge-2020-09-23.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.SagemakerEdgeManager.Endpoints;
using Amazon.SagemakerEdgeManager.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class SagemakerEdgeManagerEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_cd5349569c1044b0ab5673d411d10510_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_14a98336f04247a8ad43bf538d2553d1_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_49ae4f558f154bb79d6af5ab491fb883_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_ebfef87c854a47a5af05cfb95380ee65_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_e64eda861aa543e790da81ac5644bf5e_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_52ebeb4284b5428cbc632fde91279cce_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_5a9925f982a943a8bb91834ae12e337a_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_ff729a5d2f194f86b8235edeba9d4324_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_210f028160464d7daa8f3332eec35b3d_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_f6e82a0e5d7440928244cf78341d5828_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_667ef46ed292473391214280aefc35fc_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_e99fb0f34f6c4e13b7fae9d77429d8b9_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_d25eee5d87fb4b05b9523f209a3267a8_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_474a6e8d2db14e15a92cefe815e774ed_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_53da5ffcd7de4b00b13e10c0b574d136_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_fd3f69327b1c4687984e11a245f84757_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_26c37df848fe40a3bfff7e368f697705_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_6a2ee4f0a8474a27a04ffd93cd193126_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_4cdd7acd7c604491b5ec949df373b938_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_b7a3c3950d1847b5b8c6b3b882451c73_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_0206984fe4044794ab4b3316d3ada935_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_c0fdd27a965847758ccea36d89d34428_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_b71b430790574a9b8a74f6e17a450549_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_8eb87745aa47486a85c3751264166815_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://edge.sagemaker.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_93f975e9374f492a9250d31101ac8c6d_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_88e532644ab441c6b5cdc3f93e57eb4a_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SagemakerEdgeManager")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_cd50ea9339f54bbaa7df09eed1c18226_Test()
        {
            var parameters = new SagemakerEdgeManagerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSagemakerEdgeManagerEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}