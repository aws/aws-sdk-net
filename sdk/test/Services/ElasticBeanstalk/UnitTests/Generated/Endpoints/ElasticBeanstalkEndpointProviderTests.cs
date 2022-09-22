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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ElasticBeanstalk.Endpoints;
using Amazon.ElasticBeanstalk.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ElasticBeanstalkEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_2b95b82d724c4ffea87fbc91879c3bed_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_f21e6c5fc3944de0b302c394afd2204c_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_387dbe0fcc374e3d822f9b85d235fc45_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_dde400fdc74744e68f0efe2aed6f07f1_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_7f30217ffb404581b3d9c18204215aa0_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_af4aca19be6e493d8d912b298bb86cc4_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_1eee99ff29be48488d665a9d50561a5c_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_ad2f48674c154471b008b8566140fc85_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_8c56891477de41dcb4a2dadabe7d2d1e_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_45f49481a3984337805967ed0283f998_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_a3f60d47231747b2a1c9bb230e52d822_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_fb30f8d9d21e43ca9b1f23233420652f_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_8bb52a7be3ab4dea947e9bf03d763df6_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_0305dc0cce8a4ca2b582f504d19b2ad0_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_bae482009ef3454cb3a95c8ce588bae0_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_d398b5bdd21940a4a736a9bdbc163ffe_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_0bd458fd39c040ec86cb243e8397dbdd_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_094ecd1f7dfe410ab082d4208f13c3f8_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_2393c7e0755d43ddbee259e05428d516_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_c2baf123d34c4c81979b96fa6ca91be8_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_f977b7c9be804f8eb7f7b49cf9e2684b_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_ce9e01e0b7074a1d99d7da94d4d4eb7e_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_2cdc54b806e7432ea2a76fc1a1e395d0_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_c16a75e9683544dc82ef73dd0374738f_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_482b7b3be93d40ceac6d057903687923_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_a57a225d61f14b0d934d3e4cda90a4e3_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_09543e3c2b75434bbe1b49874276fd80_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_90d22431512e41cf9f90f3e7fe1ebef2_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_27d75ce2e1634286a0af4d8f4404bee1_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_3206d88929514c1588b493109b2d3db0_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_ab55b9eba81c4cc1beed6962ed84f198_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_aafb365dda6a4d66ad7ae389107eb816_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_95daed8d62f349ea97c90f989de47ad6_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_6621c6513d8946fa917bd83fbca08e2e_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_7cfe51dfe63d4a8b8a539c01ece03634_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_cf71285cae9647cd9eda764fc185791e_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_29f7995e3e8a47d699dd1ace1f5aa55b_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_ee6f50c1a6404ed699069b4ed1125344_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_34d69bdd65164540997e9f1e8ac52c89_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_d1fcdceed5ae46939092bb4c9048734b_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_040870e8b2f44272ba3eb7919879ac00_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_acff373e92db470599ab3105be304892_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_ce4211d58e7748dda7f255ed457d5b9b_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_6bb98a063ee4457fb3c55b222c258c4d_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_5a834ec0a151482eba38efb96a134221_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_e1277eeff52046f19c035b4aa11eaa18_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_33c1fe86dbd64cbb9677c121fbcc44ec_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_834b9fc0956842e6afc3c7f3c81f61bc_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_83b57495730d41c08b8c6310e4cc74f0_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_8ca116aca79444e293658c2188ea3cb4_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_eb8455009dd44f179afe96aadf602949_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_f6d2ddde02c44e3f93256a11e7ea6555_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_b58bb83e75d8459fbfd25223b585f483_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_dd45100901bf43a19b81b187e8224d6d_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_3b7cef3df2bf43f3b19b5eb717f19554_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_a7e295bd04f443d38b81875d0827243b_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_b91e6c8d6ee646f58f8cfbbffafecee5_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_2a4f5110081041b7aa1609db9fc21bb6_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_0e0411dad1174e9e98b5e104f0718e9e_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_c1d8f7f5554549e9bd312955a3d16985_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_03047570069c42308b700c7781f8540d_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_08f4aafb3737445c9108d00ee7da3594_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_78630d1950a54639a7a97f038af3138b_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_89ebf6e707c84306918a2ed5d5e02b75_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_b895884f65984748aaf170a525d4915c_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_87a2b817c3d64008ba62bcd917fe3721_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_f9a9250c0c6b4720b43f9146d0c2a4e2_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_998348f05d6c4ff9b95c76f613270f8e_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_96bc3c1bc7684fb1915d840f89632654_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_2fb1a19d33614627adbc1217a4234576_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_22a5a49e42c14fe6842812840f80b27c_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_bfdc9e4295ec4b6f848205e6cc289bef_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_96be246b524049ba827b0f11759c177e_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_0c3e28a96008427f92fa36c3c3e6357d_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_86cc0cbd054642c5bf4383f8b19538ed_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_30f9989e61ba4d1b911fc6940fda92c9_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_f8b3a59a71c847a698c15dce12bc28e8_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_f7e2f5c9dda6477a82a5c6ef4151b088_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_a28df97071ff470d9e83362ade69e569_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_5ba1c8a9784045a9a01baebee86526c2_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_b73acc1415d94f5a96227eacbc72b45d_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_6755d40c94c64b6099ebfa299e73508b_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_33497e904c6e45d298bae95d81fb58d9_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_cc939aa23ebe415b9da96dc466c8e452_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_356623f0c6cd4894809d77054a825300_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_b5ec805b7f37425c89cd18623135c8ac_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_01cf59b562074bef8f1510d868939e95_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_e34da40b8b4941a9baa5c295a8815b78_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_f5d2371b427443e684278eb1dcf27be9_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_f4f7f50f1a124f9ba231ef3d1e1cce84_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_2e4a121297534b4e997fc371b802aa3a_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_9137b2bdc3b14fd8aa585ac9fbf9ab75_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_8c5652a9d748444080fae0b93b57520d_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_358297447f884d469f6830dfe6817983_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_5544691dad6348888e27cac035ab68e6_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_cac8089013264d2eac167298099f43be_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_de9b2ef19dc544cdb97431f2d7a96b55_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_88fe9059a0a841e6950cde7f5b28aa11_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_d1fe6685a2574df88e1ea0c420bd9477_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_361e5b738f5946c4bf4907a66b337317_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_a9582081b4334fe880919c46ff66cbfb_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_4897177af2f0432e9a999f8957ec680c_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_6d6c7f53397c4b658b5fa97077c78856_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_590f084170b14116949c2c5006bd101a_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://elasticbeanstalk.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_fa9347d51c2d4f648c4252f962b585db_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_18b1f1bad3694da7a9e341c520cb4c14_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ElasticBeanstalk")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_837b12ee340b43f694de6c1510351adc_Test()
        {
            var parameters = new ElasticBeanstalkEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonElasticBeanstalkEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}