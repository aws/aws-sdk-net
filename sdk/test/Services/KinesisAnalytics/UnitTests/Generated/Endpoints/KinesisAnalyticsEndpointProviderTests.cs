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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.KinesisAnalytics.Endpoints;
using Amazon.KinesisAnalytics.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class KinesisAnalyticsEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_6be7dacc2ca44c84ae7f62169eb66818_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_a69b09463c354b15a5b7d359723796b4_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_4a2a2adeda8c40ef8cfa79b8e5adc4ce_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_7d6cbd2fa22c4f9ba27d710bf06bb665_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_99eec8a90f2844d38222c005ab15f60c_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_63c1201713b54e2dba3aae10947275e2_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_d6439fb59bb344ddb754e7d8888d3614_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_ec1ebf5270344f51b5ac3765af348141_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_63afca544b2046e19654d15807e8331f_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_cd43cc5173854360ad90c51ba2ff3bf7_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_0621f45c42fc4cfdbf17949b8b34ed92_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_0b059edf8447416495d0468ba9e57a5a_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_e7045a3b8dec408488cdbe86aaaabef8_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_3831762010fb41d79493013bf53d3aa9_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_74ebce2a64f544dba2c55eeb1d5a8ecb_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_08f90fac92bc4c1a946c46cc943ed570_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_778b24afa1a348959c2ef86a78976f3c_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_640f21317d884f75819850d87cfe7bb3_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_b4cb58708c6f49fb8978596f7e1edffb_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_589a112fc7594cc58cb956af9f91f128_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_62ab467c590d4229815d2ac319372bf9_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_8fcdeaa2f01649dd93075737da83e0aa_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_cdb68dc1550f44afbcb7f6998594ec3a_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_0fb00d96a144496ea7a67a34868a0eee_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_e41487e306a94a1e83521f58bc0fe6c7_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_a6559d7218ea4411bd4d272fd3180a56_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_03d844b25ab94febb99440705cec422c_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_05621f65e1a04c2f93e3f99a14fc4398_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_21e9fc4f16034f20abafa2cd930bbd3d_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_107fe366e61a409bacf3b80d3eeb3416_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_22fa9054e74643cab0b38e5047fd55e3_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_9bc244ec7558420a840db9cd165c8a2c_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_d0e991e481244d2e86e774600c8f7dad_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_4be870a04bbe41d8bcae2c98bd75a14f_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_caf8dfc1e775436388140e44a1b0a2af_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_4865e81eea9a4ef48b6fed8f1d0915dd_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_08ae4681161c4ef6837986406ef65d07_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_9b3bdb8ea08c4a2dac6314eeba283107_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_02ee6b66ba6d43aab9f1078edaa583ff_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_bea62ff0465b40658dd117f6f5207a49_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_c17ddbfe44d04558a54a3042253da87c_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_65698865c6b34bf1addce1d014883042_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_143ec36eebfd4c39b6753d34492f1833_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_d9f2b2a29fd84e3bbe14552f79cd723c_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_4ca3a957e67e445183c963ab9973d4fe_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_21d10118692a4f32831f24adf0c0f97f_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_6702c2dc5793470e8fa77487f9584802_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_b72e46a94af645e8b8fdffb57810bf3e_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_45d1aaf440254911b7e35f4b55838a1c_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_a57a1805d8e040bfbfd154db332fcc44_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_43fe5cfe5bb34d71a23dc61300c12c0c_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_64c7fa392be148f1877678254b710594_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_1ad28e69e47541e1826ea23d03369e9e_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_290e57fb2c0b4767b59a7f04daf566c6_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_9844267a3119476283c0b546b60a729d_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_93dd74af5ea9440eafd8082d706a0dc6_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_0a1d9bafcb93405ebaadc037f445d6c8_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_abcc56086e9546899a72594f0f3505c9_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_c9a40cdbd44640cdbf091e430d79e3c7_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_1b5e461cfd604114997dbfb68fde144c_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_1d29813019ee44e1998b15beaafc6fe0_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_26ae9d455b0449c991aa0abeb572f116_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_1dc577a53ab44106b752ad6c142ac718_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_fab70d748bf54c6f8473da68e27560fa_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_672bc484b72d4236843456b1d4442d2c_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_b2e4ad691f47478aaff12c74f05688be_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_eb0b28e896c74707a2106d28c806e0f8_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_aa27356287794644b20a5d71442651f4_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_3aabe8a15fb040a288937e5acaccb78a_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_3fc81f4bb29a4fb1aa03082da6d4ca7b_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_1786414b2bef453fb648ae063caeb9ff_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_3544e6f957fb4a089477cdc7d80df293_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_ea97ca5544cf410da8fed118c40228a3_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_e1357baa548e476a8ef91aaa84ebe6f8_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_bfb99d7ba56f4d1e837eb0c71b678777_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_89de98bfb77548a9abe5f439a780ab5e_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_1799129833a64630b7c82a68a66364c6_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_af3cf71610ec4456972eae841f605114_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_2ed4c4aee375430ab7b3e9ccce06386d_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_a9ab3388870842f8a6bef4f05140cacd_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_8eee199775ed498e8683b76b6640de16_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_be1a3d7f14464b33acd051576af2bfd1_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_c7af130dc9a749cbbae66bce3f2c71b6_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_430a635834d444ea8f007f2379401cff_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_ded2660f05cf4b71810cfa2df0ad5125_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_e599c2134bc64a5db4ceaa1dbb6bdd87_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_5f87fbddffd141b48174497c0e9a7753_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_507e306d88ea4c8c9f38e6e6986c0dcc_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_2b78c952cc1b4394afa1d1cb45db96f2_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_631db14a7f2b415493af1de7de43f5ac_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_3ddfe3d0915f475b8b0e716d2f4088d3_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_8bf3a3ad300144aeab9dd772ca2b3181_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_68b097dcf95d4e1c9bed4ddde4d004ea_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_523098108c1943b4af2b9d5d5017d895_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_0de7f5de36684a3b81132a28e65bbc91_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_ae4b93643c0a41999dc4def8f56609d3_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_b8f16102e7304ccdaac8331416523135_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_7e7768d0c1344620a65c33341c391f94_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_3d70d41e4d7b47599d4bb0976a8ab966_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_9cc8df8d0b2447538d2c67070ba9ac4b_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_6383a45ee0034ffe91a231d54ceebd3a_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_07928b24d643454986b0740a10f35a16_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_86848a936464472d975226d0d134c50b_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_5a06246c42b74b2495f8b9c80206616d_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_754f41e6dc10420a8fd5c13b902123b9_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_1ff9a46ac986493cb033aea7de3752b7_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_995cb7376c5149b2bb59f6db1dde96fc_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_37a342947e354bc3bb7f6ca9647bd12f_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalytics")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_3cf3f4f45cc5425c91a8cdcafc368f99_Test()
        {
            var parameters = new KinesisAnalyticsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisAnalyticsEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}