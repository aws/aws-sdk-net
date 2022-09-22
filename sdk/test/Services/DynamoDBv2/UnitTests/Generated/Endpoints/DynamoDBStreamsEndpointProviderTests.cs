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
 * Do not modify this file. This file is generated from the dynamodbstreams-2012-08-10.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.DynamoDBv2.Endpoints;
using Amazon.DynamoDBv2.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class DynamoDBStreamsEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_b82b00d8603c4aaca63bb971ecd33939_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_960588cf2b96463b8a440cb153264e41_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_00af385849ce46418107bce0df06e88f_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_07275d0c673f4b3999fddaef64bf8e36_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_ebf9c34312964a05959d036f0e8e3f3c_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_97dc4c20340a48deb6d9352a43ae789f_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_4c7e0f6bd4c44206a687aee2e8cc48c9_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_412153a9dbf24107b8ebefed950443a7_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_7a014c41f6004725b7528b298f19c47f_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_29ad89631a7b4d1d9746eb2da81bd795_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_459aa884c8ff4c38baea1730b12b6c8e_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_3fb85c0408b541fd96c06d3c1b5f4d14_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_168a60861b3c481897311ef361634905_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_b09da66010894de7b00eed964f3561e9_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_971eaa3a39b54f56b98a7abaefc90cad_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_ea354b33d0cb4c959479fac8333f73d4_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_07313708e987453290419a9fd225d6dc_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_ff66544c845949c1a60ca4314d4fcc9a_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_751aa214c86644ba946f2cd996094fa3_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_91a3198a865443d9b6989cfe0487c6fc_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_263db3cbd6eb421fb9e3bb98b8b60004_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_d0b0413075934d75b9c0142be25ea471_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_d4d1babd7c9a4136b63c9fb230961467_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_eb766f6001c342f1a77f0d01ddbd2273_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_384156e8ab834d5ab2fa2112d2788323_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_9baf8356a72542e9933f8a4dde8e97c3_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_f208ef7b5a214ee1aacc00cd20ab72b0_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_6809a73c9e64407b84405ba5b361b93c_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_c54d88c552904838aabded684695dfe4_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_f2225db8425f4ae38f82819f72040faa_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_a114ec443fcb468691672e92f2815a51_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_83c12721083f4afd96980e8f38449d7d_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_dd2c8dd970af4541801bf50cd278713f_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_cd6e7ca1e8114e95852d6441fd8137ae_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_ac51e218c3af4c4691de5ad462109c67_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_665b683b8d9a4ed598b2215a1d94c063_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_dc60f164f124458697d1c3ed60a2ccb5_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_7c9af7f3d8844ab59d1ee5629fe7e9dc_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_39075615583d455e898c907c5e8aa155_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_8a08b2d7dd754e64b2bead94d80768dc_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_62771ed34ec84ca69b80d44b290d169a_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_94011e47e2d941d990eb099826ce7fa9_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_d53d5b48c3da4bda97960d19da2ecb4e_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_f7a25f83b96042909d38f38617478a33_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_66ecce5dc2e54693aef62195aaaed44a_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_535c49849973407d98142d35b2a0c20b_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_e6947cc5aa334225b146fc1952a60e7a_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_3abdd9d8583643fe93359fd114a1b248_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_aab49edd66b346388f40a6ea750bc2af_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_e96bbd6cb8db46bc86925eee51d93dc9_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_f82954bca015489dbc5cbb14ae5a9671_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_0521f4b9730a4f2580d3df226724fd90_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_287acebba47049349724b6694a69d837_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_24124f5d443d42149aedd9f4e54f2194_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_0727933435974accaedfaabe14895574_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_40a18a8c33d346f3abc0840b0795cc04_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_78319c93e4f6454e81ba73e71a971713_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_e081494241d9458e9bdc20aa73d23ad4_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_0d1729a832cf48a28ed83ddd63b77a81_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_79ae7a9c3f7c411a827c97e3991dbb3e_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_6d7b609c03c54c24aa806dd646609bbb_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_bdf71d5dded6470c9c83f387f2b1836b_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_b7fed5b07fbe4d9b8f802c52bc1fcdcc_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_e9bd24579ef44be5920efb550c69670d_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_8590c2b990dd4d58ac0d8fdd9a5f9d63_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_0ef8ac2e19a34eacbf8b564e0b14a1f6_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_92d209a5bdcf40e49d969a65d71f9e51_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_f326323cb72e4432ab12fafb8d2904fa_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_8bf95ba510f8451ea7a0048235be5024_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_a6d7120e0cb94a78a434193e1072824e_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_8c12ad5ba6644cc8913bbf42e3df659b_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_11eab0528b834ff1a4ae4b1f840e4248_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_dfe54e400a3046049b00d7ee44baed79_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_472e260a50fc4cc58439c28eb2875283_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_ed91e7691bbc470ead85f3fe9125f353_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_baffc3525f2742e0a6109442a81c5c8f_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_1c9288039c4e48168620315538867610_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_43f83916c99e43118dfb6a45b558963b_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_88452ca8e681433d8d177ab71261ff61_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_4820415f0dd546e284b2270105ffe1a5_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_a70604a99d374971a34524bbf81c344c_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_a19b63e032fa4ad6a4d4fef9a4bc87d3_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_b679eaad91fb49438e2dc1e794542a90_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_0136665b95b34d86aaa50d76690dfb5c_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_17afe77761d645edae5cfa171c74c3c9_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_120b96246371487aa2a6e1bea80cc632_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_6a8e2697759e4640ba0b43ef0585bac5_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_c62af0186c014135898652b604b74d2f_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_b52ec7e48efd4ea6acc7195272c90a98_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_8f71db831c684d19b6cff0dd5cd78373_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_d315b2cdf36646ada9d9c7edaba5af93_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_0d1ffe5fd01c45f497e35fa8e3c37abc_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_d5ce8f2c9c274ad1afa9ba3c2466be94_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_b284b63f696849fca6ca61ad08e96bf2_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_fab3345dd556425fb872242418a2db59_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_b9b8218344bf4787bbdec6cb10a49c78_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_c084fc98e3da443ba49d8e8ca6f2cdd7_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_2d7a343f90a94f66880091bfbf99b4dc_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_4615f8eddaaf48fbbb72b067154c2d87_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_716d2261854d483cb9df817c7ddb105a_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_dce3eb2fe0194229b5ec192e6f7c167d_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_cdd5ddae2e4f4ff2bf14daad55cf7ba3_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_c6831f90bd724407b55d993552f490c0_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_6f95014f9ae0436a8461621d1fd9b159_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_058aec7f921740f5b2c7e514f62f7999_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_7acaeade731f4f2aaaf643f2662e2892_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_e17a7d5fc227471983a9318081533bbe_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_a3225c6cda8544fb8650c079d6bc24f0_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_4f3757a5ecc24bd19c338e13391e9f28_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_4319c4a262aa4a4e9e229da426e67607_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_2365cbe00a6e4701a3dc299728fc4271_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_2284de2b803b473f90112c48ecab41bb_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_77021072271a4ebf93861b0d5dfdce46_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_18b2233b047447d5a5a76465f896df19_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_df79a50396984ea88b0026615d94a2d7_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_f19cd6ad55494e49abf318d7aeb29a15_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_enabled_008a773d649245afbfd767bea1bb7887_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_disabled_4f18f87b5ae94fdfa55dcb26a9b4ea92_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_enabled_e907849acf2749a48bb708c0526b42cc_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_disabled_016f0efc2b7f4f61954a3ce2b5bbb8b3_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_7c279490ec0f422c947f5adbfa97fe9a_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_b03639e9ad724d1d83ae5c99189a6998_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_290703b7794542de9f2e1517625b9166_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_a60ea16d4dad44ad8bef090e80454fe1_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_7cb927ca70294f4b9a15f53790f36ab9_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_5f69ddcec5d743e7b2026cd8c0089aba_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_31f5cbcc616c4455b5f4d99c6a181716_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_9295b7a62b6f425491147cd9703f9056_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_f9bf467d862e4a8ea51aff928c0ef243_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_c0a3995574a44497a047a4dd3f242376_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_789dacb7644c43518a014b1ce25ec6c9_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_96b98708778b43ba9d2d81b2bef64851_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_965dde9912884d77b3dce94c3ff34333_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_5795db562fde4c8dacbcf8a9beded18d_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_429b77c4f21041ad832db2f7aef21008_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_909bd3c4fbaa4048bf3d7a43cea224ea_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_13ee88093bee46ac8462e633242376c9_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_b88a9779c1984fcda0b2d3cc956e654b_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_1d8d368d27a44ecaa89e202a55754641_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}