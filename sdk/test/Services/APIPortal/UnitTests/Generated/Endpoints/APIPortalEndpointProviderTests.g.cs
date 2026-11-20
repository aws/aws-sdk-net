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
using Amazon.APIPortal.Endpoints;
using Amazon.APIPortal.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Endpoints")]
    [TestCategory("APIPortal")]
    public partial class APIPortalEndpointsTests
    {
        [TestMethod]
        [Description("Commercial region resolves to the dual-stack api.aws suffix by default")]
        public void Commercial_region_resolves_to_the_dualstack_apiaws_suffix_by_default_Test()
        {
            var parameters = new APIPortalEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonAPIPortalEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://apiportal.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("Commercial FIPS resolves to the FIPS dual-stack api.aws host")]
        public void Commercial_FIPS_resolves_to_the_FIPS_dualstack_apiaws_host_Test()
        {
            var parameters = new APIPortalEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonAPIPortalEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://apiportal-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("Explicitly requesting dual-stack in a commercial region")]
        public void Explicitly_requesting_dualstack_in_a_commercial_region_Test()
        {
            var parameters = new APIPortalEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonAPIPortalEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://apiportal.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [Description("ISO (aws-iso) advertises a dual-stack suffix, so the default resolves to its api.aws.* host")]
        public void ISO_awsiso_advertises_a_dualstack_suffix_so_the_default_resolves_to_its_apiaws_host_Test()
        {
            var parameters = new APIPortalEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonAPIPortalEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://apiportal.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("ISO-B (aws-iso-b) advertises a dual-stack suffix, so the default resolves to its api.aws.* host")]
        public void ISOB_awsisob_advertises_a_dualstack_suffix_so_the_default_resolves_to_its_apiaws_host_Test()
        {
            var parameters = new APIPortalEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonAPIPortalEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://apiportal.us-isob-east-1.api.aws.scloud", endpoint.URL);
        }

        [TestMethod]
        [Description("Explicit dual-stack in an ISO partition resolves to its api.aws.* suffix (ISO supports dual-stack)")]
        public void Explicit_dualstack_in_an_ISO_partition_resolves_to_its_apiaws_suffix_ISO_supports_dualstack_Test()
        {
            var parameters = new APIPortalEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonAPIPortalEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://apiportal.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [Description("A custom endpoint override is used verbatim")]
        public void A_custom_endpoint_override_is_used_verbatim_Test()
        {
            var parameters = new APIPortalEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonAPIPortalEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [Description("Missing Region is an error")]
        public void Missing_Region_is_an_error_Test()
        {
            var parameters = new APIPortalEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() =>
            {
                new AmazonAPIPortalEndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Missing Region", exception.Message);
        }
    }
}
