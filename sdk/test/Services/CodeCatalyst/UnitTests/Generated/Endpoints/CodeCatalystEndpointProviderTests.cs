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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.CodeCatalyst.Endpoints;
using Amazon.CodeCatalyst.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class CodeCatalystEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeCatalyst")]
        [Description("Override endpoint")]
        public void Override_endpoint_Test()
        {
            var parameters = new CodeCatalystEndpointParameters();
            parameters["Endpoint"] = "https://test.codecatalyst.global.api.aws";
            var endpoint = new AmazonCodeCatalystEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://test.codecatalyst.global.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeCatalyst")]
        [Description("Default endpoint (region not set)")]
        public void Default_endpoint_region_not_set_Test()
        {
            var parameters = new CodeCatalystEndpointParameters();
            var endpoint = new AmazonCodeCatalystEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codecatalyst.global.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeCatalyst")]
        [Description("Default FIPS endpoint (region not set)")]
        public void Default_FIPS_endpoint_region_not_set_Test()
        {
            var parameters = new CodeCatalystEndpointParameters();
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeCatalystEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codecatalyst-fips.global.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeCatalyst")]
        [Description("Default endpoint (region: aws-global)")]
        public void Default_endpoint_region_awsglobal_Test()
        {
            var parameters = new CodeCatalystEndpointParameters();
            parameters["Region"] = "aws-global";
            var endpoint = new AmazonCodeCatalystEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codecatalyst.global.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeCatalyst")]
        [Description("Default FIPS endpoint (region: aws-global)")]
        public void Default_FIPS_endpoint_region_awsglobal_Test()
        {
            var parameters = new CodeCatalystEndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeCatalystEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codecatalyst-fips.global.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeCatalyst")]
        [Description("Default endpoint for a valid home region (region: us-west-2)")]
        public void Default_endpoint_for_a_valid_home_region_region_uswest2_Test()
        {
            var parameters = new CodeCatalystEndpointParameters();
            parameters["Region"] = "us-west-2";
            var endpoint = new AmazonCodeCatalystEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codecatalyst.global.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeCatalyst")]
        [Description("Default FIPS endpoint for a valid home region (region: us-west-2)")]
        public void Default_FIPS_endpoint_for_a_valid_home_region_region_uswest2_Test()
        {
            var parameters = new CodeCatalystEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeCatalystEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codecatalyst-fips.global.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeCatalyst")]
        [Description("Default endpoint for an unavailable home region (region: us-east-1)")]
        public void Default_endpoint_for_an_unavailable_home_region_region_useast1_Test()
        {
            var parameters = new CodeCatalystEndpointParameters();
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonCodeCatalystEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codecatalyst.global.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeCatalyst")]
        [Description("Default FIPS endpoint for an unavailable home region (region: us-east-1)")]
        public void Default_FIPS_endpoint_for_an_unavailable_home_region_region_useast1_Test()
        {
            var parameters = new CodeCatalystEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeCatalystEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codecatalyst-fips.global.api.aws", endpoint.URL);
        }

    }
}