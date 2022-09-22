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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.CognitoIdentity.Endpoints;
using Amazon.CognitoIdentity.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class CognitoIdentityEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_539145ea8e964ad5a35d7f79fcb46446_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_032141aa203d41f2ba0fd226c89764fc_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_24c21672bb6d46979cfe063122347cf2_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_3eabf3ea4e6a465a8ceda2f0109796e0_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_d2523af875ca4251b5fbfb9e3b34c5f0_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_b3eb4e0f2b52464d87279a9c183548fb_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_8b544f26de604bacb20fea8f2f4ea18e_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_825cffbc69ab4f59b02a2db1272c2a39_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_e077194d5e524b1f8f4867842250ec77_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_f8e2f7ff383d4cedab42cae62b7fc228_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_e919e695e6c64c3d8d809e3f8b9e7411_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_fe72f5a60a684679a97285a75c4aa182_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_6e4af2e6bfc04f81934c04f3e46e22bf_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_395d6be09f6647d8900e503546a18017_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_bbec150641f848678824219867649e4f_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_afc4efa66825494f8094b064d6fb8c88_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_46d024d820374dc3894551df0512858d_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_168240ab43cc46469c610c70d5a361da_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_9ecf9b0a0d11406d8381d44227097569_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_6641c650ead24d2a84704362a133f29f_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_9970e9288a68487591f12a90b610eb6d_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_ca70faa0d6514b1caa517f53d5d586d0_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_661766a8087b4ee1a96e384d0bdc84cd_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_69725c5f8b97401bb0087c0a25eab7f2_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_57f14972adc940b69c2ef6f55ae8c8ca_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_90e2c9c934a848ff98a8405773855ec2_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_3ce6edffc07e4e43bbda7e1f020fc750_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_91600af479694330994f6c17fba1cbb7_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_cf791c9a87b14fbfa114555f5d46b77e_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_72d5a533dc2f494b94e679f0ce2dea7f_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_63a67791b4124d50afbb9482d8145cb5_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_c72085b8c33a4bf5bc78fcc2446a22e7_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_a104ac9bca6f46b69316561870a19994_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_ce76ba075bf04001916781c5699d8ddc_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_b01b3b06a52f40b4bda106d9f220ae50_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_2b37b3949aea4a678c03d3ba4e89dcd9_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_ee06dc9f40774bee8b086afddcfc7424_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_514cf21da32a4e25bc147fc4fcd9f0db_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_0bf8bc6078d546ef82c027a28aa41dce_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_4946c9d3a4744e0683f937318262b655_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_94117330da794e2094013f90103a6fd1_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_70e02d17a64b4ae78cfc7c817173512d_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_7d54f3c0b8ef4d099b8d357a7eca84bb_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_da871cf34a8d49baa64b6a8ee6b23dbe_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_6a1c0114f53e44dfbc9ff7e9ba0078b5_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_586ac29edc174320bffee711ab40ae4f_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_5f56f928f42b4a7ea7876c9d3da25606_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_ec2444728590419995ea41c977c5cb69_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_c214fb429ae44065855378ff27e69491_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_af070558a7674a23b0e9e467d2e7dbbb_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_5998ea04dd9e4cd79c70156660d47204_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_56324628002947c99a43e3ca906ff8b1_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_f0616bb8ad0f4ebfb4f6abcbdf1afc35_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_02cc0d0656e442e1b8a27823e043296c_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_643c9e0dac3345549cffbd99728bdf5b_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_a461f0b31eaa4f73b14057d329d3e207_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_39dd35482bee423ba3bd4b2f37b454d9_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_8e57ca75ba864b2181a4f81ce1fbf2de_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_9ed6aa1c884741a2a7d7abfaf7bdc425_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_a18f511a29db47acb7bf4333b3304861_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_8413cac826624654a2c5d735bae92c5a_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_f8af29871b4a414ea800c610b0744c33_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_f961406160dc4ab0a25150530955ca79_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_92930f5849ed40778751526f1f3e0bd7_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_27909ef9d3dd449ea212e27a9cb302f4_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_f8d7ebaf3f404b73b252f904d8a1ec53_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_94a8a661bc6e4f95862ef5c311e3095d_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_086efaf3b20f4442916bbdf9b60503da_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_2b0894ff92e74693a8ca938a6ce88ddd_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_24a6f6dfecf24497976a2874847406e7_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_0067665cfb1045e9be50298433de96de_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_b25c06f92d214aa3abfb8effb0700311_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_8c328963b36d4cce834650a1c81741da_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_7dfb83f6c7ba4de3b886bff8b9297d2b_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_4912d3fac9cf4a81b5afc44db991a9e7_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_e6cafcf1f1954688bbb564d1b1df320c_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_730043365d4942a5bda62f8c458b0bb3_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_2f9fc3de448a449590ecf44031fdab14_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_33925bd994854fa7915bbdc2ae34d767_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_1182a039a18e4bc0a80f242c5e82124f_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cognito-identity.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_00463a7498d4460b8bef106e9683906e_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_d28e69301cdd4566bcc34cb71325d8c9_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CognitoIdentity")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_b9c35c4cd327411297304673b5417584_Test()
        {
            var parameters = new CognitoIdentityEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCognitoIdentityEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}