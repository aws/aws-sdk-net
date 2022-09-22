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
using Amazon.Runtime;
using Amazon.SimpleEmailV2.Endpoints;
using Amazon.SimpleEmailV2.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class SimpleEmailServiceV2EndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_cc7af56a221344c88d30fe075f84b569_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_fd1317077b754f95afb15ce075d2f471_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_393d262d19d54c5681f9465a3a213788_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_7ab44e6fa2da4eaa8a55126afa28cbe1_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_612c5a36d8aa47d885799879da65ebb2_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_a70dae5a9cb140cb913627b231ffffdd_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_38ebca81da534ee8870ccb323b5010c8_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_54e771de36ef4797b3f5a363b820f2b0_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_0e1e2df2b19249409a40cc956422217d_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_c6d8e5e6d90c4f67994b0544de286416_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_149d5ed9f7d14430a49a26292e3a71a9_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_dc96391befae4e78af1e00358b3258aa_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_1c77a45e3fa84a84b46c8a655fb3294b_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_6ed4bb1c232f4023bc71bf8249deb361_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_578eb4707b9040e784231530c0f64d90_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_6c92ccba33794d1c995521962d50d5e2_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_0c087746c3af483bbde8e61f2bf4e95e_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_f17a078fa96b4879bb301d25277f4aa8_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_c793cda5d570456186c449de3b8fab09_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_07c364c334844f3182a3c1f16c66d433_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_efe06265f0a8495fa568eeeb65c60dd9_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_da26b0492d0746908bb59c3d3ff76202_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_4c97fd06c3824b89900cd15f7c812097_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_71f1fcf7dd174eebb15364148a645adf_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_91ce7c4fad424c4aa25bb8ab9be8fe2c_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_1f198471c79a4684b79da85956f9e2df_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_8ada96589502401d9158633258537552_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_64b3ebc35ede4ccda08f4f910fe0ce20_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_0a24a9b5e6ef4d73aaf9a09f6c7b86a6_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_e12f1a33534a418492253121c29fc1dc_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_3261725317e740bf864518a90a42b332_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_888f99602e074fd5a12db814757e7158_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_aacedeaa3562462cad2e007579713ea3_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_d943314b9d4b484ebb08426a01e456eb_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_5195c41af3c042f7a9c43b7d97c53ce6_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_0dd959a0923549f5bea6aeaf457bf64a_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_a9cd18c7f08c4fd7bc2a06746bb437aa_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_eb0deb1224dc4e6fa782ea4227fa3b99_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_6bbf65fe93d04b7f82768ab46a9effb6_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_9f11b3dab32842299a2896c7215bcb59_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_bdbbd9de3f5741398289ccdcf1f404be_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_a7199ae314774a39b1e608eca991b59b_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_c0713a7a46094ebb854a0b0f3256f164_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_4dacf294143d414a874b344896842c33_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_a10f9dbb02104ee8808ec6ad1ac414e8_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_7d2f63e372a1463d903a10fe220f7ae1_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_0e302437291c41ab85f68320735f7a73_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_493b1cf84dfe488db8e0d290cbecde08_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_778915aa698247faa67cd9a3819724a2_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_7abe90ee9db2423792a66207bd0855c1_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_a9652e5e0145485d95634d544ab0b3e7_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_a608d101607b434e9cd0c15d06be63c5_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_a520dc5928634144bd748cf1e0e3bcf2_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_e4bcfb25eb004a17939c35566ad4dbc2_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_54e37ad75ab24a3781ad8d54b9273dc8_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_79196d824d074d8ebf2d645dda0aee86_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_802ffd3f8ca24ebd944ac7f163127fb2_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_8b4a6cd1e3f34e2e89be93bfb16147b1_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_0564e9ad63374ee5b072cf99f00a71cd_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_591b708a99b84825a41881b4ddc34907_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_aa564f66316e4a8b84d6283064ab04d9_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_25697ac1ede74457a14ea1404784aba9_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_8d78b52f20e7458abbf9f25e53070ae7_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_6273a389e4234455a96a2647506caa07_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_f6abd78bef42480f9eeade3543b686b2_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_955b5677bffe4de4b5637f2b3c42a50e_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_abcc636bc4644778a998b5d23b1ce85d_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_b956372edeec46f89351cf74bc2a5a82_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_1e1e6e7138d2407cb9c06bb9dc1f4247_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_3566b5a8bfd94506ad1a069d69e20951_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_b521e6651e854fa2a3eb94859991a5e8_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_c807e96fe5ec46a499794e156192000d_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_1c914d76c8814af08505ed2d051349e6_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_22018c2c0d9a457f998fefaf644a7634_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_9085e69e225d4870a753d1f4dab32ae3_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_2d991949bb3742a2acd2c4aea93c4dee_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_d8d90dfb799c441788705bbcc564d0c4_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_511ee629771c46a298ad6b23129d7bec_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_3467dbec33bd4a48a7b89b25e5fb8d9b_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_98ce2eae1b384ea7b9c9e6c5adc57a9a_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_29d302c8547a4f8da92d74c3a7af6e1d_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_df9f037b6e0c45e1a9923af950825bb7_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_6dab377ea1184dbdb78b548709b2d438_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_d31318a6737948b896ce8a6e31408c0e_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_58c617c272ab42f288e0ac4ed2cdfa43_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_94b41b3938c4498d8785057956333c8e_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_52fc925b59e34537b502eacd8ef8c7c0_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_f82f6987457a4fe8b53db5b43875ad66_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_10764813e217400f9703b94fddb9ee52_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_6fd2dd0a902b4ae2bd54a32dbce882ac_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_d7943d882de1474aadcd15ab172ce18d_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_a2860764f4864b7aa70a44044c68ed26_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://email.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_6586568627ca404b8d0a0da087e6036a_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
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
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_98999c520901455f98c1732334238d27_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleEmailV2")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_1cc89323a772459784052b39f57b8a31_Test()
        {
            var parameters = new SimpleEmailServiceV2EndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSimpleEmailServiceV2EndpointProvider().ResolveEndpoint(parameters);
        }

    }
}