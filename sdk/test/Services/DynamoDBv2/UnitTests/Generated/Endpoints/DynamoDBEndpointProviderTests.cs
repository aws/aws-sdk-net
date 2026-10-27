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
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("Missing region")]
        public void Missing_region_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Missing Region", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
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
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
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
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
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
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Endpoint=https://dynamodb.cn-north-1.api.amazonwebservices.com.cn, Region=cn-north-1, AccountIdEndpointMode=preferred}")]
        public void Endpointhttpsdynamodbcnnorth1apiamazonwebservicescomcn_Regioncnnorth1_AccountIdEndpointModepreferred_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Endpoint"] = "https://dynamodb.cn-north-1.api.amazonwebservices.com.cn";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Endpoint override is not supported for dual-stack endpoints. Please enable dual-stack functionality by enabling the configuration. For more details, see: https://docs.aws.amazon.com/sdkref/latest/guide/feature-endpoints.html", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Endpoint=https://dynamodb.us-gov-east-1.api.aws, Region=us-gov-east-1, AccountIdEndpointMode=preferred}")]
        public void Endpointhttpsdynamodbusgoveast1apiaws_Regionusgoveast1_AccountIdEndpointModepreferred_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Endpoint"] = "https://dynamodb.us-gov-east-1.api.aws";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Endpoint override is not supported for dual-stack endpoints. Please enable dual-stack functionality by enabling the configuration. For more details, see: https://docs.aws.amazon.com/sdkref/latest/guide/feature-endpoints.html", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Endpoint=https://dynamodb.us-east-1.api.aws, Region=us-east-1, AccountIdEndpointMode=preferred}")]
        public void Endpointhttpsdynamodbuseast1apiaws_Regionuseast1_AccountIdEndpointModepreferred_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Endpoint"] = "https://dynamodb.us-east-1.api.aws";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Endpoint override is not supported for dual-stack endpoints. Please enable dual-stack functionality by enabling the configuration. For more details, see: https://docs.aws.amazon.com/sdkref/latest/guide/feature-endpoints.html", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Endpoint=https://111111111111.ddb.us-east-1.api.aws, Region=us-east-1, AccountIdEndpointMode=preferred}")]
        public void Endpointhttps111111111111ddbuseast1apiaws_Regionuseast1_AccountIdEndpointModepreferred_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Endpoint"] = "https://111111111111.ddb.us-east-1.api.aws";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Endpoint=https://vpce-1a2b3c4d-5e6f.dynamodb.us-east-1.vpce.api.aws, Region=us-east-1, AccountIdEndpointMode=preferred}")]
        public void Endpointhttpsvpce1a2b3c4d5e6fdynamodbuseast1vpceapiaws_Regionuseast1_AccountIdEndpointModepreferred_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Endpoint"] = "https://vpce-1a2b3c4d-5e6f.dynamodb.us-east-1.vpce.api.aws";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://vpce-1a2b3c4d-5e6f.dynamodb.us-east-1.vpce.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Endpoint=https://dynamodb.eu-west-1.api.aws, Region=eu-west-1, AccountIdEndpointMode=preferred}")]
        public void Endpointhttpsdynamodbeuwest1apiaws_Regioneuwest1_AccountIdEndpointModepreferred_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Endpoint"] = "https://dynamodb.eu-west-1.api.aws";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Endpoint override is not supported for dual-stack endpoints. Please enable dual-stack functionality by enabling the configuration. For more details, see: https://docs.aws.amazon.com/sdkref/latest/guide/feature-endpoints.html", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Endpoint=https://dynamodb.us-west-2.api.aws, Region=us-west-2, AccountIdEndpointMode=preferred}")]
        public void Endpointhttpsdynamodbuswest2apiaws_Regionuswest2_AccountIdEndpointModepreferred_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Endpoint"] = "https://dynamodb.us-west-2.api.aws";
            parameters["Region"] = "us-west-2";
            parameters["AccountIdEndpointMode"] = "preferred";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Endpoint override is not supported for dual-stack endpoints. Please enable dual-stack functionality by enabling the configuration. For more details, see: https://docs.aws.amazon.com/sdkref/latest/guide/feature-endpoints.html", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Endpoint=https://dynamodb.us-east-1.api.aws/, Region=us-east-1, AccountIdEndpointMode=preferred}")]
        public void Endpointhttpsdynamodbuseast1apiaws_Regionuseast1_AccountIdEndpointModepreferred_1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Endpoint"] = "https://dynamodb.us-east-1.api.aws/";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Endpoint override is not supported for dual-stack endpoints. Please enable dual-stack functionality by enabling the configuration. For more details, see: https://docs.aws.amazon.com/sdkref/latest/guide/feature-endpoints.html", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and local endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and local endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and local endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and local endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and local endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and local endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and local endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and local endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and local endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false}")]
        public void UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Missing Region", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:not_an_account:table/table_name}")]
        public void Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1not_an_accounttabletable_name_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:not_an_account:table/table_name";
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Credentials-sourced account ID parameter is invalid", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArn_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[], Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnList_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> {};
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:af-south-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawsdynamodbafsouth1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:s3:us-east-1:222222222222:stream/testStream, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawss3useast1222222222222streamtestStream_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:s3:us-east-1:222222222222:stream/testStream";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:dynamodb:af-south-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawsdynamodbafsouth1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:s3:us-east-1:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawss3useast1222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-east-1:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:s3:af-south-1:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawss3afsouth1222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:af-south-1:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:s3:af-south-1:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawss3afsouth1222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:af-south-1:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:s3:af-south-1:222222222222:stream/testStream, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawss3afsouth1222222222222streamtestStream_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:s3:af-south-1:222222222222:stream/testStream";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:dynamodb:af-south-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:af-south-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawsdynamodbafsouth1222222222222tabletable_name_ResourceArnListarnawsdynamodbafsouth1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:af-south-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:s3:us-east-1:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawss3useast1222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-east-1:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArn_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[], Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnList_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> {};
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:af-south-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawsdynamodbafsouth1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:s3:us-east-1:222222222222:stream/testStream, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawss3useast1222222222222streamtestStream_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:s3:us-east-1:222222222222:stream/testStream";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:dynamodb:af-south-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawsdynamodbafsouth1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:s3:us-east-1:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawss3useast1222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-east-1:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:s3:af-south-1:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawss3afsouth1222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:af-south-1:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:s3:af-south-1:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawss3afsouth1222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:af-south-1:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:s3:af-south-1:222222222222:stream/testStream, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawss3afsouth1222222222222streamtestStream_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:s3:af-south-1:222222222222:stream/testStream";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:dynamodb:af-south-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:af-south-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawsdynamodbafsouth1222222222222tabletable_name_ResourceArnListarnawsdynamodbafsouth1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:af-south-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:s3:us-east-1:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawss3useast1222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-east-1:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Credentials-sourced account ID parameter is invalid", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArn_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[], Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnList_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> {};
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:af-south-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawsdynamodbafsouth1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:s3:us-east-1:222222222222:stream/testStream, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawss3useast1222222222222streamtestStream_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:s3:us-east-1:222222222222:stream/testStream";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:dynamodb:af-south-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawsdynamodbafsouth1222222222222tabletable_name_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:s3:us-east-1:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawss3useast1222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-east-1:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:s3:af-south-1:222222222222:stream/testStream, ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawss3afsouth1222222222222streamtestStream_ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:af-south-1:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:s3:af-south-1:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawss3afsouth1222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:af-south-1:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:s3:af-south-1:222222222222:stream/testStream, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawss3afsouth1222222222222streamtestStream_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:s3:af-south-1:222222222222:stream/testStream";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:dynamodb:af-south-1:222222222222:table/table_name, ResourceArnList=[arn:aws:dynamodb:af-south-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawsdynamodbafsouth1222222222222tabletable_name_ResourceArnListarnawsdynamodbafsouth1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/table_name";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:af-south-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, ResourceArn=arn:aws:s3:us-east-1:222222222222:stream/testStream, ResourceArnList=[arn:aws:s3:us-east-1:333333333333:stream/testStream], Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ResourceArnarnawss3useast1222222222222streamtestStream_ResourceArnListarnawss3useast1333333333333streamtestStream_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ResourceArn"] = "arn:aws:s3:us-east-1:222222222222:stream/testStream";
            parameters["ResourceArnList"] = new List<string> { "arn:aws:s3:us-east-1:333333333333:stream/testStream" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws:dynamodb:us-east-1:333333333333:table/table_name], Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnListarnawsdynamodbuseast1333333333333tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws:dynamodb:us-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Region=us-new-1, AccountIdEndpointMode=preferred, AccountId=111111111111, UseFIPS=false, UseDualStack=false}")]
        public void Regionusnew1_AccountIdEndpointModepreferred_AccountId111111111111_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-new-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["AccountId"] = "111111111111";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-new-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name], Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnListarnawscndynamodbcnnorth1333333333333tabletable_name_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name" };
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name], Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnListarnawscndynamodbcnnorth1333333333333tabletable_name_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name" };
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name], Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnListarnawscndynamodbcnnorth1333333333333tabletable_name_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name" };
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name], Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnListarnawscndynamodbcnnorth1333333333333tabletable_name_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name" };
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name], Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnListarnawscndynamodbcnnorth1333333333333tabletable_name_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name" };
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name], Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnListarnawscndynamodbcnnorth1333333333333tabletable_name_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name" };
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name], Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnListarnawscndynamodbcnnorth1333333333333tabletable_name_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name" };
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name], Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnListarnawscndynamodbcnnorth1333333333333tabletable_name_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name" };
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name], Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnListarnawscndynamodbcnnorth1333333333333tabletable_name_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name" };
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name], Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnListarnawscndynamodbcnnorth1333333333333tabletable_name_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name" };
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name], Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnListarnawscndynamodbcnnorth1333333333333tabletable_name_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name" };
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name], Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnListarnawscndynamodbcnnorth1333333333333tabletable_name_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/table_name" };
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Region=cn-new-1, AccountIdEndpointMode=preferred, AccountId=111111111111, UseFIPS=false, UseDualStack=false}")]
        public void Regioncnnew1_AccountIdEndpointModepreferred_AccountId111111111111_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "cn-new-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["AccountId"] = "111111111111";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.cn-new-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name], Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnListarnawsusgovdynamodbusgoveast1333333333333tabletable_name_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name], Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnListarnawsusgovdynamodbusgoveast1333333333333tabletable_name_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name], Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnListarnawsusgovdynamodbusgoveast1333333333333tabletable_name_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name], Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnListarnawsusgovdynamodbusgoveast1333333333333tabletable_name_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name], Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnListarnawsusgovdynamodbusgoveast1333333333333tabletable_name_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name], Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnListarnawsusgovdynamodbusgoveast1333333333333tabletable_name_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name], Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnListarnawsusgovdynamodbusgoveast1333333333333tabletable_name_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name], Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnListarnawsusgovdynamodbusgoveast1333333333333tabletable_name_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name], Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnListarnawsusgovdynamodbusgoveast1333333333333tabletable_name_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.ddb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name], Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnListarnawsusgovdynamodbusgoveast1333333333333tabletable_name_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.ddb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name], Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnListarnawsusgovdynamodbusgoveast1333333333333tabletable_name_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name], Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnListarnawsusgovdynamodbusgoveast1333333333333tabletable_name_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Region=us-gov-new-1, AccountIdEndpointMode=preferred, AccountId=111111111111, UseFIPS=false, UseDualStack=false}")]
        public void Regionusgovnew1_AccountIdEndpointModepreferred_AccountId111111111111_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-gov-new-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["AccountId"] = "111111111111";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-gov-new-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name], Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnListarnawsisodynamodbusisoeast1333333333333tabletable_name_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name], Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnListarnawsisodynamodbusisoeast1333333333333tabletable_name_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name], Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnListarnawsisodynamodbusisoeast1333333333333tabletable_name_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name], Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnListarnawsisodynamodbusisoeast1333333333333tabletable_name_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name], Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnListarnawsisodynamodbusisoeast1333333333333tabletable_name_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name], Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnListarnawsisodynamodbusisoeast1333333333333tabletable_name_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name], Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnListarnawsisodynamodbusisoeast1333333333333tabletable_name_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name], Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnListarnawsisodynamodbusisoeast1333333333333tabletable_name_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb-fips.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name], Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ResourceArnListarnawsisodynamodbusisoeast1333333333333tabletable_name_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name], Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void ResourceArnListarnawsisodynamodbusisoeast1333333333333tabletable_name_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name], Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void ResourceArnListarnawsisodynamodbusisoeast1333333333333tabletable_name_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArnList=[arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name], Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void ResourceArnListarnawsisodynamodbusisoeast1333333333333tabletable_name_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArnList"] = new List<string> { "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/table_name" };
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Region=us-iso-new-1, AccountIdEndpointMode=preferred, AccountId=111111111111, UseFIPS=false, UseDualStack=false}")]
        public void Regionusisonew1_AccountIdEndpointModepreferred_AccountId111111111111_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-iso-new-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["AccountId"] = "111111111111";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dynamodb.us-iso-new-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, Endpoint=https://example.com, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Endpointhttpsexamplecom_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true, Endpoint=https://example.com, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Endpointhttpsexamplecom_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false, Endpoint=https://example.com, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Endpointhttpsexamplecom_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true, Endpoint=https://example.com, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Endpointhttpsexamplecom_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false, Endpoint=https://example.com, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Endpointhttpsexamplecom_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true, Endpoint=https://example.com, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Endpointhttpsexamplecom_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false, Endpoint=https://example.com, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Endpointhttpsexamplecom_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true, Endpoint=https://example.com, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Endpointhttpsexamplecom_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false, Endpoint=https://example.com, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Endpointhttpsexamplecom_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true, Endpoint=https://example.com, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Endpointhttpsexamplecom_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false, Endpoint=https://example.com, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Endpointhttpsexamplecom_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true, Endpoint=https://example.com, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Endpointhttpsexamplecom_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Endpoint=https://dynamodb.cn-north-1.api.amazonwebservices.com.cn, Region=cn-north-1, AccountIdEndpointMode=preferred, IsSearchOperation=true}")]
        public void Endpointhttpsdynamodbcnnorth1apiamazonwebservicescomcn_Regioncnnorth1_AccountIdEndpointModepreferred_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Endpoint"] = "https://dynamodb.cn-north-1.api.amazonwebservices.com.cn";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Endpoint override is not supported for dual-stack endpoints. Please enable dual-stack functionality by enabling the configuration. For more details, see: https://docs.aws.amazon.com/sdkref/latest/guide/feature-endpoints.html", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Endpoint=https://dynamodb.us-gov-east-1.api.aws, Region=us-gov-east-1, AccountIdEndpointMode=preferred, IsSearchOperation=true}")]
        public void Endpointhttpsdynamodbusgoveast1apiaws_Regionusgoveast1_AccountIdEndpointModepreferred_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Endpoint"] = "https://dynamodb.us-gov-east-1.api.aws";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Endpoint override is not supported for dual-stack endpoints. Please enable dual-stack functionality by enabling the configuration. For more details, see: https://docs.aws.amazon.com/sdkref/latest/guide/feature-endpoints.html", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Endpoint=https://dynamodb.us-east-1.api.aws, Region=us-east-1, AccountIdEndpointMode=preferred, IsSearchOperation=true}")]
        public void Endpointhttpsdynamodbuseast1apiaws_Regionuseast1_AccountIdEndpointModepreferred_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Endpoint"] = "https://dynamodb.us-east-1.api.aws";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Endpoint override is not supported for dual-stack endpoints. Please enable dual-stack functionality by enabling the configuration. For more details, see: https://docs.aws.amazon.com/sdkref/latest/guide/feature-endpoints.html", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Endpoint=https://111111111111.ddb.us-east-1.api.aws, Region=us-east-1, AccountIdEndpointMode=preferred, IsSearchOperation=true}")]
        public void Endpointhttps111111111111ddbuseast1apiaws_Regionuseast1_AccountIdEndpointModepreferred_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Endpoint"] = "https://111111111111.ddb.us-east-1.api.aws";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.ddb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Endpoint=https://vpce-1a2b3c4d-5e6f.dynamodb.us-east-1.vpce.api.aws, Region=us-east-1, AccountIdEndpointMode=preferred, IsSearchOperation=true}")]
        public void Endpointhttpsvpce1a2b3c4d5e6fdynamodbuseast1vpceapiaws_Regionuseast1_AccountIdEndpointModepreferred_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Endpoint"] = "https://vpce-1a2b3c4d-5e6f.dynamodb.us-east-1.vpce.api.aws";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://vpce-1a2b3c4d-5e6f.dynamodb.us-east-1.vpce.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Endpoint=https://dynamodb.eu-west-1.api.aws, Region=eu-west-1, AccountIdEndpointMode=preferred, IsSearchOperation=true}")]
        public void Endpointhttpsdynamodbeuwest1apiaws_Regioneuwest1_AccountIdEndpointModepreferred_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Endpoint"] = "https://dynamodb.eu-west-1.api.aws";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Endpoint override is not supported for dual-stack endpoints. Please enable dual-stack functionality by enabling the configuration. For more details, see: https://docs.aws.amazon.com/sdkref/latest/guide/feature-endpoints.html", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Endpoint=https://dynamodb.us-west-2.api.aws, Region=us-west-2, AccountIdEndpointMode=preferred, IsSearchOperation=true}")]
        public void Endpointhttpsdynamodbuswest2apiaws_Regionuswest2_AccountIdEndpointModepreferred_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Endpoint"] = "https://dynamodb.us-west-2.api.aws";
            parameters["Region"] = "us-west-2";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Endpoint override is not supported for dual-stack endpoints. Please enable dual-stack functionality by enabling the configuration. For more details, see: https://docs.aws.amazon.com/sdkref/latest/guide/feature-endpoints.html", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Endpoint=https://dynamodb.us-east-1.api.aws/, Region=us-east-1, AccountIdEndpointMode=preferred, IsSearchOperation=true}")]
        public void Endpointhttpsdynamodbuseast1apiaws_Regionuseast1_AccountIdEndpointModepreferred_IsSearchOperationtrue_1_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Endpoint"] = "https://dynamodb.us-east-1.api.aws/";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Endpoint override is not supported for dual-stack endpoints. Please enable dual-stack functionality by enabling the configuration. For more details, see: https://docs.aws.amazon.com/sdkref/latest/guide/feature-endpoints.html", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and local endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and local endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and local endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and local endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and local endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and local endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("http://localhost:8000", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and local endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and local endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=local, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionlocal_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "local";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and local endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Missing Region", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, ResourceArn=arn:aws:dynamodb:us-east-1:not_an_account:table/table_name, IsSearchOperation=true}")]
        public void Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_ResourceArnarnawsdynamodbuseast1not_an_accounttabletable_name_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:not_an_account:table/table_name";
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.search-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Credentials-sourced account ID parameter is invalid", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.search-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArn_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:af-south-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsdynamodbafsouth1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:s3:us-east-1:222222222222:stream/testStream, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawss3useast1222222222222streamtestStream_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:s3:us-east-1:222222222222:stream/testStream";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:s3:af-south-1:222222222222:stream/testStream, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawss3afsouth1222222222222streamtestStream_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:s3:af-south-1:222222222222:stream/testStream";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.search-ddb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.search-ddb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArn_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:af-south-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsdynamodbafsouth1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:s3:us-east-1:222222222222:stream/testStream, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawss3useast1222222222222streamtestStream_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:s3:us-east-1:222222222222:stream/testStream";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:s3:af-south-1:222222222222:stream/testStream, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawss3afsouth1222222222222streamtestStream_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:s3:af-south-1:222222222222:stream/testStream";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.search-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Credentials-sourced account ID parameter is invalid", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.search-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArn_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:af-south-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsdynamodbafsouth1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:s3:us-east-1:222222222222:stream/testStream, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawss3useast1222222222222streamtestStream_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:s3:us-east-1:222222222222:stream/testStream";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:s3:af-south-1:222222222222:stream/testStream, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawss3afsouth1222222222222streamtestStream_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:s3:af-south-1:222222222222:stream/testStream";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.search-ddb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.search-ddb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws:dynamodb:us-east-1:222222222222:table/table_name, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawsdynamodbuseast1222222222222tabletable_name_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Region=us-new-1, AccountIdEndpointMode=preferred, AccountId=111111111111, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void Regionusnew1_AccountIdEndpointModepreferred_AccountId111111111111_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-new-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["AccountId"] = "111111111111";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.search-ddb.us-new-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.search-ddb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.search-ddb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.search-ddb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.search-ddb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.search-ddb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.search-ddb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.search-ddb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.search-ddb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawscndynamodbcnnorth1222222222222tabletable_name_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/table_name";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Region=cn-new-1, AccountIdEndpointMode=preferred, AccountId=111111111111, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void Regioncnnew1_AccountIdEndpointModepreferred_AccountId111111111111_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "cn-new-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["AccountId"] = "111111111111";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.cn-new-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.search-ddb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.search-ddb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.search-ddb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.search-ddb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.search-ddb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.search-ddb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.search-ddb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.search-ddb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawsusgovdynamodbusgoveast1222222222222tabletable_name_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Region=us-gov-new-1, AccountIdEndpointMode=preferred, AccountId=111111111111, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void Regionusgovnew1_AccountIdEndpointModepreferred_AccountId111111111111_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-gov-new-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["AccountId"] = "111111111111";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-gov-new-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb-fips.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false, IsSearchOperation=true}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{ResourceArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true, IsSearchOperation=true}")]
        public void ResourceArnarnawsisodynamodbusisoeast1222222222222tabletable_name_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["ResourceArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/table_name";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["IsSearchOperation"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DynamoDBv2")]
        [Description("{Region=us-iso-new-1, AccountIdEndpointMode=preferred, AccountId=111111111111, UseFIPS=false, UseDualStack=false, IsSearchOperation=true}")]
        public void Regionusisonew1_AccountIdEndpointModepreferred_AccountId111111111111_UseFIPSfalse_UseDualStackfalse_IsSearchOperationtrue_Test()
        {
            var parameters = new DynamoDBEndpointParameters();
            parameters["Region"] = "us-iso-new-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["AccountId"] = "111111111111";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["IsSearchOperation"] = true;
            var endpoint = new AmazonDynamoDBEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://search-dynamodb.us-iso-new-1.c2s.ic.gov", endpoint.URL);
        }

    }
}