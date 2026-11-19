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
using Amazon.OpenSearchMemory.Endpoints;
using Amazon.OpenSearchMemory.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Endpoints")]
    [TestCategory("OpenSearchMemory")]
    public partial class OpenSearchMemoryEndpointsTests
    {
        [TestMethod]
        [Description("A space ID that is not a host label is rejected rather than put in the host name.")]
        public void A_space_ID_that_is_not_a_host_label_is_rejected_rather_than_put_in_the_host_name_Test()
        {
            var parameters = new OpenSearchMemoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["SpaceId"] = "evil.example/#";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonOpenSearchMemoryEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid SpaceId: must be a valid host label", exception.Message);
        }

        [TestMethod]
        [Description("A Region that is not a host label is rejected.")]
        public void A_Region_that_is_not_a_host_label_is_rejected_Test()
        {
            var parameters = new OpenSearchMemoryEndpointParameters();
            parameters["Region"] = "us-east-1/#";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonOpenSearchMemoryEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Region must be a valid host label", exception.Message);
        }

        [TestMethod]
        [Description("A space ID containing a dot is rejected rather than split across host labels.")]
        public void A_space_ID_containing_a_dot_is_rejected_rather_than_split_across_host_labels_Test()
        {
            var parameters = new OpenSearchMemoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["SpaceId"] = "sp-abc.def123";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonOpenSearchMemoryEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid SpaceId: must be a valid host label", exception.Message);
        }

        [TestMethod]
        [Description("GetMemory goes to the endpoint of the space in its input.")]
        public void GetMemory_goes_to_the_endpoint_of_the_space_in_its_input_Test()
        {
            var parameters = new OpenSearchMemoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["SpaceId"] = "sp-abc123def456";
            var endpoint = new AmazonOpenSearchMemoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sp-abc123def456.osm.us-east-1.on.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("ListSpaces goes to the regional endpoint.")]
        public void ListSpaces_goes_to_the_regional_endpoint_Test()
        {
            var parameters = new OpenSearchMemoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonOpenSearchMemoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://osm.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("With a space ID: the space's endpoint.")]
        public void With_a_space_ID_the_spaces_endpoint_Test()
        {
            var parameters = new OpenSearchMemoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["SpaceId"] = "sp-abc123def456";
            var endpoint = new AmazonOpenSearchMemoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sp-abc123def456.osm.us-east-1.on.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("Without a space ID: the regional endpoint.")]
        public void Without_a_space_ID_the_regional_endpoint_Test()
        {
            var parameters = new OpenSearchMemoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonOpenSearchMemoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://osm.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("Endpoint override with a space ID: the override URL.")]
        public void Endpoint_override_with_a_space_ID_the_override_URL_Test()
        {
            var parameters = new OpenSearchMemoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["SpaceId"] = "sp-000000000000";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonOpenSearchMemoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [Description("Endpoint override without a space ID: the override URL.")]
        public void Endpoint_override_without_a_space_ID_the_override_URL_Test()
        {
            var parameters = new OpenSearchMemoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonOpenSearchMemoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [Description("FIPS without a space ID fails: the service has no FIPS endpoint.")]
        public void FIPS_without_a_space_ID_fails_the_service_has_no_FIPS_endpoint_Test()
        {
            var parameters = new OpenSearchMemoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonOpenSearchMemoryEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS is not supported with OpenSearch Memory.", exception.Message);
        }

        [TestMethod]
        [Description("FIPS with a space ID fails: the service has no FIPS endpoint.")]
        public void FIPS_with_a_space_ID_fails_the_service_has_no_FIPS_endpoint_Test()
        {
            var parameters = new OpenSearchMemoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["SpaceId"] = "sp-abc123def456";
            parameters["UseFIPS"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonOpenSearchMemoryEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS is not supported with OpenSearch Memory.", exception.Message);
        }

        [TestMethod]
        [Description("FIPS with an endpoint override fails.")]
        public void FIPS_with_an_endpoint_override_fails_Test()
        {
            var parameters = new OpenSearchMemoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonOpenSearchMemoryEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [Description("GetMemory with FIPS on fails rather than going to the space's endpoint.")]
        public void GetMemory_with_FIPS_on_fails_rather_than_going_to_the_spaces_endpoint_Test()
        {
            var parameters = new OpenSearchMemoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["SpaceId"] = "sp-abc123def456";
            parameters["UseFIPS"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonOpenSearchMemoryEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS is not supported with OpenSearch Memory.", exception.Message);
        }

        [TestMethod]
        [Description("ListSpaces with FIPS on fails rather than going to the regional endpoint.")]
        public void ListSpaces_with_FIPS_on_fails_rather_than_going_to_the_regional_endpoint_Test()
        {
            var parameters = new OpenSearchMemoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonOpenSearchMemoryEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS is not supported with OpenSearch Memory.", exception.Message);
        }
    }
}
