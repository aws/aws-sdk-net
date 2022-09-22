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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.SageMaker.Endpoints;
using Amazon.SageMaker.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class SageMakerEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_12dcfedec7064f3f96fa9fbbee8a559d_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_ee2b4b434f2347bdbed6dbeb5a317b1c_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_f4dc6350c7cc470b8a440ad972205f1b_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_386df8db9b2842e5abf5316e6bd71db9_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_77d77e21d76b4603896853f9aa3c1d21_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_80be6d11374b41dd9fee90468cb5c83d_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_395671e47d0247fdae600b3d50d8dfa5_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_bd624c20590148a29061f66fdfca8044_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_4f9f00b2e5064dcba4a5865487d8327a_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_1aa3f5dbe4674b80a84b6b69006f2f5c_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_a477839e6f2a4538a103944fd584745a_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_1c0f909a7d9e4dd6a980ea9b40645558_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_4bcb499a46f64091b8b75101fa820f5b_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_2765f3c552044373abde80077f450fd4_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_81ffc9c86d15456b884f4e87ef5095c4_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_e3101fb035bc4730a923dbd864cea49f_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_4aad5791a2fa425a8b30d0050caa10cc_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_9fa232b1720247149976ec802a2d4a64_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_b87e729d4a65433fbec6c932766a8df8_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_2dc50191ae5346aeb18e3a6eb9881dab_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_fcf888653d324bd2b975d50fb81601d1_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_9b5f7298f38d463095cb5e92f7e68baf_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_543659ea386041e5926be1fa90f5d0ab_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_7dd9c0d9e3e34c3181137977ab7b7c45_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_26a8fa23960340e88cb0ee4721401eed_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_60bbc076a38144239430edaa3e0a5852_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_c7b21aec58fe450cb426e8ce1946dd0d_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_93b63dc84f9e42bbb441685cf92f0f3c_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_3c6235226c3d43999f47c79104573e76_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_81ec07d89f1f41a4981e4d6fe3ababbd_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_f987459f8e6e4e5bb01ae4d85b4c09ae_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_57ce5fecff8e40cab6329f38d088c8d5_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_02421c1f2cb44fd08146461f543a07b8_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_2f1864f13c1f410389f0c0f4a7234093_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_2751d9919ed04f6ea9ee074b3d547787_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_3b3684f8f4f944e582fd31a63c75d5bd_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_bcb9c0fc112f4596af7603a73c2cc846_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_55072de54ed0480fa9f0452744af3d3d_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_4cff6075b62444119eb322c3fe8d2e59_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_5bdd3e47581f411288a163644b7d8af8_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_ad8f83a32ea4450eb0fa9999a859f0b6_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_27393d0916244e11aec11ef3db9ae72f_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_06d82c6cd01343a395cdd86a0173c833_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_0560ab14d37649ecba1207fa2aad30c5_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_f2d4ab80acb04bb3bdd455e8f76602d1_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_3e606f9a09be4b96831065e977bc06c3_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_037705ae57dc4e2daca2bddfedb6ef7a_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_a808f3866b75401a884fd2b24c4865dc_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_6d94d675ec4c4d51885577af6f06b5ca_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_5aebac4577d9496bbe6f19f47b50753d_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_1eba2f8eee904c08bfd6b2d00112dcec_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_25b46c94dccc451484b126e6ff425f17_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_921720e9bb004c558849a9af07254be7_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_47f6935804ce48c19d802d2e56c229ae_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_61c599833ca647d48bb182c6d50f117c_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_1bac0391d91f46ee89fe4b5899df007a_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_a66e20b78619443cbd6f425075555379_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_6b365d575b4a4f8fac25df573ac2a4ea_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_3599bda7bee24506841427355bff8a67_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_8a86977218fe4b718e05b406fc29ca6a_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_48052eed9a3c4f44861180de3316cbeb_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_a35faea152104a518a903c73348cc7ec_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_df382aa8f3e346f0b72b20339467d75b_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_6d2800d6fefd4d0896a2ca83085c251d_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_9d48caf75de94052a03f9ba881e9cdc2_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_a3cbfa4581e841a1945fe95c2338a8a0_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_376488249b5c4ce8952d302a32ba1815_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_eeadcfb828d545499b0a3e0d3171aa9e_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_643ec891e7c848d781db659a90e893cc_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_467f7771bf784bb09233c505ccccd53d_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_fd7abe735e9d44bfa0b1d18466dbdc9f_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_c3d790ba28bb4a00be0bb6e6ba7e6bca_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_16e8a5a4f0fc462c8e24de158f3cf7dc_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_16c13ff9f3444d46b6eef293c4cb5275_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_976eb569b4f54c859bfb267c7ec69639_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_cc2444292a8c4b52b1e6fe2a5812a1df_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_278a79421564474b873608a97ec4397b_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_1b3b514eae414fe687e3decd1b89faa7_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_d546cc4335124146be0ef8ad2a1a6d28_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_43de14e0b3ea436d89005a0e28708e19_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_1377688f132d47cf8a41f4b8b95bb2fa_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_06688de3481d48cf8bad18ee67bedf6b_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_81ad2a248b5144259b09389fe37649a1_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_04f0c91e7d2345f0b42969939662bdf0_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_37e724d5e73542ffb806e37ce886f231_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_c9dd7c3328304202a9d0db66c6472434_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_62d47371ae134c02bfc5a68cfd677d68_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_bbb0d3e10ea74a1bb67779bfd157776b_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_616e985532cf486ab6fa71bf092e1033_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_a2b593543023488388b5ecc671383813_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_1ab7c6cb8ac549c3adec576f53e0d88e_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_c537446988e9499b99924dc8c6038627_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_ea453b6c995e450491fb0551b94adb67_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_12c3908ef19842f49719655e9ff13001_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_140be62b01c04d46b1a8fdc8a89d4c67_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_3578f9ffcc544a528e767e19a6c860d1_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_5461fa4bf3d147dea84eff03ac26db71_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_5c2c957346854288a6b66a76f7942035_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_c70d3f1b06cf47a983382d130fd6e178_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_25e5ee6915f543099f8c7b9495c1d0d1_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_12b328a004ec4cae9a0a950c7edd156a_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_03acfbf83c224b999d0ba0e8f8894cc4_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_a255bef9686c4314ac57d72b9a69fcc8_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_25c0d823847c46d2b67f31e6fbba8b6c_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_3987cba56b2143deb184587502c9a74a_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_012b5b0c35ba425f981e7f0e67abcc5a_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_a2889ef6a70f40088524acbd7954168b_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_afb7dd3936c44c1ab82bbaa0677fee92_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_0deea480a0894b35b908c04fc58736b8_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_59cacf9b961140acbafbf5fa36874984_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_4c6872305a844444ad8646d3eb0e8748_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_dc3b8dfce7274a7daabb78baf6222a6a_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_5831a4c0cb324941b489c8a66b29e139_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_0d0cfb8f012f41e6b15bd264ecf2fd50_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_cd7fc6d780d849f4bc3e90d480cc1769_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_25fdce488325439bbc07dfcc28ae0534_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_9781f509347f4d2cb98965bcdb671e0c_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_3150078a72684249ba09dbca874630bc_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_78f3d1b99d314375a4911d10b2055a89_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}