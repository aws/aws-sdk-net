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
using Amazon.AgentDiscovery.Endpoints;
using Amazon.AgentDiscovery.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Endpoints")]
    [TestCategory("AgentDiscovery")]
    public partial class AgentDiscoveryEndpointsTests
    {
        [TestMethod]
        [Description("us-east-1 resolves to its own Regional endpoint and signs for us-east-1")]
        public void Useast1_resolves_to_its_own_Regional_endpoint_and_signs_for_useast1_Test()
        {
            var parameters = new AgentDiscoveryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonAgentDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://agent-discovery.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("ap-northeast-1 resolves to its own Regional endpoint and signs for ap-northeast-1")]
        public void Apnortheast1_resolves_to_its_own_Regional_endpoint_and_signs_for_apnortheast1_Test()
        {
            var parameters = new AgentDiscoveryEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonAgentDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://agent-discovery.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("An aws Region where Agent Discovery doesn't serve gets the standard pattern, not another Region's endpoint")]
        public void An_aws_Region_where_Agent_Discovery_doesnt_serve_gets_the_standard_pattern_not_another_Regions_endpoint_Test()
        {
            var parameters = new AgentDiscoveryEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonAgentDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://agent-discovery.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("eu-west-1 resolves to its own Regional endpoint and signs for eu-west-1")]
        public void Euwest1_resolves_to_its_own_Regional_endpoint_and_signs_for_euwest1_Test()
        {
            var parameters = new AgentDiscoveryEndpointParameters();
            parameters["Region"] = "eu-west-1";
            var endpoint = new AmazonAgentDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://agent-discovery.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("A Region in the aws-cn partition gets the standard Regional pattern")]
        public void A_Region_in_the_awscn_partition_gets_the_standard_Regional_pattern_Test()
        {
            var parameters = new AgentDiscoveryEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonAgentDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://agent-discovery.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [Description("A Region in the aws-us-gov partition gets the standard Regional pattern, not the commercial global endpoint")]
        public void A_Region_in_the_awsusgov_partition_gets_the_standard_Regional_pattern_not_the_commercial_global_endpoint_Test()
        {
            var parameters = new AgentDiscoveryEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonAgentDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://agent-discovery.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [Description("FIPS is an error")]
        public void FIPS_is_an_error_Test()
        {
            var parameters = new AgentDiscoveryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonAgentDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"FIPS is enabled but Agent Discovery does not have a FIPS endpoint", exception.Message);
        }

        [TestMethod]
        [Description("Dual-stack resolves to the same Regional endpoint, which is already dual-stack")]
        public void Dualstack_resolves_to_the_same_Regional_endpoint_which_is_already_dualstack_Test()
        {
            var parameters = new AgentDiscoveryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonAgentDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://agent-discovery.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("Dual-stack in a Region Agent Discovery doesn't serve gets the dual-stack standard pattern")]
        public void Dualstack_in_a_Region_Agent_Discovery_doesnt_serve_gets_the_dualstack_standard_pattern_Test()
        {
            var parameters = new AgentDiscoveryEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonAgentDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://agent-discovery.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("An endpoint override wins over the Region")]
        public void An_endpoint_override_wins_over_the_Region_Test()
        {
            var parameters = new AgentDiscoveryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAgentDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [Description("An endpoint override needs no Region")]
        public void An_endpoint_override_needs_no_Region_Test()
        {
            var parameters = new AgentDiscoveryEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAgentDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [Description("An endpoint override with FIPS is an error")]
        public void An_endpoint_override_with_FIPS_is_an_error_Test()
        {
            var parameters = new AgentDiscoveryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonAgentDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [Description("An endpoint override with dual-stack is an error")]
        public void An_endpoint_override_with_dualstack_is_an_error_Test()
        {
            var parameters = new AgentDiscoveryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonAgentDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [Description("No Region and no endpoint override is an error")]
        public void No_Region_and_no_endpoint_override_is_an_error_Test()
        {
            var parameters = new AgentDiscoveryEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonAgentDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Missing Region", exception.Message);
        }
    }
}
