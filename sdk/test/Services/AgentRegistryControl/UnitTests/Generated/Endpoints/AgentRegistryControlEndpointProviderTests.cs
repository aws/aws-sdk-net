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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.AgentRegistryControl.Endpoints;
using Amazon.AgentRegistryControl.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    public partial class AgentRegistryControlEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AgentRegistryControl")]
        [Description("Region us-west-2 -> region-based prod host.")]
        public void Region_uswest2_regionbased_prod_host_Test()
        {
            var parameters = new AgentRegistryControlEndpointParameters();
            parameters["Region"] = "us-west-2";
            var endpoint = new AmazonAgentRegistryControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://agent-registry-control.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AgentRegistryControl")]
        [Description("Region us-east-1 -> region-based prod host.")]
        public void Region_useast1_regionbased_prod_host_Test()
        {
            var parameters = new AgentRegistryControlEndpointParameters();
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonAgentRegistryControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://agent-registry-control.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AgentRegistryControl")]
        [Description("Endpoint override wins over region.")]
        public void Endpoint_override_wins_over_region_Test()
        {
            var parameters = new AgentRegistryControlEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Endpoint"] = "https://custom.example.aws.dev";
            var endpoint = new AmazonAgentRegistryControlEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://custom.example.aws.dev", endpoint.URL);
        }

    }
}