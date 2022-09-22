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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.SimpleSystemsManagement.Endpoints;
using Amazon.SimpleSystemsManagement.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class SimpleSystemsManagementEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_fd121604e2dc4d8fb2634be42e120ab9_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_f81ccb72efbf4c6caaccbae895ef7772_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_cb5afad441fd4c34818f7bb5be16d0db_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_e575b1953de24baebd69dd2dfadd8942_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_e5a84644cabc4948af1e46aeaea1bc1d_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_13c8637e886340089f041ce928aaa7b0_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_6ac5d8e09eb94c8dbb930a971b63d718_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_2a0e335eae284d8ca842d3dddfc734d5_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_186b1c8b66544a2a91c832d7f5ee89f7_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_f87e1f00afe74dae9aae3dc7a0d24db8_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_5b92adef42584c15b6a9d50cc940781c_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_121e66f6ca324ff281762646d3bb1fe7_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_43df7794ec2b40f390bd2d289fda3e48_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_1f0b4f76f81b46578ff12421418f21e5_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_bc672371bbd943acb5b25c0a92d8e026_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_ae18bf781190452aaa5f2157ea870d15_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_32bab3f7c1fe44678434d8fe98e4b9fb_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_69ae9e6099fd4eb68abc96a414078631_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_6c2a83201ee441518004ae1ce16230d5_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_8718d910c3054c438c98c119d04a7a68_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_5686e60d113941b183b722a0f35197ed_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_cca4ba7ed2c246ab8d926f42085125c6_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_287e83b6db72427b952920ccb3cf0e3e_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_12fbbe5dc08b434ab9a4653665e0f51c_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_b54cdfa613454d799ccd6135ba277afc_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_c605bfff851d496b98a522b0db21ff17_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_4d75787aebc0435b9b2bb0553a283d26_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_11f9cc135f9f4a51b83869d6893248ca_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_1d3cf83be91b4a9cbeb779c5fec87e3a_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_8161c290adf74e4d8ce5c6974198fa9a_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_47f4f99d8d064c2a91fee8c919bc0a72_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_e4d1e769dba6463595618822f7769615_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_69bc02db76d7445d959434d8fa0e119e_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_6fb4e2dab8b44c549d3f4e1d95ecd48e_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_f28ef8b8527d44b38cd2e5c52a098866_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_62875630a0fe498eab0145c4c9a24858_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_ad5402a824c04c2d8f872b16e1437800_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_b893cde0756b475dbaf5e2a640369a01_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_d2df35ba00174027973bc724a26e0b66_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_555c63df830c4aeeaa8d555b1023b21a_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_90a1498d9807455e8c040ca8a7fe68ee_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_b581ee92557f46ecba45552c85fc9ffa_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_c0a306c9b1c34393aede9e62665cc204_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_082c2dfdfd4a4866a13ea75a07875581_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_9658f458688c4b029389542e637ff88a_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_a5d336ab2531420eb6f15e892a2ae8fe_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_92060e9603164eb1a84fb1fe7235f050_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_32e3baf91a994f62820bbedd28a8e900_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_1aafe5013b8c497f893e851e7595a399_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_5278676d14544c40a0b799704673744e_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_8a51dcb4cf8e4a1b80ea97d27c993643_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_814547ab0e9942a386fdf1212cec79c8_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_75d66712fbf14c04af53efef6b38f0fb_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_7adab511341640e8becbf235758f879b_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_44349c44b48745dc96d57b3dce592e41_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_9338e921017748b59fd86d1d584f4539_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_8c5489505949403f951f9d27382e1fb8_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_8f02ded772fd4012a00ba443f38af9f4_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_065ec7b119044e1dbd2964efcf989a53_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_f08f1ef672c9491a8cd9186c7ecf661c_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_f74a20c580254cc5a121cc90a406220d_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_12c39d64921f4ebaa16959772cedf313_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_24e6a99139514102841497e70c0b7479_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_176ad9826c30492996166f4603b7e828_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_36709511d0cf4b6f94753b2c9f2d6fed_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_45cdcb5e342f4e9bab7e8e49891aa589_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_fcd8eb90ab494e7d888063489be28c86_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_124f6f4e02994e338d48eb5d2d99a7de_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_613b497d65f341a8ac8306924668c915_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_8ca4eeb114b34074a95060c01e95f499_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_e9e4620e543c4b18a83aae15c61219f5_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_848d4b28fcd542689cccfc6f392fd849_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_b061badb95ee48be8f82c7481e2994a6_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_a29cc7668f8445c6b862299113bedcf1_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_aaea99e8de3c4fef89ce906599cbe1b8_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_3411aebb093b43d9957c11b5b034fb69_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_cada34db6508425db5b78d64ed5e9697_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_4de41bd2eb17410e945177d589bb1861_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_74018e09359d422f8ba206250969e7ca_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_cb46ec761ec447ad929d709ea01a11d6_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_b65e01ef88ce4a6f8db45ae89e4c731a_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_3ba36694b33744a3b767deb6439ee9af_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_d56f6af7948a4ecab2324bf0396f673d_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_3fb09aeaae5648a591e92d19bccbf6f3_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_c66cf229a25d41f898e73aea8e6251c9_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_ba1040eda3d740af9f9f45a70960c10f_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_f8cb24f3bace4cf095c0772ca0b83380_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_156bd90b27f14719aa9384854084fb0e_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_d9f47723404a4fcba2ef09586051b986_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_9874daa138df4304813cfcac6c4e015d_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_ff4376be11ae4981bc1dba249bf5cb27_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_28a90449a1f74dde8d7ee923db5026b8_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_159d98af7a854e4dbf5fbd89d66539e2_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_069500a67d58471994f0a95c23182cc3_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_1d58399dc2364f6ebaf2ac21f460d7a5_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_936ff6a25bd44275bb7e117cf0fee82b_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_cbac01ef10e64b73b022212aed4c9642_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_e27b242bd0d844b797feab82fb0a3f0e_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_f06d389bd200450bbd93fdc89e98f965_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_23c5a33c220a4549a6dd603d52ac7de2_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_6d9473c4f7714b0db422cfbfffa370a5_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_79b1e4053fce48efbe32a407b41c922f_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_8a1554d204f14c3691064430fa485927_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_c4856755208e4b8bb64e849996217326_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_bf9355759cf04bb28aa811169d93ff00_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_c3dc492d10a644c8ae6f689ee024c118_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_679dca331dee48d3b9b57b052d47d171_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_19325c4a071c45e3ae159a7e9ec52e3d_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_4259e86a2f4c474bb9dccc3804593262_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_0061cc9c91ef468ca3e6ae50daabee06_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_46ad64de5fce410695f0384e2ba06d24_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_d5114c9a63e641679f8b416813d45990_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_b864784493774adfbc120fbd92c4f18c_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_1713e10edbfa4ccabe680004750d1c59_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_93ff2bc1d39c4942a66052be1e280482_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_459f1d64d36d4a51aa8adc7e895ce0c5_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_enabled_d5b14b27eb3940ebac2abd8a66bacec8_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_disabled_a942dd7d31e54116b6645b0524d6d2b9_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_enabled_30d83d1cc0ef4cefa21b239a8600bb0d_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_disabled_e75294b0278d4fde95e4bfd7ea72ffc4_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_55d3d9595b644962ade8e525b588f6c4_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_36af98dd7d144af2ab78c9fa0cd9ecfb_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_05df58b555864091a700a272b1c748af_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_699677a86b684fa4bd0f21d5f9d11116_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_202c9592077d49288425c8307346a128_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_ee0485a34c5b43c4b754be2fdb7890de_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_24b319868adc4453b1fc03042e84f9c8_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_61ddea7a8c7f4cf2a414ae25ab5520f1_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_8232d0ba69aa4775a89ee26dc2d552aa_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_9df2b5544749476bb1756fc9318075a6_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_49d375c92d8a47ca97640698d23b33a4_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_af725fc038284795a43ac6919a7531f5_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_9c4b5c45526341eab1a03e2dd84181f6_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_21df118131fc497c80166be968e97b1b_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_a902797125e94406ac159d9d1208bd2e_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_4b8b13b2e76d43c0b79f6a99bb885190_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_d6b2685477f64623a366f0cf8dfc3f8f_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_8cb76c308c384f4c8087e43e7031291d_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleSystemsManagement")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_2585331047c24b2ba538fbe65d18f299_Test()
        {
            var parameters = new SimpleSystemsManagementEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSimpleSystemsManagementEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}