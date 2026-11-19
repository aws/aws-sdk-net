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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.DynamoDBStreams.Endpoints;
using Amazon.DynamoDBStreams.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Endpoints")]
    [TestCategory("DynamoDBStreams")]
    public partial class DynamoDBStreamsEndpointsTests
    {
        [TestMethod]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("For custom endpoint with region set and fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_region_set_and_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For custom endpoint with region not set and fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_region_not_set_and_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [Description("Missing region")]
        public void Missing_region_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Missing Region", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true, Endpoint=https://example.com}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Endpointhttpsexamplecom_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [Description("{Region=local, UseFIPS=false, UseDualStack=false}")]
        public void Regionlocal_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "local";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.local.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{UseFIPS=false, UseDualStack=false}")]
        public void UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Missing Region", exception.Message);
        }

        [TestMethod]
        [Description("{Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false, StreamArn=arn:aws:dynamodb:us-east-1:not_an_account:table/T/stream/2024-01-01T00:00:00.000}")]
        public void Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_StreamArnarnawsdynamodbuseast1not_an_accounttableTstream20240101T000000000_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:not_an_account:table/T/stream/2024-01-01T00:00:00.000";
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Credentials-sourced account ID parameter is invalid", exception.Message);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbuseast1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void StreamArn_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:af-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbafsouth1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:kinesis:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawskinesisuseast1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:kinesis:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:af-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbafsouth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:af-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbuseast1222222222222tableTstream20240101T000000000_ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, StreamArn=arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_StreamArnarnawsdynamodbuseast1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, StreamArn=arn:aws:dynamodb:af-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_StreamArnarnawsdynamodbafsouth1222222222222tableTstream20240101T000000000_ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["StreamArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, StreamArn=arn:aws:kinesis:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_StreamArnarnawskinesisuseast1222222222222tableTstream20240101T000000000_ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["StreamArn"] = "arn:aws:kinesis:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, StreamArn=arn:aws:dynamodb:af-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, ShardIterator=arn:aws:dynamodb:af-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_StreamArnarnawsdynamodbafsouth1222222222222tableTstream20240101T000000000_ShardIteratorarnawsdynamodbafsouth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["StreamArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["ShardIterator"] = "arn:aws:dynamodb:af-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbuseast1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbuseast1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbuseast1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbuseast1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void StreamArn_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:af-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbafsouth1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:kinesis:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawskinesisuseast1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:kinesis:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:af-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbafsouth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:af-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbuseast1222222222222tableTstream20240101T000000000_ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, StreamArn=arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_StreamArnarnawsdynamodbuseast1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, StreamArn=arn:aws:dynamodb:af-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_StreamArnarnawsdynamodbafsouth1222222222222tableTstream20240101T000000000_ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["StreamArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, StreamArn=arn:aws:kinesis:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_StreamArnarnawskinesisuseast1222222222222tableTstream20240101T000000000_ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["StreamArn"] = "arn:aws:kinesis:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, StreamArn=arn:aws:dynamodb:af-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, ShardIterator=arn:aws:dynamodb:af-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_StreamArnarnawsdynamodbafsouth1222222222222tableTstream20240101T000000000_ShardIteratorarnawsdynamodbafsouth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["StreamArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["ShardIterator"] = "arn:aws:dynamodb:af-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbuseast1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbuseast1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbuseast1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Credentials-sourced account ID parameter is invalid", exception.Message);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbuseast1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void StreamArn_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded", exception.Message);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:af-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbafsouth1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded", exception.Message);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:kinesis:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawskinesisuseast1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:kinesis:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded", exception.Message);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:af-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbafsouth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:af-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded", exception.Message);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbuseast1222222222222tableTstream20240101T000000000_ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, StreamArn=arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_StreamArnarnawsdynamodbuseast1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, StreamArn=arn:aws:dynamodb:af-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_StreamArnarnawsdynamodbafsouth1222222222222tableTstream20240101T000000000_ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["StreamArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, StreamArn=arn:aws:kinesis:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_StreamArnarnawskinesisuseast1222222222222tableTstream20240101T000000000_ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["StreamArn"] = "arn:aws:kinesis:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, StreamArn=arn:aws:dynamodb:af-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, ShardIterator=arn:aws:dynamodb:af-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_StreamArnarnawsdynamodbafsouth1222222222222tableTstream20240101T000000000_ShardIteratorarnawsdynamodbafsouth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["StreamArn"] = "arn:aws:dynamodb:af-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["ShardIterator"] = "arn:aws:dynamodb:af-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbuseast1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbuseast1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbuseast1222222222222tableTstream20240101T000000000_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:us-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbuseast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionuseast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:us-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=eu-west-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regioneuwest1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=eu-west-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbeuwest1222222222222tableTstream20240101T000000000_Regioneuwest1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=eu-west-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbeuwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioneuwest1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=eu-west-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regioneuwest1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=eu-west-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbeuwest1222222222222tableTstream20240101T000000000_Regioneuwest1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=eu-west-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbeuwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioneuwest1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=eu-west-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regioneuwest1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=eu-west-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbeuwest1222222222222tableTstream20240101T000000000_Regioneuwest1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=eu-west-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbeuwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioneuwest1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=eu-west-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regioneuwest1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=eu-west-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbeuwest1222222222222tableTstream20240101T000000000_Regioneuwest1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=eu-west-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbeuwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioneuwest1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=eu-west-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regioneuwest1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=eu-west-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbeuwest1222222222222tableTstream20240101T000000000_Regioneuwest1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=eu-west-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbeuwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioneuwest1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=eu-west-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regioneuwest1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=eu-west-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbeuwest1222222222222tableTstream20240101T000000000_Regioneuwest1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=eu-west-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbeuwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioneuwest1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=eu-west-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regioneuwest1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=eu-west-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbeuwest1222222222222tableTstream20240101T000000000_Regioneuwest1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=eu-west-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbeuwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioneuwest1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=eu-west-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regioneuwest1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=eu-west-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbeuwest1222222222222tableTstream20240101T000000000_Regioneuwest1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=eu-west-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbeuwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioneuwest1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=eu-west-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regioneuwest1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=eu-west-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbeuwest1222222222222tableTstream20240101T000000000_Regioneuwest1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=eu-west-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbeuwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioneuwest1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=eu-west-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regioneuwest1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=eu-west-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbeuwest1222222222222tableTstream20240101T000000000_Regioneuwest1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=eu-west-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbeuwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioneuwest1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=eu-west-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regioneuwest1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=eu-west-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbeuwest1222222222222tableTstream20240101T000000000_Regioneuwest1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=eu-west-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbeuwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioneuwest1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=eu-west-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regioneuwest1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=eu-west-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbeuwest1222222222222tableTstream20240101T000000000_Regioneuwest1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:eu-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=eu-west-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbeuwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioneuwest1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:eu-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-central-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionmecentral1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-central-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbmecentral1222222222222tableTstream20240101T000000000_Regionmecentral1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-central-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbmecentral1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmecentral1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-central-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionmecentral1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-central-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbmecentral1222222222222tableTstream20240101T000000000_Regionmecentral1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-central-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbmecentral1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmecentral1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-central-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionmecentral1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-central-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbmecentral1222222222222tableTstream20240101T000000000_Regionmecentral1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-central-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbmecentral1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmecentral1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-central-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionmecentral1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-central-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbmecentral1222222222222tableTstream20240101T000000000_Regionmecentral1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-central-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbmecentral1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmecentral1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-central-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionmecentral1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-central-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbmecentral1222222222222tableTstream20240101T000000000_Regionmecentral1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-central-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbmecentral1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmecentral1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-central-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionmecentral1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-central-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbmecentral1222222222222tableTstream20240101T000000000_Regionmecentral1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-central-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbmecentral1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmecentral1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-central-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionmecentral1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-central-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbmecentral1222222222222tableTstream20240101T000000000_Regionmecentral1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-central-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbmecentral1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmecentral1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-central-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionmecentral1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-central-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbmecentral1222222222222tableTstream20240101T000000000_Regionmecentral1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-central-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbmecentral1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmecentral1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-central-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionmecentral1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-central-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbmecentral1222222222222tableTstream20240101T000000000_Regionmecentral1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-central-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbmecentral1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmecentral1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-central-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionmecentral1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-central-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbmecentral1222222222222tableTstream20240101T000000000_Regionmecentral1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-central-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbmecentral1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmecentral1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-central-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionmecentral1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-central-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbmecentral1222222222222tableTstream20240101T000000000_Regionmecentral1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-central-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbmecentral1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmecentral1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-central-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionmecentral1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-central-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbmecentral1222222222222tableTstream20240101T000000000_Regionmecentral1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-central-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-central-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbmecentral1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmecentral1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-central-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-central-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-south-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionmesouth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-south-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbmesouth1222222222222tableTstream20240101T000000000_Regionmesouth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-south-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbmesouth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmesouth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-south-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionmesouth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-south-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbmesouth1222222222222tableTstream20240101T000000000_Regionmesouth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-south-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbmesouth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmesouth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-south-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionmesouth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-south-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbmesouth1222222222222tableTstream20240101T000000000_Regionmesouth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-south-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbmesouth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmesouth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-south-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionmesouth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-south-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbmesouth1222222222222tableTstream20240101T000000000_Regionmesouth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-south-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbmesouth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmesouth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-south-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionmesouth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-south-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbmesouth1222222222222tableTstream20240101T000000000_Regionmesouth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-south-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbmesouth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmesouth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-south-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionmesouth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-south-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbmesouth1222222222222tableTstream20240101T000000000_Regionmesouth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-south-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbmesouth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmesouth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-south-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionmesouth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-south-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbmesouth1222222222222tableTstream20240101T000000000_Regionmesouth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-south-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbmesouth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmesouth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-south-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionmesouth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-south-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbmesouth1222222222222tableTstream20240101T000000000_Regionmesouth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-south-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbmesouth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmesouth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-south-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionmesouth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-south-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbmesouth1222222222222tableTstream20240101T000000000_Regionmesouth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-south-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbmesouth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmesouth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-south-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionmesouth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-south-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbmesouth1222222222222tableTstream20240101T000000000_Regionmesouth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-south-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbmesouth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmesouth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-south-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionmesouth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-south-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsdynamodbmesouth1222222222222tableTstream20240101T000000000_Regionmesouth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-south-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsdynamodbmesouth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmesouth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=me-south-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionmesouth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=me-south-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsdynamodbmesouth1222222222222tableTstream20240101T000000000_Regionmesouth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws:dynamodb:me-south-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=me-south-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsdynamodbmesouth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionmesouth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws:dynamodb:me-south-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "me-south-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawscndynamodbcnnorth1222222222222tableTstream20240101T000000000_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawscndynamodbcnnorth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawscndynamodbcnnorth1222222222222tableTstream20240101T000000000_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawscndynamodbcnnorth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawscndynamodbcnnorth1222222222222tableTstream20240101T000000000_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawscndynamodbcnnorth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawscndynamodbcnnorth1222222222222tableTstream20240101T000000000_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-north-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawscndynamodbcnnorth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorth1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawscndynamodbcnnorth1222222222222tableTstream20240101T000000000_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawscndynamodbcnnorth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawscndynamodbcnnorth1222222222222tableTstream20240101T000000000_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawscndynamodbcnnorth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawscndynamodbcnnorth1222222222222tableTstream20240101T000000000_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawscndynamodbcnnorth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawscndynamodbcnnorth1222222222222tableTstream20240101T000000000_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-north-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawscndynamodbcnnorth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorth1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawscndynamodbcnnorth1222222222222tableTstream20240101T000000000_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawscndynamodbcnnorth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawscndynamodbcnnorth1222222222222tableTstream20240101T000000000_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawscndynamodbcnnorth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawscndynamodbcnnorth1222222222222tableTstream20240101T000000000_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawscndynamodbcnnorth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawscndynamodbcnnorth1222222222222tableTstream20240101T000000000_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-north-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-north-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawscndynamodbcnnorth1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorth1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-north-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-north-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-northwest-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regioncnnorthwest1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-northwest-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawscndynamodbcnnorthwest1222222222222tableTstream20240101T000000000_Regioncnnorthwest1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-northwest-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawscndynamodbcnnorthwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorthwest1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-northwest-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regioncnnorthwest1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-northwest-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawscndynamodbcnnorthwest1222222222222tableTstream20240101T000000000_Regioncnnorthwest1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-northwest-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawscndynamodbcnnorthwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorthwest1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-northwest-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regioncnnorthwest1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-northwest-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawscndynamodbcnnorthwest1222222222222tableTstream20240101T000000000_Regioncnnorthwest1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-northwest-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawscndynamodbcnnorthwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorthwest1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-northwest-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regioncnnorthwest1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-northwest-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawscndynamodbcnnorthwest1222222222222tableTstream20240101T000000000_Regioncnnorthwest1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-northwest-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawscndynamodbcnnorthwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorthwest1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-northwest-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regioncnnorthwest1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-northwest-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawscndynamodbcnnorthwest1222222222222tableTstream20240101T000000000_Regioncnnorthwest1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-northwest-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawscndynamodbcnnorthwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorthwest1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-northwest-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regioncnnorthwest1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-northwest-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawscndynamodbcnnorthwest1222222222222tableTstream20240101T000000000_Regioncnnorthwest1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-northwest-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawscndynamodbcnnorthwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorthwest1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-northwest-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regioncnnorthwest1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-northwest-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawscndynamodbcnnorthwest1222222222222tableTstream20240101T000000000_Regioncnnorthwest1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-northwest-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawscndynamodbcnnorthwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorthwest1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-northwest-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regioncnnorthwest1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-northwest-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawscndynamodbcnnorthwest1222222222222tableTstream20240101T000000000_Regioncnnorthwest1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-northwest-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawscndynamodbcnnorthwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorthwest1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-northwest-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regioncnnorthwest1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-northwest-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawscndynamodbcnnorthwest1222222222222tableTstream20240101T000000000_Regioncnnorthwest1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-northwest-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawscndynamodbcnnorthwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorthwest1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-northwest-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regioncnnorthwest1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-northwest-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawscndynamodbcnnorthwest1222222222222tableTstream20240101T000000000_Regioncnnorthwest1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-northwest-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawscndynamodbcnnorthwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorthwest1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-northwest-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regioncnnorthwest1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-northwest-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawscndynamodbcnnorthwest1222222222222tableTstream20240101T000000000_Regioncnnorthwest1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-northwest-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawscndynamodbcnnorthwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorthwest1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=cn-northwest-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regioncnnorthwest1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=cn-northwest-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawscndynamodbcnnorthwest1222222222222tableTstream20240101T000000000_Regioncnnorthwest1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-cn:dynamodb:cn-northwest-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=cn-northwest-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawscndynamodbcnnorthwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regioncnnorthwest1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-cn:dynamodb:cn-northwest-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "cn-northwest-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsusgovdynamodbusgoveast1222222222222tableTstream20240101T000000000_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsusgovdynamodbusgoveast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsusgovdynamodbusgoveast1222222222222tableTstream20240101T000000000_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsusgovdynamodbusgoveast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsusgovdynamodbusgoveast1222222222222tableTstream20240101T000000000_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsusgovdynamodbusgoveast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsusgovdynamodbusgoveast1222222222222tableTstream20240101T000000000_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsusgovdynamodbusgoveast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgoveast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsusgovdynamodbusgoveast1222222222222tableTstream20240101T000000000_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsusgovdynamodbusgoveast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsusgovdynamodbusgoveast1222222222222tableTstream20240101T000000000_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsusgovdynamodbusgoveast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsusgovdynamodbusgoveast1222222222222tableTstream20240101T000000000_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsusgovdynamodbusgoveast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsusgovdynamodbusgoveast1222222222222tableTstream20240101T000000000_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsusgovdynamodbusgoveast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgoveast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsusgovdynamodbusgoveast1222222222222tableTstream20240101T000000000_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsusgovdynamodbusgoveast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsusgovdynamodbusgoveast1222222222222tableTstream20240101T000000000_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsusgovdynamodbusgoveast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsusgovdynamodbusgoveast1222222222222tableTstream20240101T000000000_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsusgovdynamodbusgoveast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsusgovdynamodbusgoveast1222222222222tableTstream20240101T000000000_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsusgovdynamodbusgoveast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgoveast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-west-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionusgovwest1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-west-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsusgovdynamodbusgovwest1222222222222tableTstream20240101T000000000_Regionusgovwest1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-west-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsusgovdynamodbusgovwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgovwest1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-west-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionusgovwest1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-west-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsusgovdynamodbusgovwest1222222222222tableTstream20240101T000000000_Regionusgovwest1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-west-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsusgovdynamodbusgovwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgovwest1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-west-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionusgovwest1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-west-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsusgovdynamodbusgovwest1222222222222tableTstream20240101T000000000_Regionusgovwest1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-west-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsusgovdynamodbusgovwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgovwest1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-west-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionusgovwest1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-west-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsusgovdynamodbusgovwest1222222222222tableTstream20240101T000000000_Regionusgovwest1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-west-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsusgovdynamodbusgovwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgovwest1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-west-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionusgovwest1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-west-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsusgovdynamodbusgovwest1222222222222tableTstream20240101T000000000_Regionusgovwest1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-west-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsusgovdynamodbusgovwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgovwest1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-west-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionusgovwest1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-west-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsusgovdynamodbusgovwest1222222222222tableTstream20240101T000000000_Regionusgovwest1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-west-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsusgovdynamodbusgovwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgovwest1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-west-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionusgovwest1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-west-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsusgovdynamodbusgovwest1222222222222tableTstream20240101T000000000_Regionusgovwest1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-west-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsusgovdynamodbusgovwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgovwest1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-west-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionusgovwest1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-west-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsusgovdynamodbusgovwest1222222222222tableTstream20240101T000000000_Regionusgovwest1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-west-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsusgovdynamodbusgovwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgovwest1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-west-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionusgovwest1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-west-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsusgovdynamodbusgovwest1222222222222tableTstream20240101T000000000_Regionusgovwest1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-west-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsusgovdynamodbusgovwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgovwest1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-west-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionusgovwest1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-west-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsusgovdynamodbusgovwest1222222222222tableTstream20240101T000000000_Regionusgovwest1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-west-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsusgovdynamodbusgovwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgovwest1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-west-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionusgovwest1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-west-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsusgovdynamodbusgovwest1222222222222tableTstream20240101T000000000_Regionusgovwest1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-west-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsusgovdynamodbusgovwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgovwest1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-gov-west-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionusgovwest1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-gov-west-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsusgovdynamodbusgovwest1222222222222tableTstream20240101T000000000_Regionusgovwest1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://222222222222.streams-ddb-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-gov-west-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsusgovdynamodbusgovwest1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusgovwest1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-us-gov:dynamodb:us-gov-west-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://333333333333.streams-ddb-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsisodynamodbusisoeast1222222222222tableTstream20240101T000000000_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsisodynamodbusisoeast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsisodynamodbusisoeast1222222222222tableTstream20240101T000000000_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsisodynamodbusisoeast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsisodynamodbusisoeast1222222222222tableTstream20240101T000000000_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsisodynamodbusisoeast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsisodynamodbusisoeast1222222222222tableTstream20240101T000000000_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-iso-east-1, AccountIdEndpointMode=preferred, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsisodynamodbusisoeast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusisoeast1_AccountIdEndpointModepreferred_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsisodynamodbusisoeast1222222222222tableTstream20240101T000000000_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsisodynamodbusisoeast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsisodynamodbusisoeast1222222222222tableTstream20240101T000000000_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsisodynamodbusisoeast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsisodynamodbusisoeast1222222222222tableTstream20240101T000000000_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsisodynamodbusisoeast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsisodynamodbusisoeast1222222222222tableTstream20240101T000000000_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-iso-east-1, AccountIdEndpointMode=disabled, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsisodynamodbusisoeast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusisoeast1_AccountIdEndpointModedisabled_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams-dynamodb-fips.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void StreamArnarnawsisodynamodbusisoeast1222222222222tableTstream20240101T000000000_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=false}")]
        public void ShardIteratorarnawsisodynamodbusisoeast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void StreamArnarnawsisodynamodbusisoeast1222222222222tableTstream20240101T000000000_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=false, UseDualStack=true}")]
        public void ShardIteratorarnawsisodynamodbusisoeast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPSfalse_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void StreamArnarnawsisodynamodbusisoeast1222222222222tableTstream20240101T000000000_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=false}")]
        public void ShardIteratorarnawsisodynamodbusisoeast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{AccountId=111111111111, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void AccountId111111111111_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["AccountId"] = "111111111111";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{StreamArn=arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void StreamArnarnawsisodynamodbusisoeast1222222222222tableTstream20240101T000000000_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["StreamArn"] = "arn:aws-iso:dynamodb:us-iso-east-1:222222222222:table/T/stream/2024-01-01T00:00:00.000";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{ShardIterator=arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz, Region=us-iso-east-1, AccountIdEndpointMode=required, UseFIPS=true, UseDualStack=true}")]
        public void ShardIteratorarnawsisodynamodbusisoeast1333333333333tableTstream20240101T0000000001AAAAAAAAAAIxyz_Regionusisoeast1_AccountIdEndpointModerequired_UseFIPStrue_UseDualStacktrue_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["ShardIterator"] = "arn:aws-iso:dynamodb:us-iso-east-1:333333333333:table/T/stream/2024-01-01T00:00:00.000|1|AAAAAAAAAAIxyz";
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region", exception.Message);
        }

        [TestMethod]
        [Description("{Region=us-new-1, AccountIdEndpointMode=preferred, AccountId=111111111111, UseFIPS=false, UseDualStack=false}")]
        public void Regionusnew1_AccountIdEndpointModepreferred_AccountId111111111111_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-new-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["AccountId"] = "111111111111";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.us-new-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{Region=cn-new-1, AccountIdEndpointMode=preferred, AccountId=111111111111, UseFIPS=false, UseDualStack=false}")]
        public void Regioncnnew1_AccountIdEndpointModepreferred_AccountId111111111111_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "cn-new-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["AccountId"] = "111111111111";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.cn-new-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("{Region=us-gov-new-1, AccountIdEndpointMode=preferred, AccountId=111111111111, UseFIPS=false, UseDualStack=false}")]
        public void Regionusgovnew1_AccountIdEndpointModepreferred_AccountId111111111111_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-gov-new-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["AccountId"] = "111111111111";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://111111111111.streams-ddb.us-gov-new-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("{Region=us-iso-new-1, AccountIdEndpointMode=preferred, AccountId=111111111111, UseFIPS=false, UseDualStack=false}")]
        public void Regionusisonew1_AccountIdEndpointModepreferred_AccountId111111111111_UseFIPSfalse_UseDualStackfalse_Test()
        {
            var parameters = new DynamoDBStreamsEndpointParameters();
            parameters["Region"] = "us-iso-new-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["AccountId"] = "111111111111";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonDynamoDBStreamsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://streams.dynamodb.us-iso-new-1.c2s.ic.gov", endpoint.URL);
        }
    }
}
