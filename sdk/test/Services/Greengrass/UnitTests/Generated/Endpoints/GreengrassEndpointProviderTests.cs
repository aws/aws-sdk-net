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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.Greengrass.Endpoints;
using Amazon.Greengrass.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class GreengrassEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_564736d0b80e410db9d5fac2df986679_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_909500bd25c3486c8359445bac2b717d_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_9871262517874463b42a5f21f53099ac_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_e6af064e2c8c42d5b11634f031c3e761_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_8e8b68f9e18c4907bb16ceb7b1efe4e2_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_464383e255ab489caa07786b68352bec_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_5d703e6507ed47689e0c1ee050b81a94_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_21d64ed5324d4898a4d99bd7de45339d_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_672166f1eeb244bdb1157c90fdb2d5d6_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_913322d7360a4165a4849896208ce487_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_cf32d5b2552a4c348891cfc3c6d04985_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_803d109829fc42eea9926ad82c473978_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_5ebe5201e6da4c4cbc13b84bb7c39f87_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_6fab9ff6ec3943c6ae98f0370b8b2261_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_087fc0e1bb7b4afcb7d55403a7bca764_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_53521da9411c449991ab2dc5ab3874df_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_13aedd421a294c83ab7d9961da8a4b69_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_a31dc74f0bec4ec88f04c8047a2530f3_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_3c6e769321ea4da0bb2dab25de5e3fd1_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_c40dd4b289b743f2b77a40c0521d8b61_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_069f58e0bdcf4c9384744fbc02c2e049_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_14442245cca0465f96d4eaae297d9a23_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_8e37813bf8bf4c3da6a5629266695e3d_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_2e9ca8715adb4776b7ad97dd1dc24c6c_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_28d35b1aa5b444fea05ffc9aff19b2ab_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_dfda044b9a7b4b7e862ed3a96a3c1000_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_d317126da7d642ee93c7fe52b0e8b0e8_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_f763ae33bf8b4e3cbc17d163988d8e88_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_c72d510450a446dfb02b7f9caa7c8644_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_3a2bb27cd0944c7c94336f039d5ac4fd_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_3ee50b8468674639851acddc15fd59b8_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_813e4685600243f58ad3cfb668ef030a_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_e7b73345ccb64e8b867f6fb44f831589_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_2fd4cdb0626144fb885d08542da8f37b_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_206eca53bed64edbad376698a36f2d81_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_3b2c588a02864512bd6f1c075d218cc5_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_460a79ab20584a39ae1dc6cd2f86fd64_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_6439b98f321a4e748d978e669fac586f_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_d76e470b409848c2b3fcd4c5de478e0e_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_7c6838846b074883a9c53476f91dd0ef_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_63c9f04d7fe3405c86c895c2f52959b5_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_33ad77b93cd14251b086fd841c9514fd_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_52cec098dd0541bf84dca9cea0cdc84f_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_1507accf59444970bf56f7cdf28ea105_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_7863b9d5d08f40cd95dde0122ea05283_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_6675ae68e59f4adc907078c06d73183f_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_280b5b0b4e2f45a68264755778ed9f17_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_6115e0e8d03f47749658919747775be1_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_3b4a13731d2646da907e0fea789ea19d_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_a32213c4d87143c6807944e221d11351_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_4312135c4e2846a5a4f2a39055ae9a9b_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_415a8232760b4e779fc46bbe1c16527b_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_8fcf259976de41efa4f95fe5fb0c3ff4_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_57196e2867de42a8a96fca0a894be596_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_d3e86257e78b444eba36809f4ae2a89b_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_ba0a7708677f4d3ab58b2b76538e5513_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_e60d4aaeb42a42b58448da71c2d86ffd_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_f6ca0e9490234afda77641e7da28e9c8_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_34523275e8284faea4ad9106f1725441_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_2cc4370dd32946ccb2b43ba9fc69b053_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_666fe1a51cfd4d369166dfa2ce2d8eb3_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_2b00bae5ee5541fcb31111acc20ff232_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_adbafcfaeb5b4cd3bbd92ac00888f17f_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_6bbc18279cc041a2a2d1147360eb365b_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_5d8e7b978c374236a7bb94e95d2efe5a_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_55b2130869d849d3a886425cec6a2e9b_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_fdbd6e22e7724b4b969548dcad647522_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_3c25ac188fb44badb91cd55c10325785_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_c64459d07b2d499abe43ad4a980e6342_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_3359d6e9133c42cd9490bf2a6f2e7d89_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_3b3c3e20dfc54abca8f5c64063056b31_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_be33633f7a8a4296bfded73a36176e4b_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://greengrass.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_c2167e6cad764d78add8344dd549f456_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_6ac985e896a4477089a0a6d8d7d0292b_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Greengrass")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_f73ab1c7bc5540fc8f9a7c208398b900_Test()
        {
            var parameters = new GreengrassEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonGreengrassEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}