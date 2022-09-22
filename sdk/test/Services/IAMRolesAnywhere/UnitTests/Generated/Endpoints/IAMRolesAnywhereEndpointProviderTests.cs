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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.IAMRolesAnywhere.Endpoints;
using Amazon.IAMRolesAnywhere.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class IAMRolesAnywhereEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_0092a42d376847eea2b1419933eddfde_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_027c5ae6cf114254bccb39c14c7a4d0c_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_757dd05bb23f43c880fbb8f756a31576_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_5c84b10d6fd047958c1851547a99273e_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_c419d6035ce441d6934660b6af16c704_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_fbb3f4ab81694d57a9b35f117bad41ab_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_af0ab51cb5514c29acb005bd50af1e74_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_9abc8f6a456b4009af39980aa327c77c_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_cd2b2e859151430492d5e07c7adaa5f0_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_1dbc32723abc4e2e847b8459413747fb_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_d7982d6d82c5428bbca74cba571116b2_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_8d1359b5c5e4405cadb0cf753569e93e_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_b0f487e2db6a48a7b6d5e755e5c08f36_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_e84fec7f6beb480e8ca2300ecebd330b_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_1f2850837a4e42bf82ff09ac954792fe_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_ddebe37ec2e94fdab82f3fbced7d98a8_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_cf95c24d02ea4953ab984193dfa1ce52_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_11a2728ae3c04d76a435bcc9b850b478_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_ed8d0c90ba0047ba949502f57d776281_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_af106c798f3148f48d9310c011d822ff_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_ee36815f965b4aadb03539c2cc836ce2_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_4b8fff959584412681ff49524482e257_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_e6c807fe37804f07953b54319a02f06d_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_94c5992e35424235bbc3a0c1ab6e66f2_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_35034744be254b81ad620857124a7dc2_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_4c336a066111409aba39fc555c31db65_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_adcc125441ad4e18948716ef000ce014_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_525dfe1c030b42f29dfc9b76f2f9e807_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_c44865506a9c412282aa08876bdf1b1a_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_62c8fb34b5ab4ff3a55affe98464f175_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_9253957c6cb64afb92e0c5acb69fee89_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_6f09e435929b4f099a1c71bd0a8251f7_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_2c280636acdd4a259122d484a63a285a_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_0c4650f1f8944f2a8850dc04e9f7022a_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_6d6362008cfb43fc9e47c9e7f4305187_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_ac1879a829a14f38b30dcea0213278b5_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_67632c01c2c446f6b827fdc5bf4bfa2b_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_88af1347167c4109b928f8586898a816_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_9f4a7620621e40508382c8b801efdb4c_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_4235b977932a40dd94ef166e61fed71e_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_f7f70240f8614f8a8b857702f31113f6_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_0d4264c7313f41dd82b01a45f8689705_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_038e0a17b4ef4dfbaf74b73d85d1fa7f_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_ca7bd0ba02c84aac814fc1fcf6245d75_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_02aefae752ac4eddb50b242cf9abc640_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_0ed02615c383492bb782adec49fa0c5e_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_732fb0eff03f42bb87b99df921b4004a_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_7bef21a9bfb44dc18a05778bb0fdbf0b_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_cd923111f3c5466cb47ea109e161a762_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_c72d0c94d1ee487a844525778452f2b3_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_14fe0d439bee44b2a92697b17b112086_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_b6ea43a8cce048abb4b4bb4c3a0d054b_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_bbac6f8cf97f41b9b5fdd59648cf9e7c_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_8f675737ee67493facd115e967e43852_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_aa34949ad14c415db6d29de106ae1a1e_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_0bec886c18a94a1f827bbcc49d8834b9_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_8d2e6714e4d44215abc20c9c6ab35cf8_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_e6cf7ef698da4971b53eae151eabb1ed_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_429fa66c733d4dce82c4c687a56706ae_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_94ebf06ce57b431a96aa889c82330bf9_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_10f89898f0e7409e98cc905890e1cee1_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_47d5bda58e364744822a1cb6b3943421_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_4301768a65444b0daf9fd3c672382b7c_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_33cea57d6195466ba5c7656b7d2a5d88_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_654a1b57665f430fbe8e85b1d5bd594e_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_50ae937a556746199d18ad77e864596e_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_1a8d0454570e49e497d2133ca52c5237_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_149404d4ac8e414c8e171576432b5e99_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_ee05be37078a43feb91869d6767da988_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_0dcdc31ca7ac4547968ad0b32214e03b_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_55905f44775c481c9059c4937f143058_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_3be799b0e2174b2cbde778ecbcb18223_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_8c9b2c5bee894823a3ba6b287add84b7_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_f53cdbd82a4f471f9fb80cb1af1c6da5_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_4fb44179207f4e5ab7295de38ae567bb_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_5d8c9ae21fd74b1c89cd806e5df0678f_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_2d1d429026c3454db3d4b7e9cbeee304_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_344095892f564423a53913eb79a3cb07_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_a7384877adc74bf6b4b8114996d0267f_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_964737e6548841f3a10c9dfdf78a4e37_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_17c9dccdff4b4112b529d222c5ea6070_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_2c284550c1734b81a317ea5e291eebd2_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_839622eb939b433c837e89b2f23f2889_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_6f9f0dfa401e497ea064f4ba338eaac1_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_82c391fedefa45a1b2982e31170db452_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_4935c9bd938746f5b8b7c55e06ae354a_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_55a0f531987d47b8ad58fd79d9367d95_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_f231df75898d40279e9d79ba1b89faff_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rolesanywhere.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_a9ef7230ce33447ebd1156d2af2591a3_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_3a00b163fa7845a3a848b37f71b1094b_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IAMRolesAnywhere")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_4a3b952ae3654daf80bb9a465dfd1fe5_Test()
        {
            var parameters = new IAMRolesAnywhereEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonIAMRolesAnywhereEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}