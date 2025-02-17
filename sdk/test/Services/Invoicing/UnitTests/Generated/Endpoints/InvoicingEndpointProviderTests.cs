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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Invoicing.Endpoints;
using Amazon.Invoicing.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class InvoicingEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Invoicing")]
        [Description("For custom endpoint with region not set and fips disabled")]
        public void For_custom_endpoint_with_region_not_set_and_fips_disabled_Test()
        {
            var parameters = new InvoicingEndpointParameters();
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonInvoicingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Invoicing")]
        [Description("For custom endpoint with fips enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_Test()
        {
            var parameters = new InvoicingEndpointParameters();
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonInvoicingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Invoicing")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new InvoicingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonInvoicingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://invoicing-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Invoicing")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new InvoicingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonInvoicingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://invoicing.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Invoicing")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new InvoicingEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonInvoicingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://invoicing-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Invoicing")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new InvoicingEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonInvoicingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://invoicing.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Invoicing")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new InvoicingEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonInvoicingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://invoicing-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Invoicing")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new InvoicingEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonInvoicingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://invoicing.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Invoicing")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new InvoicingEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonInvoicingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://invoicing-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Invoicing")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new InvoicingEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonInvoicingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://invoicing.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Invoicing")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new InvoicingEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonInvoicingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://invoicing-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Invoicing")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new InvoicingEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonInvoicingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://invoicing.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Invoicing")]
        [Description("For region eu-isoe-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euisoewest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new InvoicingEndpointParameters();
            parameters["Region"] = "eu-isoe-west-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonInvoicingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://invoicing-fips.eu-isoe-west-1.cloud.adc-e.uk", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Invoicing")]
        [Description("For region eu-isoe-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euisoewest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new InvoicingEndpointParameters();
            parameters["Region"] = "eu-isoe-west-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonInvoicingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://invoicing.eu-isoe-west-1.cloud.adc-e.uk", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Invoicing")]
        [Description("For region us-isof-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usisofsouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new InvoicingEndpointParameters();
            parameters["Region"] = "us-isof-south-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonInvoicingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://invoicing-fips.us-isof-south-1.csp.hci.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Invoicing")]
        [Description("For region us-isof-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usisofsouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new InvoicingEndpointParameters();
            parameters["Region"] = "us-isof-south-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonInvoicingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://invoicing.us-isof-south-1.csp.hci.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Invoicing")]
        [Description("Missing region")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Missing Region")]
        public void Missing_region_Test()
        {
            var parameters = new InvoicingEndpointParameters();
            var endpoint = new AmazonInvoicingEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}