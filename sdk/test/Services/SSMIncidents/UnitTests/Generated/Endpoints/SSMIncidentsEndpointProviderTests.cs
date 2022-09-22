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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.SSMIncidents.Endpoints;
using Amazon.SSMIncidents.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class SSMIncidentsEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_d0da4330042a43e0a4426735e426d10e_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_0f33732bf9604d8ea99fe4d6dc40bf18_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_9bd0418d53424d77bd3bb2753bb51176_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_94479661ea67414283cfa694c69c4564_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_ae41196bb86c4e0aad541adfec7a900a_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_1a63a2012f8c426fbc3ce64ec7536af1_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_0e46dce1103d4c529d238765337687bb_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_1bd238cb50fd4df187cde6339bbbcd00_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_6df04d41569b4ca7a41cfdea97043e06_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_0600419a4a0e4ea5870d4a7e86fe55d6_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_c941c5fd35fd494aa4c679965e78639f_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_c84dcd6d5f3040afa229853a7ae11f3c_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_5ecd59ab79bb4fe49909ddc01dea01dc_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_339b36eaedb34d8bb00f1af4ad1b3e00_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_fdec0cd14f6e4e40b4233d99e89ace38_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_8d3a3581a9d0475d832e46c23edb01b0_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_201f2d8913654d1f8fe3cad110ba097d_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_db1a3296577c4595ad7c7298eacff06d_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_dbbd913e09864d4f95f4f651b2b44818_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_b1b14a6e890641cfb91ff86d3f78d3a9_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_e3fde6b6f8344c9ea6d07434d770eaf8_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_46a86b5c7a3c465e890bc099b3e836e0_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_c0b8a9db6c5b4e2bbcdd9193cfb7502b_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_abadb40572c04706bddc7f494e9161c6_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_5faabede91a64aceb12b50f960cc7681_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_4d377d301b41456f8abcf7ca7b6f9275_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_8d68699355f240398f3fb5933a403fe6_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_fa00d622deff481784e55935ede57a20_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_dcb3e1a01a7541bc8672a8208f8dbc5a_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_6c4f5bcf5ac44b14bacb351d89c64af8_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_20fcf9306f4c4534962098d3b22f91c8_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_0e3bdc414c3f4821acc349811256ded9_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_afb31af0a4b441beb2d3cac9b3f5a050_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_b934a926da7f4243b11b65b1ed604dd0_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_3f6308e7f6464b1899e8734ee6d5bc8a_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_26bc0fe65d084ad5bf5a93f2136b13f6_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_f9b98edaf9f34948bb7243ee5b35c26e_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_2971fdea28a94144a808aa627ecc4782_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_9f2988acbb8c44e1a93cf05861a86b2f_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_790df95a4d88490189b0bc0aac93d45f_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_2674b81933cf4299bb4b611d815473bf_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_4114cfd73ad8490c9b289e220c0f90d0_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_b073b443b78e4bad859e73e0cafc92ee_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_f52f089932544fe8a515556018c1e009_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_d809e484b250481a9011c0f397f6fe22_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_e906a87ae6494f73b411cb5270ea5c2a_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_5f52e7f590424b13bbdf4204a26c864a_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_2b83073a132b40f8b0d101666107593a_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_55e6b7193fe84d47819896edea83e953_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_02b86e8b0cc14cf68c515ec5b0cdde18_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_59503a6eb98d49a2a1c35f48cbc5b298_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_5934605d55cc43dca0b9fd2def2bfc4a_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_f2dcb4310b3f454f9a46815875efc185_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_5d703f2cba1849739e2a088f2fe21804_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_7b34a694fffe46a293f6b8658a9fa14a_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_b435b4f6827643e5966a8894232f5c97_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_c91b509cee17492dbe8dc9efbdd6dbde_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_3f5ad249d6154a199021b663113a51c2_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_c90b4964264b4588a3acf5308303c679_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_bf913fce26ba47779d9c5c54f2984336_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_09597b5a362147529a3cdf953448b283_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_df2da948cdda4ba89bda0c7b9e3c19b9_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_f13767fe65b643a692397cb1844c50f4_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_b288a7f169bb4d05a2e0f3b0305ee873_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ssm-incidents.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_daef298d53cf4d1c92ebe8edd665ac25_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_212e52fe82b24915b1a1056050881441_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SSMIncidents")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_efa24661349c4696b6a904557d937570_Test()
        {
            var parameters = new SSMIncidentsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSSMIncidentsEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}