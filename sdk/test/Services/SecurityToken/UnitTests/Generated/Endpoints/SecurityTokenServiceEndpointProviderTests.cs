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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.SecurityToken.Endpoints;
using Amazon.SecurityToken.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class SecurityTokenServiceEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_46e6a68875ce4fc084b971c8b6bd5f9f_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_5408f38bd77c45bd919d8433115415a2_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_96964c87de434c28a58b43a07672753e_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_054ec0b59fa14f24b40b2d3496a4d614_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_f73ae187004b4b2288bdee3cc000672d_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_9989dcf08f1e4334902e5147b98f2798_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_801a725de3d64c1586c52e9908d2f186_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_3658298e22784447a5969bd255858614_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_8c023769915f4f7a988778a0e828dc24_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_6ae5f7aa3dfa45a9bf753378b4018ac1_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_01d57fd5910f422b8af9d2ecc2e86b74_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_7743e621c8a84d65a13245c3e46d99b8_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_fefc479ca9fd48d6a4cce478b8a0a2da_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_5418c273cfa34f2d9ba9e8d6a8b9cf58_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_97d1ba0a5dd747f2ac299e0d8b1a779c_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_ae1fc54408254c8b90510a99e25ce2bc_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_edff51c3443f4d6188c2f8705d4e05d9_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_dcc71877e3c44106be92135acbdabfcd_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_461b8fab0c724dedaa1372f90c98d50a_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_4e1428056bf546fc8473e5c0b655a33f_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_2d9a4d0e73f745cbb1f15bf571b88368_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_0648426620924324926550a653cd80d9_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_c52887a1e8bc4ec794e9a79007278c37_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_a8114adb03574b8d83de27c9c73a5ea8_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_345c5e6ade6d418496c48ecc7458dae2_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_a7a4d6ae97e94d0eadc28f023b6e4da6_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_a5b0c81aa2ab4e6481bbe0097eee9b26_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_5d2221fad8154d84bff3af0f19dc7d4d_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_5190c1bc9bff498788ad581be6d080a6_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_9533f4e1ce494bc49cf3d0af275a93e7_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_d7fded356c234a928f481e7c413764bc_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_cb8bf2c53e4d49e98a8f962e7577ae45_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_fbd2cc27d2cb40178ea7f583ea5d2c46_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_ada46208e6aa454bbb041151b8635c8c_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_3c6be15d0c9749e388b8a1c8913a9d9d_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_5011666489d248b7a7ba1dcc8c216c4d_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_2fa842b749c14d28b0c2144c940cb74d_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_b7f7488eaf8144ddb09f0b5fbdedd6fc_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_08fe7bf65d0f415d901ef7a87c6feb07_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_97d33ca7802544e4a86ce9aca1d96c8a_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_55f6df806f8644e380db794522d7ef12_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_cf0fdd49784b49a1a436056fbba2ecdc_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_a23e7d89edf143b3b7521841bb237861_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_11eb0fc34c7c4fff9ad370bb74e69060_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_1b0463bb26c845848e88af54d482436c_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_280cd52bf56348dca14bfaf9fa872a6d_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_e0bf1f7d9c1a4cf2bcb290ded460a781_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_4c0156e1f2684753bd42b33fa999fd65_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region aws-global with FIPS disabled and DualStack disabled")]
        public void For_region_awsglobal_with_FIPS_disabled_and_DualStack_disabled_eb659da7ae0742fa874b1621341582f1_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_365717900be64b14b8dd143f18ed8ec5_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_6c891fa643b643f3a4924ba9e8004b0b_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_90eeea3f72f24b789c5fcafcb957d1f2_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_6b4bcefcf1a1450cb34db16c2ca956ac_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_0f113fc146bc4928a310196079f9b719_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_03a999dd278844408684140dbf11ffd2_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_fe7d899730ae425ca02ffb739132c351_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_548efcda92474558a8347f7a0632e023_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_a104db55d3d743da952a45561af70d74_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_01f06c7ebe954b94a6deddeef5e10a55_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_0da8fe664fc344189d35eb31f2caeff9_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_a17393f8021442aea91a50e965c2b33d_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_54b746f90e784ea2a944934e9b9c2809_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_d53cfdbab5cd4c599b6dd98402eafb8f_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_9ccc73a51cfa4517a06d46d5427ceea9_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_72901e5b054c47259273e22c31a024ee_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_6006cb8f369e43da86b08a0881adf6c8_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_cd64b1cc4bba4e30b7ddc311b395723a_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_fc8712017d4145e39b831929a281ddbb_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_464398c534d3491c92d72af58703ed38_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_56df58a1d4ed4eb984ba9fb72757de8c_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_e32ca705e6b443f5b9305703155b879b_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_ab3b9c9a7d124e3f9d3d279ed8b3ffde_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_ea83eee013f14065889ab94301866928_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_17af1ec444374a02b76afd3aa42d08b9_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_7f5a6cfe4b634400b11ffcb006c8f646_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_88d51f9862e94c84b2913ea118485ace_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_f0bab21eda6143c192866cedc264cb74_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_e7563deb520c4e6e9812f93c4d6e6320_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_0cef89221aab452e98de25c049792c74_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_11136d42abdb43afa915471f7bccc4b5_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_8ceaacb2c6f44f71a2e0de7654afebba_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_dc1c935b1d7144e98cbde3f52e22d69c_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_a389122ae06d43deaba519c455db9c8e_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_f747302d015f422eb4555861e02126f8_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_94e6234a411048f5bf0a430c1a0a8e31_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_97a11617005d411c93528cf19881c050_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_4a13a92495704c6fba2108625ff3b0b9_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_361c9f762b104ad29079db489bc8f201_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_0f3a20a5c0614ed0a169db80141875ed_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_34351c9ab0d64492af01ae26b736d6b5_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_b450fa1e9bf34e748d052b2dfe6a2541_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_965fd045974c430582daad5e04ce3d0f_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_8b262682ec11431cbf53db5a12234bb7_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_ccdc8a9ba1ba4613ac36c1598066f14a_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_ea0ab6ba85a7423396e5870f4e6d0e69_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_6dda3432732249ebbabb686f974be589_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_894dd65bd37f42e5bdc7fb5fc6c23f41_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ca-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cawest1_with_FIPS_enabled_and_DualStack_enabled_bc7ac66db490468a9739997958315abc_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ca-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ca-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cawest1_with_FIPS_enabled_and_DualStack_disabled_b35db666a52648f99fbb8b6c1cc3a32b_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ca-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ca-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cawest1_with_FIPS_disabled_and_DualStack_enabled_8d5ae31ab16843ce8bb711a3d9b3460b_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ca-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ca-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cawest1_with_FIPS_disabled_and_DualStack_disabled_e62c7ccae67c4122a94e76a650b37916_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ca-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_8b6b5a536deb42198d0cac4cc132a0c9_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_d21f8afa09624c5e9430a35e3275ef08_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_2eb360250bb741be9fbca48b2e4aad1d_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_c1a09daade154db8a16cd013c35b5901_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_9bce28fcc3f34095906a85e808d4c756_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_15a514ba035a498cb3e1a30074665f89_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_faf24a86750842d0b713f3cb078e9af4_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_f16ea8bfa987447f99485b79d7020e7b_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_6c92cbc5039a45938c2ca31b50fd79d3_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_d472f8c66c9847a0bb8783378fa9a87f_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_3e4f2769ea214de4a1bcb3dc315afdd9_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_638d0392f1e24549a18088ea6e12541f_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_96e3728e463c45008bafab814f538ac6_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_2c155938222e4a858e0aed8f339cef7f_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_3ad0f1133e8b40168151734a1a7326a1_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_3db8a3af58dd4abe99b77c3c7b7117cb_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_47a279865f894b748c5df207d5a7154f_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_bf62aa79ad5642f49bbd480a2c0f66de_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_877e882aa8844803bcc8b9155ffacda6_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_18b99b9a69304f8cbba28dd50b2b4eb4_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_enabled_1441b0e388444fcb9114bed318f83a45_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_disabled_6004148779a84048896fc31e98f3fd8f_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_enabled_2cb63593e4834d21b88b43a9a613257e_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_disabled_6501e728858e48e095813f1fc2956b72_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-5 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast5_with_FIPS_enabled_and_DualStack_enabled_578004e8def1410a99c2493fe40e8b52_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-5";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-southeast-5.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-5 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast5_with_FIPS_enabled_and_DualStack_disabled_5e1a9d9d951d42c59e0fe46569776110_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-5";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-southeast-5.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-5 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast5_with_FIPS_disabled_and_DualStack_enabled_539e0d95c8f54d638ee3ce0c15b5f710_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-5";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-southeast-5.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-5 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast5_with_FIPS_disabled_and_DualStack_disabled_c3b013ae808d4c439a758e6d64abc68f_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-5";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-southeast-5.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_12c6dbd134c24ad6874813b41ed2b6c7_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_8d2a5e46932844049223d7c184031c15_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_eddb788258af4ec6abfa19554a088767_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_2e934bee30234056a5814df092007c95_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-6 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast6_with_FIPS_enabled_and_DualStack_enabled_cd9a87d2db8f423f8b4d04df7f4f71fa_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-6";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-southeast-6.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-6 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast6_with_FIPS_enabled_and_DualStack_disabled_65433f06870243ffb9083524a76394f0_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-6";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.ap-southeast-6.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-6 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast6_with_FIPS_disabled_and_DualStack_enabled_4de076027f174bc7bc9c699c34431213_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-6";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-southeast-6.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region ap-southeast-6 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast6_with_FIPS_disabled_and_DualStack_disabled_5bf8e23186b444f48f048c9a79783d0a_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-6";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.ap-southeast-6.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_df92de828dc846a296096070da8a8517_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_fa6088983a6c44d9b0a142e21242fff1_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_e0ccc0cc6e8245b59f1c5b032e6d3572_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_9a6c5dd1c9014f96ac0c7862b4a37ae3_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_1dc3b6f8b2394f248f6f4af3a3980bef_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_94a9f3172d394c468de08fcfa6011dcd_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_0cbc77e15c254e9bafd72aa35c6d2d8d_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_dbcc42b0641d4457ae4038a11a7fb342_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_38fd583274c143c6a803c54581742c4f_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_a80dc66bb2c948d19a5d986ffe3f0311_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_c846effc8ace4f34bd3e2b7acc2a80d4_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_26a5ec4685da4ad892fdda020f7db769_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_354fba96ab134f5c82bd7a2f5ebc6b46_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_a39ed8186b4946be9fa12608ae8789ab_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_bd0ee9bdfd454bcab3cc0173779c29f2_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("UseGlobalEndpoint with legacy region `ap-northeast-1`")]
        public void UseGlobalEndpoint_with_legacy_region_apnortheast1_da50840e7e874ec0acc142562fe6fa38_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("UseGlobalEndpoint with legacy region `ap-south-1`")]
        public void UseGlobalEndpoint_with_legacy_region_apsouth1_d4df82a0b17141b7a0d72283f3845e8d_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("UseGlobalEndpoint with legacy region `ap-southeast-1`")]
        public void UseGlobalEndpoint_with_legacy_region_apsoutheast1_825626bb9cb84acba545ef2dca41073d_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("UseGlobalEndpoint with legacy region `ap-southeast-2`")]
        public void UseGlobalEndpoint_with_legacy_region_apsoutheast2_b1e9d173ed154b8e87d7983d9668101e_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("UseGlobalEndpoint with legacy region `aws-global`")]
        public void UseGlobalEndpoint_with_legacy_region_awsglobal_64a45784f65f4cdb9d6a190c1e10edfc_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "aws-global";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("UseGlobalEndpoint with legacy region `ca-central-1`")]
        public void UseGlobalEndpoint_with_legacy_region_cacentral1_faa15b8529d14beb8fcf079a3c1ec5cf_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("UseGlobalEndpoint with legacy region `eu-central-1`")]
        public void UseGlobalEndpoint_with_legacy_region_eucentral1_ccfde3eaf0b34f8a9c2067b71cb706f9_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("UseGlobalEndpoint with legacy region `eu-north-1`")]
        public void UseGlobalEndpoint_with_legacy_region_eunorth1_21e001d07efa4ad3bd925513e9e3ce97_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-north-1";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("UseGlobalEndpoint with legacy region `eu-west-1`")]
        public void UseGlobalEndpoint_with_legacy_region_euwest1_50152718b3d84f14b70dbec3ff2c19c1_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("UseGlobalEndpoint with legacy region `eu-west-2`")]
        public void UseGlobalEndpoint_with_legacy_region_euwest2_2fc13b5c5edb4874aa384825345293d9_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("UseGlobalEndpoint with legacy region `eu-west-3`")]
        public void UseGlobalEndpoint_with_legacy_region_euwest3_44086d1ded364352ba2ca2df5c0f6b48_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-3";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("UseGlobalEndpoint with legacy region `sa-east-1`")]
        public void UseGlobalEndpoint_with_legacy_region_saeast1_4b6693348b5f4eada1286404aa9d5048_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "sa-east-1";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("UseGlobalEndpoint with legacy region `us-east-1`")]
        public void UseGlobalEndpoint_with_legacy_region_useast1_8f6e0cdd6ef743bb854c0d663f55a20c_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("UseGlobalEndpoint with legacy region `us-east-2`")]
        public void UseGlobalEndpoint_with_legacy_region_useast2_e17a217d696a4df589b281c79117d6f5_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("UseGlobalEndpoint with legacy region `us-west-1`")]
        public void UseGlobalEndpoint_with_legacy_region_uswest1_1af99f798f7d4a7aa922da9512d6e32f_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("UseGlobalEndpoint with legacy region `us-west-2`")]
        public void UseGlobalEndpoint_with_legacy_region_uswest2_6fb1e3807bce4455bef55c501a12ddde_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("UseGlobalEndpoint with Non-legacy region `us-east-3`")]
        public void UseGlobalEndpoint_with_Nonlegacy_region_useast3_f45f5c1e792f435499b832728e4fdede_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-3";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sts.us-east-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SecurityToken")]
        [Description("UseGlobalEndpoint with legacy region and custom endpoint")]
        public void UseGlobalEndpoint_with_legacy_region_and_custom_endpoint_bd2b599c38d74373a3416744e8f18604_Test()
        {
            var parameters = new SecurityTokenServiceEndpointParameters();
            parameters["UseGlobalEndpoint"] = true;
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSecurityTokenServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

    }
}