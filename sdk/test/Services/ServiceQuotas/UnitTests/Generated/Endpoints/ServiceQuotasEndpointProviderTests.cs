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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ServiceQuotas.Endpoints;
using Amazon.ServiceQuotas.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ServiceQuotasEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_cfffd49772bc4fc4a3c4daa4f7e8af33_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_53ea961db54a41959f4f31f6fda0d371_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_deaf32040d1a48e486a155968625c301_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_a9b722afe5884f81a6633f99c1d63fae_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_d4a2429b6135424fad21b95e5caa09f7_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_abe8afa0b3bf4193aada6be810c75f44_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_5a74c29040e942ea90c07404d1a5c826_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_add9c39609684e1fac1d2439685aa7d2_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_7e2be641d1bc4f149fe9ac9a5993622d_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_84b683ee92704523816db2cd336cf970_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_0887a1f0f68e4d3f85ecd7a79b16ef8c_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_e6e32151771a4deb92be3363f81195fa_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_cce7e957eb3245c98da7733c8531f60d_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_576ba1db5aba48b7a40a13b6b02c41b2_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_ae6276adba364d2eb55d82506ffea4a8_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_2baf8c8476bd4771bc14411da74ae3e6_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_ae48059f4b0d4b06925bd0b2d1f85b7a_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_57f446415d7546fe82ec8dfb497ef56e_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_7474183382d948ef99c7ef8ca25c8936_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_75bdcfef8a7c4e59bfbf0615a13ce5b1_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_97789ca1223346c09f5b6221ede7fb7c_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_2cf5abe9653846aca3f5a15af9cd8085_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_a6321ecb9fdd4f5b8d95032c7dddf65f_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_0672e95f601a45b68b52d97ddd6bfd4b_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_b11c62af44844e21a5f3d59851be7cc5_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_bc473b8e51d1406aa318495bbc38e450_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_af2a7d88a74548cd8e6b64a7af4c4877_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_aacabe07d6974636b81f23c8a3d73cc1_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_b093b1e318c04c148262d7852984b1fb_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_64a4987e0c1942b8b6d9a9c550b9e1a0_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_79c0ba9a98f84123b63093cdf41ec25e_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_d341072408774ef0870745be69cb0f50_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_65fb361221f44be89c50fd3d4fe5a878_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_b26500b9745243f6b7c5c56e173de7e7_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_b496bf470e904d3d9cf4ccd64ef620fd_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_a9559bae60684db9a38b32e83a3065ec_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_6cc16bf6498440a6aefd974d18646e85_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_c2f16da8dc0a4ffaa3d160ff0988a672_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_6887abe6b91743faad0a7a990bcde5a3_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_1f99536c4095426f81185b39a2b8c79e_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_85baf3e9c3b44cba88b5dd162e936a23_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_f2f6f25fdef04f42922614af527fe27d_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_92decbec5353433a95b80e9957dcd287_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_e367feb4dcb3403cb10ac23d69bc08c0_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_587c93715de44fd095a7a9c5347071a8_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_c937e0b6b852491598a31475d2bb7a8c_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_7c00a8c9d6794edc95d81ea236912ed4_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_4cdf77a86a784530aac039e0d8d1c83a_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_c1776055b8bd43f4a3aacd6c94781f96_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_e22b85e110ec40af95225dd44bd76dd6_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_3ff2d76b85294c0e9fc71dd2ced42db8_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_ef9ca98ad4b1449f889a78f3ca498395_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_000ef6381cd14bbfbc7bfc158d3d95c2_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_a6ce87777925463fad729985d3c4acb2_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_bfdf8325c66548328a94bdc536c9add4_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_069bccbf7cd34854b415fcf92648dcef_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_57738d93dd3744d68d91d1265cbbda95_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_1bbbc37cea294d159e9c42e1ae0d0177_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_c946621891404c0997251d16d91cd80c_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_cefa6929a57d4262b838739b7fd67ae8_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_2756815cacce4ea48ecc37eff2601e55_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_0a045c3fab6f43119bf9423355ecd850_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_e028721844f246798203930320922664_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_4ab3d216a0fc4bd7b836bf09a81466f8_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_f69b2651491a4c32a3d98b7e5878435f_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_c01fe0db8348400bbc6c401242a280ff_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_f96ea244369d4e8e888413ba1ceaf4d8_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_afae5de3b78d4135a6027a9a8a48f3cd_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_5cae33292584425db9968bdc9c39232d_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_437ba7d10c80467fa8adf366fc15c20f_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_9ef008c6567b4c3c8e841009a56d7250_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_d35c0f2e6eaf4922a6d60f055432078d_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_c7df2b50be0e4452a70acb30f61f686c_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_a52e9fe272a54150af9ac30b8b6efd93_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_f40113d2f2654aa8935c756883e290ee_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_5578c8b7043d4ccdaa8ef589be49ada2_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_5ea0ae2365654a109a8ee1ace4d01677_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_b41c63b6d67449eeb68bc28a91116eb0_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_8171bcac80354313b03d84609b048c49_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_dd5ebc8926ae46d482a8b7acfb93baec_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_182192c1b5594ce79b90727b23aac4cb_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_546585f748754941951d1791e02c8124_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_7bb60a45857c478aaf30e6a5a73b3c5e_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_38700707c08e426b9541c40cf5a4be83_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_1c0f02928343473b81d171e5976aef59_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_733f9d57a81746cd88b16a19d3919eaa_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_1292c34d3ff34b118621e4bef3ded67b_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_ce40b125c7604b2cb4985e9d499f0855_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_792e9a12fa84454598acbba85d9a8425_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_f2f7c6e92e7b4d49902329a74a2a257f_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_ded46271184a49588ab37feda13a57c3_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_73b698e045b2487daffc92d51eb1e5bc_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_cec040813e244f8194b9fb50649d0d7b_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_2a7c0c1e2afe4775b7a639db312f4b01_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_444c1df7619b431bb3b63d96e424980d_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_31a03d30e1904f7baf37621228947711_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_a875b9e152514c87b758ea4bd26c791e_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_cd737c69e10c47c9ad1289d5565e9bcc_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_accba42124bc4c5aa2be81ddad4749cb_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_5fcb4b348cc140ec88f73fbf4ea457a7_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_42ce5fab6d6d4505865242f7dda755c0_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_b8ccb4e8cb414636b84979c0c8b3ae1f_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_1b17666b24c94effbb7767b0a6e2c5fd_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_1c58aa6748d249578c69cb37dc1a407e_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_e003a6c235b646299bb4414e067e8cda_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_6596e1b220f840e68a1b512bc5c93ed4_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_292ddfa55b2947679fbbc3826cfac7a4_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_b87a7f8df1664702945224acd6aa3584_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicequotas.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_7efd9787652843e1a822e0990940f826_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_744946518ee043d7b58e225111982816_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceQuotas")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_e2ba2e073f8c44a382e8744de099c91c_Test()
        {
            var parameters = new ServiceQuotasEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonServiceQuotasEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}