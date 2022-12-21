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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.NimbleStudio.Endpoints;
using Amazon.NimbleStudio.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class NimbleStudioEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://nimble.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("NimbleStudio")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new NimbleStudioEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonNimbleStudioEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}