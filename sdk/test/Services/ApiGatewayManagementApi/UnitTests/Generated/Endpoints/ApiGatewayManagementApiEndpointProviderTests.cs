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
 * Do not modify this file. This file is generated from the apigatewaymanagementapi-2018-11-29.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ApiGatewayManagementApi.Endpoints;
using Amazon.ApiGatewayManagementApi.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ApiGatewayManagementApiEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_bbea311c1acb48828faccbceae016380_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_367af371ec8241eeb557db97c723d907_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_92520155e08647ab926be339abeb4f23_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_78ff9831b5bd49e2b96c1c50da4fa2a1_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_6cae00c44ff2491e87f08721ae1dd956_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_e034d961a0204a63baf362093e71e0f5_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_d9b012dbb7e647b491e21e5519441ac2_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_22896ecac6a54fafbdba95d40b72f766_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_858cdd6d1cdb49f197d2b83b8d264fac_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_e1824903d7a34f9cb7d0735e350bca3e_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_86d4883a771c4a94acbb0c1b95dbc101_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_7f9f882767b34d6d8500dab872b2fc8b_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_205108b0a808452eb0afffb3fb280adb_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_6e5b8d2fa6b34c9184fe4420df7026ed_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_8a05823979f0496195c9c81900ab07e1_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_77197eac4c7d4bc886e85afa3238826b_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_07b17f1aa53c4b458ff51dcce1891037_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_348b20987d3e4286850a36bb75fb55b9_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_6c743d76063b47538d1e837167f4d49f_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_2e1c1de457324b209671d1da0058b86f_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_ce94ddb42d674444b4966192adb6347f_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_0faf12c0b0d34a10be78fcd254a82f87_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_8869f0c056934acf8a9db45be44aa207_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_9a53afcaadb045269e29f2e3b0a9ee7e_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_c6cf8033950740e491fe131221660e1e_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_dddbb6b0e6e141f59ea391541ff0f3f7_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_a73e02162e434ac583d51d072fa71b22_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_73ef8554fae449a595c7a5f8b0fd7276_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_d725a580561948fd83d669024cb8d951_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_d8dd7be288e44639b6d2a85f29d4fdc8_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_3e7137efd00249af9ec1dbbcb966a56b_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_5035dc12c32e44a8befa5d3a739285f4_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_33ad74a6cac540be9dca2a69b397a191_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_7793110c356d427788134fdf9997111e_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_c64fa97bd97b45c2b9a136ab43e762f2_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_433bd1a9b7de42c98070878b7fae9cc5_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_ca9475129bf94a22aa1e1100aca106fb_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_9f530b50f2d745aba75b9dc8d2d89f2b_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_bef16adfa6f34d8cb74e1c7f8366c989_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_0824730c9ab84786b070c0df13711dd5_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_d6cb1ccbda40411b80fd66acb4044d93_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_ae70e5f86af449888374b233d471d420_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_11af43280fc94879ae2ba9c8e206c572_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_64fd77a550244202ac9e63d74a37cd78_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_87b2c78efa5a483db114ac8b43fcfba9_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_23f6cb82460041e282d36da5e7f86696_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_b94a3451a7eb44bebf839921f6cb949a_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_5e2c896a74d945d59a3242ba9dc2d0f0_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_97f3737c07474bd49ac17d64c117b877_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_f0af1dab32ab4e2a9f31437cb89ba4ed_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_ad82b65e75da4b6abfd93c61014ce30d_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_c5f6a721321048cfabb0a920270a9572_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_6f16c18a65a84190bec026360a3544ee_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_dee8d824e87644dea5b020b423d04ed9_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_a7e55660be464a3199ae6f1b9a1fb236_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_d63a0b6de27d4820b40e5e3265d3a129_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_166e60e1aaac4b86be9b89e610d0f397_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_c34e8ee9763a4d90b16f77890e6c07ba_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_d77abd4e206f4a8789b520c21032d244_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_bd82a09e980047b98a345e76d1fcf6e1_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_fca490b3825b421f939d0812e7e5f062_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_2bb8536fd66c4083aa125255806d43b1_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_c1a4ead7d21149f4939dffe660d08fac_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_456e6350a26b4395a4d023189e42f1d3_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_db34d89679744a449e17c6ccea0c0ff6_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_5ae3bb24d65d44feba8b9d3ae1927b09_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_2b1342dc69b845f38486dd574ac5b4ef_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_3c2f3e0a304a471489388018ab1fb53a_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_b6b276d3be6e4bc5ad1701d3b929687a_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_4452cdfe7ed149a891b0301e0173fe14_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_46abb5f0be814255860988e92b7b5b84_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_1355d9e2b81b4f8280090843232f5ec1_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_3867ca19d33f485d9263f4c5531476bd_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_693385926e6849db887906c21ba87ebc_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_861956c5d46441338e0d3f3698fbcf7d_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_4b768fbafe4849328df048770ce9044c_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_f8eef44a423444d3a7f1d993ca9d76fc_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_06e334c08f3f4cb2b5ae5fa0ab8f884c_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_8dfb9cccede740e7a42101adab032e77_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_04ed0aa340f74e6893fa4a10156c8a6d_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_29fbec7ec4a745a3808bbfc23502c1ad_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_e996d1191e4f4613899e1f3b47f8381f_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_243976d8fa47440d9aee942d3da3730c_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_ee0677dbe87f44faa3591d9618b37344_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_06259e6984fc4488ad53e6ef44cfa968_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_cdbd81aaa44b4175a9856cb1f64a59ce_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_bc63ef27e1b247bfbe7252b2e80a8252_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_94924e3e0ef148e3bb8dc016ee258996_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_48256bc2f8d74eb98723c95bf1895a40_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_a953ec5cbc7b434d8bd18df8daa11afd_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_e3a9cccb17db461fba58ef16bba0b0c9_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_90596ac9e6ab463ea2dab909a4efcad1_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_ba52e6e4d6334046a0fc3d416d1091e9_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_921dbcc5af19401aa827241d732dd123_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_c0d706f1b6dd4435954d068f9054bbd9_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_057a8246babc4d4696a3eab8e41ff36f_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_50758637fa67467c818713d479c69c33_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_bd3bf68d777a459ebdb9bfb37b623adc_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_b9a71cd4979043688871b720125e37c2_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_62ad770d4b8144dea147e454667fa2a7_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_0cb23852b550405d8c23582739059638_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_abc52284c88c48d6904ac5b713c9e1a6_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_28b20b2936524f5987049dbd6e938597_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_18101083c0404841a616b12e5b3e66ed_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_f7aff13a84b14068819bc93fbccd2916_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_18c98973b5644b46bb90524a42a4f1f0_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_6f65d17fbb63440da806cd96dbf04946_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_a7ca1144428d4d8dafdd52b5c229c29d_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_1af9d0ff412544e48edf89477a2721f6_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_1424ada99d644a288e17b416fbc5123a_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_47ac760f703744c58c6beb0bd8986d32_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_31089766f1ce43ce9388a00c38d355a2_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_05e1590acb984f0481dad87e49a70afb_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_4749e1c65b3e40f69f71207c510a3f4c_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_2c3e2a591e8d43979d8c122f866215a2_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_e2098265b61d47778c767620f41d370a_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_0c012076ab034742a909387f52776b8d_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_7fc567a7bf3e4e06b8a27dd7c32bdee7_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_05e28b7956ae4435bc39a13e8084ba1d_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_8cdd5e7e905445f4ae5a0145d8ba9f6e_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://execute-api.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_86290c1a590b4ddc85ad6041e2fada38_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_13a25823db814e96b6d6489964b1b20a_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApiGatewayManagementApi")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_28a4abd959dd44f0a343f414a52d9feb_Test()
        {
            var parameters = new ApiGatewayManagementApiEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonApiGatewayManagementApiEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}