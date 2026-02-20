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
 * Do not modify this file. This file is generated from the signer-data-2017-08-25.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.SignerData.Endpoints;
using Amazon.SignerData.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class SignerDataEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SignerData")]
        [Description("Standard region endpoint")]
        public void Standard_region_endpoint_Test()
        {
            var parameters = new SignerDataEndpointParameters();
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonSignerDataEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data-signer.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SignerData")]
        [Description("European Sovereign Cloud region endpoint")]
        public void European_Sovereign_Cloud_region_endpoint_Test()
        {
            var parameters = new SignerDataEndpointParameters();
            parameters["Region"] = "eusc-de-east-1";
            var endpoint = new AmazonSignerDataEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data-signer.eusc-de-east-1.amazonaws.eu", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SignerData")]
        [Description("Custom endpoint override")]
        public void Custom_endpoint_override_Test()
        {
            var parameters = new SignerDataEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://vpce-123.data-signer.us-east-1.vpce.amazonaws.com";
            var endpoint = new AmazonSignerDataEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://vpce-123.data-signer.us-east-1.vpce.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SignerData")]
        [Description("FIPS endpoint")]
        public void FIPS_endpoint_Test()
        {
            var parameters = new SignerDataEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSignerDataEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data-signer-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SignerData")]
        [Description("Dual-stack endpoint")]
        public void Dualstack_endpoint_Test()
        {
            var parameters = new SignerDataEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSignerDataEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data-signer.us-east-1.api.aws", endpoint.URL);
        }

    }
}