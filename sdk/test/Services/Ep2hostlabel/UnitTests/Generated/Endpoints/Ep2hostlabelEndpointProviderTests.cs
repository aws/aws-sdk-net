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
 * Do not modify this file. This file is generated from the ep2-host-label-2022-08-24.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Ep2hostlabel.Endpoints;
using Amazon.Ep2hostlabel.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    public partial class Ep2hostlabelEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2hostlabel")]
        [Description("standard region is a valid hostlabel")]
        public void Standard_region_is_a_valid_hostlabel_Test()
        {
            var parameters = new Ep2hostlabelEndpointParameters();
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonEp2hostlabelEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2hostlabel")]
        [Description("starting with a number is a valid hostlabel")]
        public void Starting_with_a_number_is_a_valid_hostlabel_Test()
        {
            var parameters = new Ep2hostlabelEndpointParameters();
            parameters["Region"] = "3aws4";
            var endpoint = new AmazonEp2hostlabelEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://3aws4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2hostlabel")]
        [Description("when there are dots, only match if subdomains are allowed")]
        public void When_there_are_dots_only_match_if_subdomains_are_allowed_Test()
        {
            var parameters = new Ep2hostlabelEndpointParameters();
            parameters["Region"] = "part1.part2";
            var endpoint = new AmazonEp2hostlabelEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://part1.part2-subdomains.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2hostlabel")]
        [Description("a space is never a valid hostlabel")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid hostlabel")]
        public void A_space_is_never_a_valid_hostlabel_Test()
        {
            var parameters = new Ep2hostlabelEndpointParameters();
            parameters["Region"] = "part1 part2";
            var endpoint = new AmazonEp2hostlabelEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Ep2hostlabel")]
        [Description("an empty string is not a valid hostlabel")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid hostlabel")]
        public void An_empty_string_is_not_a_valid_hostlabel_Test()
        {
            var parameters = new Ep2hostlabelEndpointParameters();
            parameters["Region"] = "";
            var endpoint = new AmazonEp2hostlabelEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}