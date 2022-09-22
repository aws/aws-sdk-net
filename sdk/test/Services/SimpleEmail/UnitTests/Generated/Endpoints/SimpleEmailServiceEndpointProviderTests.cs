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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.SimpleEmail.Endpoints;
using Amazon.SimpleEmail.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class SimpleEmailServiceEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_050deadccd1d4c76809b3a2e609a9e9d_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_fa5d9120bc8d404f9507f0688309965d_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_0de29a947e974d608893d05e1c8b7b35_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_4d0dd7d3417f42fcaac875fe8d301ea7_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_e565a039323f4303bf436053870579c0_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_f7254812b4cf4a68a98878d5e0812137_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_73998efa475742e5a55ed602ea9af00a_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_d7fc9047c4974411ac21e46a9e26c8ba_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_6830c1f2090841de8afde1b95714489f_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_31b4622422ea4f3b8dc83b1658dbf2f4_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_63aed19b02ff48d59bae9230404a069c_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_62737819cee343b486a6ad4867065926_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_acbb953a09a046af8b974d277348dd72_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_460823785e0d4f5dac74a26595616f20_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_2b1f93e933d14778888e29b1ef27a523_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_90fc371960b949a4a4b1509602196c52_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_eef429031e424e55933321a721b3eecd_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_21e78161f90c4ac383b8ce60367a2692_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_eee81b52449441c89b3eec6044e170d5_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_561e10fdb09c49ff8ca73303d4cdbadf_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_637f088df6bc4123979309c0a150b8db_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_7a91e38caa084206b0d2570a02b27935_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_7da98049a446433fa6e4898a2ec4e656_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_19c8c56def3d4c2ea9c3f20fc64549a1_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_28f4a25c69cd4a1e91d1c7e29321627f_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_17946ae8f204458f9f273569289cfb1d_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_9724df317f9a4cb28aa56ce73cc28205_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_644fb56c81344a418970766eb2af6744_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_dd4e4418a3484ef7a4a8c26018b73955_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_ff44295761614b86aa8670e4c9a95b2f_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_35698121cbea4ae6bb89edf1e0e0e88d_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_ea21372b2ae9417a8d3ccf341e91d4df_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_2b9efc4dd1bd4f9e963a3f791229df10_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_4b8228be623449c580a425466d91d86e_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_c99a8c3202f34d7fa7f42fc34dbdab84_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_59d36ae6eae74222ace751720b6e07f3_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_a48d538ad45445f2928b4d8d6da0fc94_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_7fecd1667f644138ab42f6b0c9aa5f11_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_09bb2cae6ecd450a8c7412b2d813a64d_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_e2b729e98b034add85cd570505561b01_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_ac136d0eed1b495baad36cf9396ff2dd_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_2c25214dabc24dd5949b1e5d76cf1daf_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_b1385610e81e49afa6e52471b7065d27_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_78d465b6e84f462abe3ba9f030b85999_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_e96d41ca63a947bfa511200169bf790f_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_bef920f269b343fea9459c7d53bdf4b4_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_16351a4766934092a5057682e7ff2a38_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_c808d3b539d94bfb98b1bf4d9bafa175_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_8a8dc98694ce445589469cf132cf6a84_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_01c0df6c323842579d2c2c762e77407a_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_6d37c59a997e47748c73c9d0e78eec47_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_48496b66aa4a4ad4a59b695d2aa4c384_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_1e86a4621f964e70beaaa855f75dce31_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_df9ebf713ccd4c9ba923cd40102609c5_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_9973ecdedc2e4613a200458a5bab2ea7_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_a4cb1b9720dc421dac982d6afdddcf41_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_fd6c12aadcea47529e7d65d0d44ddceb_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_4bc2c633636443f0a06beecf11208e52_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_84655afe3f564372a411ebcfe1e89bfa_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_a643c16454a44fd2859048207ab768f5_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_52501c7216f14a36bd692a1fa70b08fb_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_d15c0b75c2bc4d2d9eb7fbac73abad93_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_571bbc0997be4ea39a33c5c8c94b0cea_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_ea771f45661b4463a4a08375f4c24c4c_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_dcc9e39e620a491ca724dfe383cfaeff_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_e9e94625f11347ef8e096fe6663d1771_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_e00f189d557f4fbea35077f2a16a1fb8_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_a971672a6ed0405a92cc2abf1d65f678_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_1e95f4b997474915b8db1197cff856b5_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_35a898e64322493082f448619dd4e4c5_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_229f2b0e51c542558fa491d877f90e2b_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_dbd76214c35748eaad8188ec25a1c430_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_85cd34831be84d6a83f840d180be0844_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_85337d29515a496eb8b3484387c63b0a_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_302f5f7a958e484e9f9b164c970c982a_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_dcb13a29bf98451ca3e7bc7ea5bab13e_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_4a8645ffccb24e4cb4595e075fd58e4f_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_856ec84b684242f899f9eeddb12250d7_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_cbdecc626e574e8badef05fc555e9e10_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_15285811b2fd447e9904772ccf5a1a62_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_3677c6a210ad4d75a47cb8a447e7cbdf_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_c6a9fe05e65345619fcd8071894f8432_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_2af54b6e201d414f9fc6bbc19eca66df_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_41b427a3c59a4dd3b7beb13ad31713fa_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_37cea755b79b438aa629e84f8ba4b9af_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_0f917590ff744f33aaefd057b474311b_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_b74b338e83fe49a49cc67d5b689b6e72_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_143f0f9fdbdc4312a037aa14e13dbd95_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_eff2900b0a7f4c948ede3f8e2d88f393_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_84855f2b51db47b2a7c1a161bbccc714_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_0a1f01d4e6db45cbaabf3aefaa113d39_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_562e3c48625a4359bb8570c3db63b60c_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_82db5b7513aa442aba4e43a4f5ffda6b_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_df7e7b009fbb4e53abe3bd6611cb875e_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmail")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_8de5b517ddf6420586e7647f2a429bdb_Test()
        {
            var parameters = new SimpleEmailServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSimpleEmailServiceEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}