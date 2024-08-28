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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.NeptuneGraph.Endpoints;
using Amazon.NeptuneGraph.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    public partial class NeptuneGraphEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Region and CP ApiType are provided")]
        public void Region_and_CP_ApiType_are_provided_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["Endpoint"] = "https://mycustomDomain.com";
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mycustomDomain.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Region and DP ApiType are provided")]
        public void Region_and_DP_ApiType_are_provided_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["Endpoint"] = "https://mycustomDomain.com";
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mycustomDomain.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Region and invalid ApiType are provided")]
        public void Region_and_invalid_ApiType_are_provided_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["Endpoint"] = "https://mycustomDomain.com";
            parameters["ApiType"] = "someInvalidApiType";
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mycustomDomain.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Only invalid ApiType is provided")]
        public void Only_invalid_ApiType_is_provided_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["Endpoint"] = "https://mycustomDomain.com";
            parameters["ApiType"] = "someInvalidApiType";
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://mycustomDomain.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: us-east-1, useFipsEndpoint: true, useDualStackEndpoint: true")]
        public void Validate_CP_endpoint_in_region_useast1_useFipsEndpoint_true_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: us-east-1, useFipsEndpoint: true, useDualStackEndpoint: true")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: fips endpoint is not supported for this API")]
        public void Validate_DP_endpoint_in_region_useast1_useFipsEndpoint_true_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: us-east-1, useFipsEndpoint: true, useDualStackEndpoint: false")]
        public void Validate_CP_endpoint_in_region_useast1_useFipsEndpoint_true_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: us-east-1, useFipsEndpoint: true, useDualStackEndpoint: false")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: fips endpoint is not supported for this API")]
        public void Validate_DP_endpoint_in_region_useast1_useFipsEndpoint_true_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: us-east-1, useFipsEndpoint: false, useDualStackEndpoint: true")]
        public void Validate_CP_endpoint_in_region_useast1_useFipsEndpoint_false_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: us-east-1, useFipsEndpoint: false, useDualStackEndpoint: true")]
        public void Validate_DP_endpoint_in_region_useast1_useFipsEndpoint_false_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.us-east-1.on.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: us-east-1, useFipsEndpoint: false, useDualStackEndpoint: false")]
        public void Validate_CP_endpoint_in_region_useast1_useFipsEndpoint_false_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: us-east-1, useFipsEndpoint: false, useDualStackEndpoint: false")]
        public void Validate_DP_endpoint_in_region_useast1_useFipsEndpoint_false_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://us-east-1.neptune-graph.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: us-east-2, useFipsEndpoint: true, useDualStackEndpoint: true")]
        public void Validate_CP_endpoint_in_region_useast2_useFipsEndpoint_true_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: us-east-2, useFipsEndpoint: true, useDualStackEndpoint: true")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: fips endpoint is not supported for this API")]
        public void Validate_DP_endpoint_in_region_useast2_useFipsEndpoint_true_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: us-east-2, useFipsEndpoint: true, useDualStackEndpoint: false")]
        public void Validate_CP_endpoint_in_region_useast2_useFipsEndpoint_true_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: us-east-2, useFipsEndpoint: true, useDualStackEndpoint: false")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: fips endpoint is not supported for this API")]
        public void Validate_DP_endpoint_in_region_useast2_useFipsEndpoint_true_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: us-east-2, useFipsEndpoint: false, useDualStackEndpoint: true")]
        public void Validate_CP_endpoint_in_region_useast2_useFipsEndpoint_false_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: us-east-2, useFipsEndpoint: false, useDualStackEndpoint: true")]
        public void Validate_DP_endpoint_in_region_useast2_useFipsEndpoint_false_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.us-east-2.on.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: us-east-2, useFipsEndpoint: false, useDualStackEndpoint: false")]
        public void Validate_CP_endpoint_in_region_useast2_useFipsEndpoint_false_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: us-east-2, useFipsEndpoint: false, useDualStackEndpoint: false")]
        public void Validate_DP_endpoint_in_region_useast2_useFipsEndpoint_false_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://us-east-2.neptune-graph.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: us-west-2, useFipsEndpoint: true, useDualStackEndpoint: true")]
        public void Validate_CP_endpoint_in_region_uswest2_useFipsEndpoint_true_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: us-west-2, useFipsEndpoint: true, useDualStackEndpoint: true")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: fips endpoint is not supported for this API")]
        public void Validate_DP_endpoint_in_region_uswest2_useFipsEndpoint_true_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: us-west-2, useFipsEndpoint: true, useDualStackEndpoint: false")]
        public void Validate_CP_endpoint_in_region_uswest2_useFipsEndpoint_true_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: us-west-2, useFipsEndpoint: true, useDualStackEndpoint: false")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: fips endpoint is not supported for this API")]
        public void Validate_DP_endpoint_in_region_uswest2_useFipsEndpoint_true_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: us-west-2, useFipsEndpoint: false, useDualStackEndpoint: true")]
        public void Validate_CP_endpoint_in_region_uswest2_useFipsEndpoint_false_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: us-west-2, useFipsEndpoint: false, useDualStackEndpoint: true")]
        public void Validate_DP_endpoint_in_region_uswest2_useFipsEndpoint_false_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.us-west-2.on.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: us-west-2, useFipsEndpoint: false, useDualStackEndpoint: false")]
        public void Validate_CP_endpoint_in_region_uswest2_useFipsEndpoint_false_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: us-west-2, useFipsEndpoint: false, useDualStackEndpoint: false")]
        public void Validate_DP_endpoint_in_region_uswest2_useFipsEndpoint_false_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://us-west-2.neptune-graph.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: eu-west-1, useFipsEndpoint: true, useDualStackEndpoint: true")]
        public void Validate_CP_endpoint_in_region_euwest1_useFipsEndpoint_true_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: eu-west-1, useFipsEndpoint: true, useDualStackEndpoint: true")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: fips endpoint is not supported for this API")]
        public void Validate_DP_endpoint_in_region_euwest1_useFipsEndpoint_true_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: eu-west-1, useFipsEndpoint: true, useDualStackEndpoint: false")]
        public void Validate_CP_endpoint_in_region_euwest1_useFipsEndpoint_true_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: eu-west-1, useFipsEndpoint: true, useDualStackEndpoint: false")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: fips endpoint is not supported for this API")]
        public void Validate_DP_endpoint_in_region_euwest1_useFipsEndpoint_true_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: eu-west-1, useFipsEndpoint: false, useDualStackEndpoint: true")]
        public void Validate_CP_endpoint_in_region_euwest1_useFipsEndpoint_false_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: eu-west-1, useFipsEndpoint: false, useDualStackEndpoint: true")]
        public void Validate_DP_endpoint_in_region_euwest1_useFipsEndpoint_false_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.eu-west-1.on.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: eu-west-1, useFipsEndpoint: false, useDualStackEndpoint: false")]
        public void Validate_CP_endpoint_in_region_euwest1_useFipsEndpoint_false_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: eu-west-1, useFipsEndpoint: false, useDualStackEndpoint: false")]
        public void Validate_DP_endpoint_in_region_euwest1_useFipsEndpoint_false_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://eu-west-1.neptune-graph.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: eu-west-2, useFipsEndpoint: true, useDualStackEndpoint: true")]
        public void Validate_CP_endpoint_in_region_euwest2_useFipsEndpoint_true_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: eu-west-2, useFipsEndpoint: true, useDualStackEndpoint: true")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: fips endpoint is not supported for this API")]
        public void Validate_DP_endpoint_in_region_euwest2_useFipsEndpoint_true_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: eu-west-2, useFipsEndpoint: true, useDualStackEndpoint: false")]
        public void Validate_CP_endpoint_in_region_euwest2_useFipsEndpoint_true_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: eu-west-2, useFipsEndpoint: true, useDualStackEndpoint: false")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: fips endpoint is not supported for this API")]
        public void Validate_DP_endpoint_in_region_euwest2_useFipsEndpoint_true_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: eu-west-2, useFipsEndpoint: false, useDualStackEndpoint: true")]
        public void Validate_CP_endpoint_in_region_euwest2_useFipsEndpoint_false_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: eu-west-2, useFipsEndpoint: false, useDualStackEndpoint: true")]
        public void Validate_DP_endpoint_in_region_euwest2_useFipsEndpoint_false_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.eu-west-2.on.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: eu-west-2, useFipsEndpoint: false, useDualStackEndpoint: false")]
        public void Validate_CP_endpoint_in_region_euwest2_useFipsEndpoint_false_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: eu-west-2, useFipsEndpoint: false, useDualStackEndpoint: false")]
        public void Validate_DP_endpoint_in_region_euwest2_useFipsEndpoint_false_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://eu-west-2.neptune-graph.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: eu-central-1, useFipsEndpoint: true, useDualStackEndpoint: true")]
        public void Validate_CP_endpoint_in_region_eucentral1_useFipsEndpoint_true_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: eu-central-1, useFipsEndpoint: true, useDualStackEndpoint: true")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: fips endpoint is not supported for this API")]
        public void Validate_DP_endpoint_in_region_eucentral1_useFipsEndpoint_true_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: eu-central-1, useFipsEndpoint: true, useDualStackEndpoint: false")]
        public void Validate_CP_endpoint_in_region_eucentral1_useFipsEndpoint_true_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: eu-central-1, useFipsEndpoint: true, useDualStackEndpoint: false")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: fips endpoint is not supported for this API")]
        public void Validate_DP_endpoint_in_region_eucentral1_useFipsEndpoint_true_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: eu-central-1, useFipsEndpoint: false, useDualStackEndpoint: true")]
        public void Validate_CP_endpoint_in_region_eucentral1_useFipsEndpoint_false_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: eu-central-1, useFipsEndpoint: false, useDualStackEndpoint: true")]
        public void Validate_DP_endpoint_in_region_eucentral1_useFipsEndpoint_false_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.eu-central-1.on.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: eu-central-1, useFipsEndpoint: false, useDualStackEndpoint: false")]
        public void Validate_CP_endpoint_in_region_eucentral1_useFipsEndpoint_false_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: eu-central-1, useFipsEndpoint: false, useDualStackEndpoint: false")]
        public void Validate_DP_endpoint_in_region_eucentral1_useFipsEndpoint_false_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://eu-central-1.neptune-graph.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: ap-southeast-1, useFipsEndpoint: true, useDualStackEndpoint: true")]
        public void Validate_CP_endpoint_in_region_apsoutheast1_useFipsEndpoint_true_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: ap-southeast-1, useFipsEndpoint: true, useDualStackEndpoint: true")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: fips endpoint is not supported for this API")]
        public void Validate_DP_endpoint_in_region_apsoutheast1_useFipsEndpoint_true_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: ap-southeast-1, useFipsEndpoint: true, useDualStackEndpoint: false")]
        public void Validate_CP_endpoint_in_region_apsoutheast1_useFipsEndpoint_true_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: ap-southeast-1, useFipsEndpoint: true, useDualStackEndpoint: false")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: fips endpoint is not supported for this API")]
        public void Validate_DP_endpoint_in_region_apsoutheast1_useFipsEndpoint_true_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: ap-southeast-1, useFipsEndpoint: false, useDualStackEndpoint: true")]
        public void Validate_CP_endpoint_in_region_apsoutheast1_useFipsEndpoint_false_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: ap-southeast-1, useFipsEndpoint: false, useDualStackEndpoint: true")]
        public void Validate_DP_endpoint_in_region_apsoutheast1_useFipsEndpoint_false_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.ap-southeast-1.on.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: ap-southeast-1, useFipsEndpoint: false, useDualStackEndpoint: false")]
        public void Validate_CP_endpoint_in_region_apsoutheast1_useFipsEndpoint_false_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: ap-southeast-1, useFipsEndpoint: false, useDualStackEndpoint: false")]
        public void Validate_DP_endpoint_in_region_apsoutheast1_useFipsEndpoint_false_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ap-southeast-1.neptune-graph.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: ap-northeast-1, useFipsEndpoint: true, useDualStackEndpoint: true")]
        public void Validate_CP_endpoint_in_region_apnortheast1_useFipsEndpoint_true_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: ap-northeast-1, useFipsEndpoint: true, useDualStackEndpoint: true")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: fips endpoint is not supported for this API")]
        public void Validate_DP_endpoint_in_region_apnortheast1_useFipsEndpoint_true_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: ap-northeast-1, useFipsEndpoint: true, useDualStackEndpoint: false")]
        public void Validate_CP_endpoint_in_region_apnortheast1_useFipsEndpoint_true_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: ap-northeast-1, useFipsEndpoint: true, useDualStackEndpoint: false")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: fips endpoint is not supported for this API")]
        public void Validate_DP_endpoint_in_region_apnortheast1_useFipsEndpoint_true_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: ap-northeast-1, useFipsEndpoint: false, useDualStackEndpoint: true")]
        public void Validate_CP_endpoint_in_region_apnortheast1_useFipsEndpoint_false_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: ap-northeast-1, useFipsEndpoint: false, useDualStackEndpoint: true")]
        public void Validate_DP_endpoint_in_region_apnortheast1_useFipsEndpoint_false_useDualStackEndpoint_true_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.ap-northeast-1.on.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate CP endpoint in region: ap-northeast-1, useFipsEndpoint: false, useDualStackEndpoint: false")]
        public void Validate_CP_endpoint_in_region_apnortheast1_useFipsEndpoint_false_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://neptune-graph.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate DP endpoint in region: ap-northeast-1, useFipsEndpoint: false, useDualStackEndpoint: false")]
        public void Validate_DP_endpoint_in_region_apnortheast1_useFipsEndpoint_false_useDualStackEndpoint_false_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ap-northeast-1.neptune-graph.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate When no region is provided")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Missing Region")]
        public void Validate_When_no_region_is_provided_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["ApiType"] = "DataPlane";
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Validate When invalid/unknown ApiType provided")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Unknown ApiType")]
        public void Validate_When_invalidunknown_ApiType_provided_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["ApiType"] = "someUnknownValue";
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Both Fips and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void Both_Fips_and_dualstack_enabled_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["Endpoint"] = "https://mycustomDomain.com";
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void Fips_enabled_and_dualstack_disabled_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["Endpoint"] = "https://mycustomDomain.com";
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NeptuneGraph")]
        [Description("Fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void Fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new NeptuneGraphEndpointParameters();
            parameters["Endpoint"] = "https://mycustomDomain.com";
            parameters["ApiType"] = "ControlPlane";
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonNeptuneGraphEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}