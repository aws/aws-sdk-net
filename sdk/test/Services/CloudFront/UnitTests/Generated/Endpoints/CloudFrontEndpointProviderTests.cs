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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.CloudFront.Endpoints;
using Amazon.CloudFront.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class CloudFrontEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region aws-global with FIPS disabled and DualStack disabled")]
        public void For_region_awsglobal_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region aws-global with FIPS enabled and DualStack disabled")]
        public void For_region_awsglobal_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "aws-global";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront-fips.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront-fips.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region aws-cn-global with FIPS disabled and DualStack disabled")]
        public void For_region_awscnglobal_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "aws-cn-global";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudfront.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For custom endpoint with region set and fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_region_set_and_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For custom endpoint with region not set and fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_region_not_set_and_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudFront")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new CloudFrontEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCloudFrontEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}