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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.DynamoDBv2.Endpoints;
using Amazon.DynamoDBv2.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    public partial class DynamoDBEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region local with FIPS disabled and DualStack disabled")]
        public void For_region_local_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "local";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For custom endpoint with region set and fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_region_set_and_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For custom endpoint with region not set and fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_region_not_set_and_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("Missing region")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Missing Region")]
        public void Missing_region_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void UseFIPStrue_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void UseFIPStrue_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-west-2:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuswest2333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-west-2:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=, AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawss3uswest2222222222222streamtestStream_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=, AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArn_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountIdEndpointMode=preferred, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountIdEndpointModepreferred_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void UseFIPStrue_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void UseFIPStrue_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-west-2:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuswest2333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-west-2:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=, AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawss3uswest2222222222222streamtestStream_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=, AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArn_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountIdEndpointMode=disabled, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountIdEndpointModedisabled_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void UseFIPStrue_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void UseFIPStrue_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-west-2:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuswest2333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-west-2:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=, AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawss3uswest2222222222222streamtestStream_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=, AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArn_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountIdEndpointMode=required, Region=us-east-1, Endpoint=https://example.com}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountIdEndpointModerequired_Regionuseast1_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and local endpoint are not supported")]
        public void UseFIPStrue_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and local endpoint are not supported")]
        public void UseFIPStrue_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and local endpoint are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-west-2:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuswest2333333333333tabletable_name_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-west-2:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], AccountIdEndpointMode=preferred, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=, AccountIdEndpointMode=preferred, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and local endpoint are not supported")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and local endpoint are not supported")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and local endpoint are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, AccountIdEndpointMode=preferred, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawss3uswest2222222222222streamtestStream_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=, AccountIdEndpointMode=preferred, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArn_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and local endpoint are not supported")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and local endpoint are not supported")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and local endpoint are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountIdEndpointMode=preferred, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountIdEndpointModepreferred_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=disabled, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and local endpoint are not supported")]
        public void UseFIPStrue_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=disabled, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and local endpoint are not supported")]
        public void UseFIPStrue_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=disabled, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and local endpoint are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=disabled, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-west-2:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuswest2333333333333tabletable_name_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-west-2:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], AccountIdEndpointMode=disabled, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=, AccountIdEndpointMode=disabled, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=disabled, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and local endpoint are not supported")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=disabled, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and local endpoint are not supported")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=disabled, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and local endpoint are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=disabled, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, AccountIdEndpointMode=disabled, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, AccountIdEndpointMode=disabled, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawss3uswest2222222222222streamtestStream_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=, AccountIdEndpointMode=disabled, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArn_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and local endpoint are not supported")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and local endpoint are not supported")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and local endpoint are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountIdEndpointMode=disabled, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountIdEndpointModedisabled_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=required, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and local endpoint are not supported")]
        public void UseFIPStrue_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=required, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and local endpoint are not supported")]
        public void UseFIPStrue_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=required, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and local endpoint are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=required, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-west-2:333333333333:table/table_name], AccountIdEndpointMode=required, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuswest2333333333333tabletable_name_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-west-2:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], AccountIdEndpointMode=required, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=, AccountIdEndpointMode=required, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=required, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and local endpoint are not supported")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=required, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and local endpoint are not supported")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=required, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and local endpoint are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=required, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, AccountIdEndpointMode=required, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, AccountIdEndpointMode=required, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawss3uswest2222222222222streamtestStream_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=, AccountIdEndpointMode=required, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArn_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and local endpoint are not supported")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and local endpoint are not supported")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=local}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and local endpoint are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountIdEndpointMode=required, Region=local}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountIdEndpointModerequired_Regionlocal_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "local";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPStrue_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPStrue_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-west-2:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuswest2333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-west-2:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=, AccountIdEndpointMode=preferred, Region=us-east-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Credentials-sourced account ID parameter is invalid")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawss3uswest2222222222222streamtestStream_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=, AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArn_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountIdEndpointMode=preferred, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountIdEndpointModepreferred_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=required, Region=us-east-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported")]
        public void UseFIPStrue_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=required, Region=us-east-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported")]
        public void UseFIPStrue_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=required, Region=us-east-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required and DualStack is enabled, but DualStack account endpoints are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=required, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-west-2:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuswest2333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-west-2:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], AccountIdEndpointMode=required, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=, AccountIdEndpointMode=required, Region=us-east-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Credentials-sourced account ID parameter is invalid")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=required, Region=us-east-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=required, Region=us-east-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=required, Region=us-east-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required and DualStack is enabled, but DualStack account endpoints are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=required, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, AccountIdEndpointMode=required, Region=us-east-1}")]
        [ExpectedException(typeof(AmazonClientException), @"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, AccountIdEndpointMode=required, Region=us-east-1}")]
        [ExpectedException(typeof(AmazonClientException), @"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawss3uswest2222222222222streamtestStream_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=, AccountIdEndpointMode=required, Region=us-east-1}")]
        [ExpectedException(typeof(AmazonClientException), @"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArn_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required and DualStack is enabled, but DualStack account endpoints are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountIdEndpointMode=required, Region=us-east-1}")]
        [ExpectedException(typeof(AmazonClientException), @"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded")]
        public void UseFIPSfalse_UseDualStackfalse_AccountIdEndpointModerequired_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported")]
        public void UseFIPStrue_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported")]
        public void UseFIPStrue_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required and DualStack is enabled, but DualStack account endpoints are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this partition")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this partition")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this partition")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this partition")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this partition")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-west-2:333333333333:table/table_name], AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this partition")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuswest2333333333333tabletable_name_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-west-2:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this partition")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=, AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this partition")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required and DualStack is enabled, but DualStack account endpoints are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this partition")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this partition")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this partition")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawss3uswest2222222222222streamtestStream_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=, AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this partition")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArn_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required and DualStack is enabled, but DualStack account endpoints are not supported")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this partition")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this partition")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountIdEndpointMode=required, Region=cn-north-1}")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this partition")]
        public void UseFIPSfalse_UseDualStackfalse_AccountIdEndpointModerequired_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountIdEndpointMode"] = "required";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPStrue_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPStrue_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-west-2:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuswest2333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-west-2:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=, AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawss3uswest2222222222222streamtestStream_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=, AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArn_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountIdEndpointMode=disabled, Region=us-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountIdEndpointModedisabled_Regionuseast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPStrue_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPStrue_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPSfalse_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-west-2:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuswest2333333333333tabletable_name_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-west-2:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=, AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawss3uswest2222222222222streamtestStream_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=, AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArn_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountIdEndpointMode=preferred, Region=cn-north-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountIdEndpointModepreferred_Regioncnnorth1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "cn-north-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=us-iso-east-1}")]
        public void UseFIPStrue_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModepreferred_Regionusisoeast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=us-iso-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModepreferred_Regionusisoeast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-iso-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionusisoeast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-iso-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionusisoeast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-iso-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionusisoeast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-iso-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionusisoeast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-west-2:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-iso-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuswest2333333333333tabletable_name_AccountIdEndpointModepreferred_Regionusisoeast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-west-2:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], AccountIdEndpointMode=preferred, Region=us-iso-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_AccountIdEndpointModepreferred_Regionusisoeast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=, AccountIdEndpointMode=preferred, Region=us-iso-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId_AccountIdEndpointModepreferred_Regionusisoeast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=us-iso-east-1}")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regionusisoeast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=us-iso-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regionusisoeast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=us-iso-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_AccountIdEndpointModepreferred_Regionusisoeast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, AccountIdEndpointMode=preferred, Region=us-iso-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawss3uswest2222222222222streamtestStream_AccountIdEndpointModepreferred_Regionusisoeast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=, AccountIdEndpointMode=preferred, Region=us-iso-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArn_AccountIdEndpointModepreferred_Regionusisoeast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-iso-east-1}")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionusisoeast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-iso-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionusisoeast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-iso-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionusisoeast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountIdEndpointMode=preferred, Region=us-iso-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountIdEndpointModepreferred_Regionusisoeast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-iso-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPStrue_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPStrue_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPSfalse_UseDualStacktrue_AccountId111111111111_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-west-2:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_ResourceArnListarnawsdynamodbuswest2333333333333tabletable_name_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-west-2:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=111111111111, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId111111111111_ResourceArnarnawss3uswest2222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountId=, AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountId_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountId"] = "";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-west-2:222222222222:table/table_name, AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuswest2222222222222tabletable_name_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-west-2:222222222222:table/table_name";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:s3:us-west-2:222222222222:stream/testStream, AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawss3uswest2222222222222streamtestStream_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:s3:us-west-2:222222222222:stream/testStream";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=, AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArn_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPStrue_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=true, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPStrue_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=true, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPSfalse_UseDualStacktrue_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, AccountIdEndpointMode=preferred, Region=us-gov-east-1}")]
        public void UseFIPSfalse_UseDualStackfalse_AccountIdEndpointModepreferred_Regionusgoveast1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

    }
}