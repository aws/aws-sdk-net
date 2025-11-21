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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.SimpleEmailV2.Endpoints;
using Amazon.SimpleEmailV2.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    public partial class SimpleEmailServiceV2EndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For custom endpoint with region set and fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_region_set_and_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For custom endpoint with region not set and fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_region_not_set_and_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("Missing region")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Missing Region")]
        public void Missing_region_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("Valid EndpointId with dualstack and FIPS disabled. i.e, IPv4 Only stack with no FIPS")]
        public void Valid_EndpointId_with_dualstack_and_FIPS_disabled_ie_IPv4_Only_stack_with_no_FIPS_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["EndpointId"] = "abc123.456def";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://abc123.456def.endpoints.email.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("Valid EndpointId with dualstack enabled")]
        public void Valid_EndpointId_with_dualstack_enabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["EndpointId"] = "abc123.456def";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://abc123.456def.endpoints.email.global.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("Valid EndpointId with FIPS set, dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS is not supported with multi-region endpoints")]
        public void Valid_EndpointId_with_FIPS_set_dualstack_disabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["EndpointId"] = "abc123.456def";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("Valid EndpointId with both dualstack and FIPS enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS is not supported with multi-region endpoints")]
        public void Valid_EndpointId_with_both_dualstack_and_FIPS_enabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["EndpointId"] = "abc123.456def";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("Regular regional request, without EndpointId")]
        public void Regular_regional_request_without_EndpointId_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-west-1";
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("Invalid EndpointId (Invalid chars / format)")]
        [ExpectedException(typeof(AmazonClientException), @"EndpointId must be a valid host label")]
        public void Invalid_EndpointId_Invalid_chars_format_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["EndpointId"] = "badactor.com?foo=bar";
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-west-2";
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("Invalid EndpointId (Empty)")]
        [ExpectedException(typeof(AmazonClientException), @"EndpointId must be a valid host label")]
        public void Invalid_EndpointId_Empty_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["EndpointId"] = "";
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-south-1";
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("Valid EndpointId with custom sdk endpoint")]
        public void Valid_EndpointId_with_custom_sdk_endpoint_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["EndpointId"] = "abc123.456def";
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("Valid EndpointId with custom sdk endpoint with FIPS enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS is not supported with multi-region endpoints")]
        public void Valid_EndpointId_with_custom_sdk_endpoint_with_FIPS_enabled_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["EndpointId"] = "abc123.456def";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
        }

    }
}