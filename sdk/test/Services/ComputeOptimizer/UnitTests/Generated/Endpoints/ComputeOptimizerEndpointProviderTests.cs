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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ComputeOptimizer.Endpoints;
using Amazon.ComputeOptimizer.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ComputeOptimizerEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_377dc00127784b2b8d938ae3aefeafc7_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_a5a39f86e8214d2aa3ca3ca1deb75bbf_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_98cf15a420dd4b6096f95a293dfdf022_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_be975e24831946b282b6775cb3ce4f8c_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_16fb12e6a4a046a9a54dd4586c08889a_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_e4b72d5003ea426e89c303e4d7d7d090_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_30a5cb735224455797a3c77d4c79c813_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_e6020ff9480749f293c9b7bcba1b2961_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_4edfd65215fe4cb99cddae90b425ba98_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_84fc3eab16404b9ca499bc9b38c5fd8a_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_ce0b17795ebe456f8183d7c5bc99702e_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_8f0d6fe0937543c99b6514cd69216b6e_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_ae158e642ba8499aa96ace378ef4e0d9_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_fa51fce1bb1c48088141ce3c9d2a5322_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_a32364e40ebe4ca897e4d99a8e52404c_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_be9b19b7b9ff4083a7b6d6fe860a3a59_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_f0c64df6f4b24d009cf6aa886b071301_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_e07283a6fd4943769a4eb61cb9122374_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_d86f7cb2e63b4dff97bfb65d095f9bac_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_6568e61f50bf4bf19822d6488d8d48f0_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_050a2e51091244ee88b2200f8771454d_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_cdb0ebe17a954e7aa395727163824eeb_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_77bc1d573c034856a4dc8a7c4367e8fe_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_d7a0a114998543c491f5a9017f6bf8ce_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_7e1fca7f56a24fd2b3494e9e26a67778_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_08e38faa8bcc402881fd2c73ab0351d5_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_0425d77452ca4160985ca0fce00db3a4_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_a74069980ce64549a3944dff891ffd22_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_7eeee31b57a04a25ae0a619016ba0b60_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_50c730980f2f45679df503c40bbd6e9f_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_87e89966bd0343f9927af2accada209d_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_b17dd83af17749d09e41083b7d53156a_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_cbe886197aab4d1cb996489815e90e6c_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_65f5613616284932aa23791a1ba8aabf_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_8fbd2857d8824042b36417d933179406_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_1e1e04b66a8d4d64b70111517cbf4600_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_d64bc7c2f62d450d998a4ec4ea8e542d_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_51063bf9ccc845be8d350e769b161f22_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_d751e7c3f69543e2961414cd0d5ea543_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_624aad8fd8e040a7ba243f9c93c1e3bd_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_e7fdb460361d4e67a2f2384ab23dbcbd_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_d53490928af04675af166a322d041963_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_38786256c7484b68b15885e3932d8201_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_3055cef3f98344118c14689b0164801c_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_68ebdf4ea9724e3d8b9b33bc0d88d65d_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_9d1b13dc5b9e4bcdbe8ae7e2483cc92f_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_151ecbc8b82945a6ab680520f78a668e_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_4bf43e6214ec4a9cb57c9c562080e16d_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_acebdc8d4c6741dc8a352458a3982098_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_4afbb88238d9457fa73fd503aa18499c_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_ec79b948a4cb42b098aa8128826b7a0f_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_a642ab30b300425f892e0d50be5f9faa_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_af212c5c86d84729ae99df53191e8fe9_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_d0b2968daf2e46c391cee4ec6635912f_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_7b87442d599c46c9805494b7dfdee282_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_d0f03058f0894fee88d73c169b2a457d_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_e9a52466a62c4d0b8bdd96f1059b6176_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_e866c59362e24a4e9921de01be3e9e10_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_0b3c539c44da41a0a29c823e4fe6ce20_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_613ec594ed5a4bfa8d593a34db02acbe_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_99ef22ecd5fc4a1f83d68c3cbc23a907_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_3e21d68aeba842ee963f8529a4731b23_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_40a45345248746609055046aa1a37feb_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_d713025af3fa4684a9a05bc5fbdbd51f_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_7478addc4fcf4082ba41c87cea7ff070_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_f8d17894aa3e4494bddef3552c4fbf9c_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_c2de6b74001b4178b05ea4c0f89c2e3b_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_9ab350983e9f443aa42e6016a112ee8a_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_69e7ab88269f46568988dd9c40fe5e26_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_e1bb35708ebc457683439210a49f59ea_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_2007656df1dc419282ef37587a9033e1_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_dbe896e982b044a7b327f2f936009fb8_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_f5c513f421344db08c7cc80f5ebfefb5_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_40deb63662934d7299de7d7bdeb3be15_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_4b7e1fc4f56f428d8b111ca98ff31072_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_96046eab5d4949bfbdeb30ff99d1c031_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_3778a59077864942808d0b8eeddee62e_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_0032b6478c9f44ed8502e4cd518075f6_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_3d3a1d0790e04aafbf0e9d6ba40153cf_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_e616eeb028594232a4d0b25b8c6c98ee_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_32cfedf7d44e41cf96237a97e96375bf_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_5cd6a0ac682441a1b5080074004ce183_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_0119680b920e47298b2dd550610b7116_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_cf202be7f7304277b73066d39081c0ad_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_c1e082cf905c477aaa292d8d4bd819d6_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_5b6053097d214552a8566452098d35c4_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_6a50845fcb204d2b996fe0233c14ab2b_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_1e1e0c0fbe88401981b98d873ca5e68e_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_a005c47c57f744b3828d7f67603b209c_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_8b72278acc1b4377b0d8ec81cf5badf5_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_4521ed81556944de98be373b11ba111f_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_ef9fd24ec4fb438da1273264d14137e0_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_e4939307564a4c52bb2c0e0baf1a8396_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_e5074cc965cf40d18885e29194aa6680_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_d2c775e1047a45c4a8e438e0efcbc0b7_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_2aae3714aa3b4c48831dc6397f3e6108_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_7a2be4590b4248f38fbc9df55d5c7813_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_8c35edfa347948229417411f2681163f_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_8090b9beb62747adb0e31ebeb5f20aaf_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_3daf03a130f84219b04ca2335b0eb20d_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_b56a5fb556e444399ac45fe79dd59634_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_52b4eb869cb549b2afd6969f060a29e4_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_f7c668ac7ca8448f8e64fde7193b9b71_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_882544fdeb944837acbb97d8b29c877d_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://compute-optimizer.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_89cf0640ffaf49a0b1f846e837690e0f_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_79015d501786461a9e7e8bf4134e7314_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ComputeOptimizer")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_9d9514596da24328ba5616b6bc3de30a_Test()
        {
            var parameters = new ComputeOptimizerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonComputeOptimizerEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}