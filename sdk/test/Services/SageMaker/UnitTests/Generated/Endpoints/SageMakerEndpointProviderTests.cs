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
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-east-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-3";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-3";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-north-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "af-south-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "sa-east-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-south-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-west-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-west-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api-fips.sagemaker.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-isob-east-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-isob-east-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-northwest-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.sagemaker.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMaker")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new SageMakerEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSageMakerEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}