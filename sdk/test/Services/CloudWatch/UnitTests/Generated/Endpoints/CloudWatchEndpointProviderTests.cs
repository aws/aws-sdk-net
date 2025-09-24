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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.CloudWatch.Endpoints;
using Amazon.CloudWatch.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    public partial class CloudWatchEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For custom endpoint with region not set and fips disabled")]
        public void For_custom_endpoint_with_region_not_set_and_fips_disabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For custom endpoint with fips enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region eu-isoe-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euisoewest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "eu-isoe-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring-fips.eu-isoe-west-1.cloud.adc-e.uk", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region eu-isoe-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euisoewest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "eu-isoe-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring.eu-isoe-west-1.cloud.adc-e.uk", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region us-isof-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisofsouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "us-isof-south-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring-fips.us-isof-south-1.csp.hci.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region us-isof-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisofsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "us-isof-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring.us-isof-south-1.csp.hci.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region eusc-de-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euscdeeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "eusc-de-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring-fips.eusc-de-east-1.amazonaws.eu", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("For region eusc-de-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euscdeeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            parameters["Region"] = "eusc-de-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://monitoring.eusc-de-east-1.amazonaws.eu", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudWatch")]
        [Description("Missing region")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Missing Region")]
        public void Missing_region_Test()
        {
            var parameters = new CloudWatchEndpointParameters();
            var endpoint = new AmazonCloudWatchEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}