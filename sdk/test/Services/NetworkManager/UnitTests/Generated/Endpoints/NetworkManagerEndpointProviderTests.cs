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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.NetworkManager.Endpoints;
using Amazon.NetworkManager.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class NetworkManagerEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NetworkManager")]
        [Description("For region aws-global with FIPS disabled and DualStack disabled")]
        public void For_region_awsglobal_with_FIPS_disabled_and_DualStack_disabled_374bcf244e7846c9b7070d218e1307b3_Test()
        {
            var parameters = new NetworkManagerEndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonNetworkManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://networkmanager.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NetworkManager")]
        [Description("For region aws-us-gov-global with FIPS disabled and DualStack disabled")]
        public void For_region_awsusgovglobal_with_FIPS_disabled_and_DualStack_disabled_52f05e480c6e42fb899ba43fa1818e22_Test()
        {
            var parameters = new NetworkManagerEndpointParameters();
            parameters["Region"] = "aws-us-gov-global";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonNetworkManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://networkmanager.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NetworkManager")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_9dd706279cd745d1808173308f444db5_Test()
        {
            var parameters = new NetworkManagerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonNetworkManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NetworkManager")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_23d587c0a1f24c8bb135b0650feba1d9_Test()
        {
            var parameters = new NetworkManagerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonNetworkManagerEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NetworkManager")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_b9ed620e16174bcb862eb8df0b0929b5_Test()
        {
            var parameters = new NetworkManagerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonNetworkManagerEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}