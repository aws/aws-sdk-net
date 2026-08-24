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
 * Do not modify this file. This file is generated from the agent-registry-2025-12-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.AgentRegistry.Endpoints;
using Amazon.AgentRegistry.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    public partial class AgentRegistryEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AgentRegistry")]
        [Description("Region us-west-2 -> region-based prod host.")]
        public void Region_uswest2_regionbased_prod_host_Test()
        {
            var parameters = new AgentRegistryEndpointParameters();
            parameters["Region"] = "us-west-2";
            var endpoint = new AmazonAgentRegistryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://agent-registry.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AgentRegistry")]
        [Description("Region us-east-1 -> region-based prod host.")]
        public void Region_useast1_regionbased_prod_host_Test()
        {
            var parameters = new AgentRegistryEndpointParameters();
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonAgentRegistryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://agent-registry.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AgentRegistry")]
        [Description("Endpoint override wins over region.")]
        public void Endpoint_override_wins_over_region_Test()
        {
            var parameters = new AgentRegistryEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Endpoint"] = "https://custom.example.aws.dev";
            var endpoint = new AmazonAgentRegistryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://custom.example.aws.dev", endpoint.URL);
        }

    }
}