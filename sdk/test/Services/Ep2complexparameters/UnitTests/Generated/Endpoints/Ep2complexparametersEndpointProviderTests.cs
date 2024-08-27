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
 * Do not modify this file. This file is generated from the ep2-complex-parameters-2022-08-24.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Ep2complexparameters.Endpoints;
using Amazon.Ep2complexparameters.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    public partial class Ep2complexparametersEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2complexparameters")]
        [Description("Default array values used")]
        public void Default_array_values_used_Test()
        {
            var parameters = new Ep2complexparametersEndpointParameters();
            var endpoint = new AmazonEp2complexparametersEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com/defaultValue1", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2complexparameters")]
        [Description("Empty array")]
        [ExpectedException(typeof(AmazonClientException), @"no array values set")]
        public void Empty_array_Test()
        {
            var parameters = new Ep2complexparametersEndpointParameters();
            parameters["stringArrayParam"] = new List<string> {};
            var endpoint = new AmazonEp2complexparametersEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2complexparameters")]
        [Description("Static value")]
        public void Static_value_Test()
        {
            var parameters = new Ep2complexparametersEndpointParameters();
            parameters["stringArrayParam"] = new List<string> { "staticValue1" };
            var endpoint = new AmazonEp2complexparametersEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com/staticValue1", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2complexparameters")]
        [Description("bound value from input")]
        public void Bound_value_from_input_Test()
        {
            var parameters = new Ep2complexparametersEndpointParameters();
            parameters["stringArrayParam"] = new List<string> { "key1" };
            var endpoint = new AmazonEp2complexparametersEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com/key1", endpoint.URL);
        }

    }
}