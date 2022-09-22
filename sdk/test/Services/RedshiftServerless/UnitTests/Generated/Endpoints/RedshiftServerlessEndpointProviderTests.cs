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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.RedshiftServerless.Endpoints;
using Amazon.RedshiftServerless.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class RedshiftServerlessEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_dc3a8dcd5c6c4b1f932d60936303613a_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_bccecf32cbd546428bf1e4ed8ab692fe_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_d8888686ed4646bbb7c8cd953ce47370_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_7a585479b4454a61be325daa4211d391_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_ab3f5982290e484680e40bda9037a666_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_7aa8cfe255994b579a0e84a78e9067f9_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_c2ee8dcf2b52481d8a569a13b0e36a73_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_55b57dbcaca54156b19f799f0af5b422_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_021626a7f98947a79d22a4e54aff563e_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_f069554da50c40f4b386e51d07e24919_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_e46355fe9e504c949e23a652695c2920_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_f1accf55c93c44ab93316bede08ee8a0_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_2c2e39af44994f72bfcbfee55c372c36_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_a5946a8edd7c48ca90dfedc2ba1acb4e_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_998691c7a3ac4485ace6fd7c7444daee_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_0204c10cc41b45a68ab85fc02f00cc2c_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_d862ca4b0b024107afb9bd5f98904158_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_7f3f17fa552a40d89a6e49d75f826c90_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_8b6fcf30579c49b281086dd111c88dd6_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_3ba2274f707e455da569bd7bb969240c_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_771cc7c21cbf46d387f23929e2609199_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_e1797402c8c04ab0ab4cc994fd6a4028_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_10d09d308e474e7ebc3896d832e9d3b6_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_170602cc7a244612bd47d0dea9c6a6cd_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_efca4e8b94cf41adaa7c63082014201b_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_5a428a1f60934137b54adaa2de390bcf_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_1fc4cca49954411396b382debbfb272c_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_fe7734de61564e7485a4dfc29b3704f4_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_395a0856dfd74aa6afdddc0d915451a3_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_4430f8dfb2df4d7cafd374cf6a35b2a4_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_8782e567feae4cf98adb4a2771c3b369_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_8239ab3a363d401ab72a90b763191f6e_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_952c535dcd3845b69ade3f34d1a41a39_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_8111abdf3a194e8999d0f005209fbb0c_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_70eb2be7e73e4f8a8b95b250dbb583ba_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_e11852d6175943959fe69383ff20ed72_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_01502b79be3e40c1b78c37ee705bc1f2_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_7da71b4619d84ca993496e83b8b16dec_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_785ca506e0414a58a8e9a5b216c77265_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_55c1795d3878438f873381d4767161c4_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_2699456b74fc40e0be04be4777f78e20_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_3deb381e8c474cd780ef84ca69761c85_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_376ccea3da0a498f98ac87b20ca6c7d6_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_3f7e92dd07ad4e748d32718a9b3f3f51_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://redshift-serverless.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_6842b7932d5147b28232f0d6350e21da_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_d7b3268e20f041bf955cb20cb802544f_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RedshiftServerless")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_f8aab571086341acb59a2e6c23f7628e_Test()
        {
            var parameters = new RedshiftServerlessEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonRedshiftServerlessEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}