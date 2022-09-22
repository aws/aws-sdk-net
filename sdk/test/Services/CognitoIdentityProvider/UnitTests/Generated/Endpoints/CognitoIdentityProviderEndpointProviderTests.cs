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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.CognitoIdentityProvider.Endpoints;
using Amazon.CognitoIdentityProvider.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class CognitoIdentityProviderEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_dc943cee0aab45c9b10a91e53922fdd2_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_0afcc69f79c443f285c7c504b0e4a042_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_a3d0b154e93e4674a387e80adc6e4776_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_c3e61e764e574e32af93ea93f83e60a0_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_a6dd965c689b4ba1b2908cf83fb4d029_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_80abb657cd9748449f535d3a8c834102_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_435cddbfa3ad4a5980bb68af72b21089_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_3721ab5846eb495bb36d48fabf583d5c_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_83a6426ca0f34943b3a550673dff9443_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_07c78233ee9147dbb4ca85467921f6b6_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_b966d95dd61f45ecb1938f27d2048ded_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_6d77e3f9954d4099adfddc56eb60497a_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_0ce9ee85985c4ae7974f94638af5966a_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_ce98c501d10140afa4def17d5923cb5d_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_18553d4d20d34e389a3a5a08987abc1f_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_9116c0142f7c49b5951e08927c6f345a_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_68ff564dcfaa440cac03c8bd02c4da8d_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_5bfa06e3680b42858ef032ef7dae84f4_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_2b71a88a055a4f58a91b6322c61ffd79_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_a7463e409b2a49d6ace189b2685dd3a8_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_b473fc3e9f83408e8cab3fb7fe935a7c_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_8bd5721bd9d84319a91940520404ce1e_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_345704ae1efc45f9aefbb8fb033b8ea8_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_d32202d5632a4b5ea9ad8999e21db920_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_e3985ea58e09448b8875175c4065f871_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_f080589a372b47a3b7413453ff0c59e8_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_a64b38d9b3d04bcb9b5b2097af782df3_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_ce0b7bbc7c474ccdb5257a7e796317ef_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_7ebec3aa02004247a443a8f517b7b7cd_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_cf4c1f38373e4002af9ddb82337fe155_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_0ccd8cc0d4bc4c338a6382e6b24ce0ee_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_727036861cb045818cbd0fbc7f93a30d_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_9b807e9acbdb4a5cbd5d98589246d1b1_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_9e0234473ea041a7b89e5647a728a022_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_9e5fd5cf84c04fcab612685a93c1d165_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_0d955d78fbba49d3a2569c16a1c7b21c_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_14bf76a66fd34aefa2fd6a48333517d9_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_a90472ea24e74c48acaf054d4fdaa74c_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_5fa0756b54fe46448cc0e857e9646d2c_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_fc650a65454e42e99e6d65df506ec0f7_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_fb18013592824958b7154379cde54e66_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_a1f2ddd8bd9940e6937976f7581e67c5_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_178b56ce77114c13be843c813473872e_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_243b9dcc5a6745a7a3b7c67b96378221_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_6e427853fba248f1a3276b8ba6f632ea_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_2bba208ce67b4a8b856900f8e58aaaff_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_80a9effe41bc49e79cca3c94d88dcb1c_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_628cff9500634473aa3b9ae7e9a90fef_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_150cefe384234c0aa0c19e371177dd54_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_528d1de79fee44e59e4d2232e9f45f0a_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_80a402c2fdf84cdcb5d118072186f7bf_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_0e0fb0c20915449ba8659868e86fc53a_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_d14e24dfbbbd4591ac03575c9a921d19_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_779747b25e8c418795fe8a535fdefdb0_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_686bdf1c95e44fd59351ccf8190bf687_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_33a6efd847de42d1a97705c67aaf44c1_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_af62591d4a1f4e6abb72205ab2a42342_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_68511d3e21974e658db2de5b3cf11db3_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_d728abbda9d34969ab14930097bc4455_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_57a7954cb9774c2fa7cda7bcaed63ded_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_a17a38283a094fc0a1df93ec5c139539_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_19403cb7b7aa4b6db3470a35187f6a6a_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_9f7218c9a15e48809dd4b16149398431_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_d06ce7eb05b349e6a7c0d480298cafc7_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_832e807b0dac4e7d9d30b4abefe9bee8_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_3497304985004c24808947e5c46273b9_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_5cdc6b9f17714e439115b263d763e7b6_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_b9e244a0e8964b2dbf55f991b1d8cb5b_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_21ebaf3be0a24c5bbc32e5c251e06941_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_95b1780cb7fc459284037ad0291f27d2_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_da57d9be82c643adb6c0714a96e449ce_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_9b210765ab9a4c718c70ac0315829db9_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_063f6baeee824f64bf27b8b44e4a1ccb_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_eb5298290b724b259864f00d8638a89d_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_41966b2551ee44b19770d603c35d2004_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_2827315ea47748da8a1a0244f5eb57d1_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_e41257c0690141c3a78cf8c633e8f20d_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_ccf82053d0ff40408bb1947517b28759_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_354fcb3ff9e44ec7b6fb42d1f3a17c39_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_9b01f49a669743b6a4bcd751be00df5c_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-idp.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_056fcadbb28c4dbeb59d909f489a9ac3_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_42e7b040d1eb4e0a8397bbc44b380918_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentityProvider")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_c68939198fa04ea88de49baa55c5d109_Test()
        {
            var parameters = new CognitoIdentityProviderEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCognitoIdentityProviderEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}