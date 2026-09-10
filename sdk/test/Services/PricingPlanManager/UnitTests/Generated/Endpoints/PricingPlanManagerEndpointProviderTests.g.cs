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
using Amazon.PricingPlanManager.Endpoints;
using Amazon.PricingPlanManager.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Endpoints")]
    [TestCategory("PricingPlanManager")]
    public partial class PricingPlanManagerEndpointsTests
    {
        [TestMethod]
        [Description("Resolves the us-east-1 endpoint and signs for us-east-1.")]
        public void Resolves_the_useast1_endpoint_and_signs_for_useast1_Test()
        {
            var parameters = new PricingPlanManagerEndpointParameters();
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonPricingPlanManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://pricingplanmanager.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("Routes any other region to the us-east-1 endpoint and still signs for us-east-1.")]
        public void Routes_any_other_region_to_the_useast1_endpoint_and_still_signs_for_useast1_Test()
        {
            var parameters = new PricingPlanManagerEndpointParameters();
            parameters["Region"] = "us-west-2";
            var endpoint = new AmazonPricingPlanManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://pricingplanmanager.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("A custom endpoint override wins over region resolution and signs for us-east-1.")]
        public void A_custom_endpoint_override_wins_over_region_resolution_and_signs_for_useast1_Test()
        {
            var parameters = new PricingPlanManagerEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Endpoint"] = "https://pricingplanmanager.us-east-1.api.aws";
            var endpoint = new AmazonPricingPlanManagerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://pricingplanmanager.us-east-1.api.aws", endpoint.URL);
        }
    }
}
