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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.AutoScalingPlans.Endpoints;
using Amazon.AutoScalingPlans.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class AutoScalingPlansEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_41d8c891bac04305bcc8e4bba63ba8d7_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_c8c87ea15a33445d93d6839d4a4e4168_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_1ce737a1889c41a7b2799a7c99c699e0_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_6208bc21b3bc4e16b0042d8e1dba179f_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_5d5c45adc3f84c3fb2fdeec9525962da_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_a166ec1a3ae34da49d626451d4898066_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_cb0a8f43dbc0400fbd4c480132eeab10_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_6884c8cd9c384f9eb444ba3f575f716d_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_36ff9c3cf2a948a9aa9961777bc4a92a_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_bde6c1be54294b8c9c9a1dc8f896b239_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_450c704d3f4445538742f6a31413c5cf_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_3a5e68ef6469490092b01a942ea65127_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_502ba32550264cd9b3bde7f31375e1f2_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_9336dcb8823641c0973532a51fa9b9b2_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_98d456587fc6414e81562ff04523a962_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_6418ca7ccb834f7a9684f80a3fe0f799_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_ebc1bc2220ba4494ae772e075f25e2fc_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_2f819e90361b46ed8f7ea8ee42f13cc9_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_bbcb2f738a8a4aac8412c76dc7ef0ade_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_f8412a718fb54763bd7ebffcba6c82b1_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_0c11831d14d44bf5a40cd59088ad72de_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_45c7614385b84a5c96fa7c0ddd1e3154_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_586b3cbdd194421a98a912106f976145_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_3062bf603de644eaa138626891843766_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_5f7dccdba423460188a4aaf3b14d8338_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_d399b0e7fda743ca96b0e70766944826_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_990a79a74c9a4d56bbb4a1d27cc0bd87_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_45fdaed260874f46abca4ffff2cef10a_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_518011bcaa3a448f84e44aa958fbb507_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_45540b039aa84dfe978bf1b18db348f7_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_c81fb04569844329b017a700fe5e3272_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_550061ca2f4840f999c0521835e0a743_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_d502a14aece14e93ba80ddd7f03375df_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_9df39c9b262046d59e32e7e52945007a_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_5f3c57e2ec624377aa087756e6ec593b_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_efba243cc7fa4b6b80596066eb64d749_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_c03289c58cea4bd184be74ded77531a6_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_2a68c05b44ec4906b5e58b8806cdb64a_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_afd3812b6e3b49b49adb5cbc1424853c_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_0264fb45909a4477ab9282750215d951_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_4b9bb49c7e754246a2a98ce811a3fd51_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_448713f0554e4c09b1dde427c10754c9_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_7e971d382ea345edba908c4a17217b68_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_536d7c044cc641d9844368be2da4597a_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_37214b73d8e248338df82718d37a015f_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_64fd8fc9e7b640b790a2bf277b22c661_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_c54f55777aae41479f759a406d2d33b0_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_08304a243232486ab058ce6f6e0cdf14_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_767c4301e2b54eed91fb01352407cd2f_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_72e69b4daffa4f29a69432b24277ceb1_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_31b77df03bb34f5b97fc725402b2ecee_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_dd8deb38849b480d8c58fe0e0e5590d0_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_c186d268de114a03ab9a4db6619de559_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_66402195e49344f5ad8d218b3e539c2b_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_e6a6ba9aaa6c41d7b477af6482bb8215_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_ee1f79d384da47bbb9e60caaa833a878_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_c16580e3cafd4ca0abc8f2f3877894f8_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_bb3465bceecc411e8a40c41440c90691_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_32ce5bf5b5c84b8ebe8489fe9510970f_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_f500d41c81e34bb8ba1ce5472de99558_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_3515ba65a48f4a3db722b9a0da7967c2_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_6dff8a74d6e34ba081881468b78ae513_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_1860f6b4dfa547c98f4b1706a27f668f_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_ce10121cc5b74b3da89ff8ce72df2548_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_ddcbb738f9084060aad08c65000e464b_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_d8cb53c199e54b7a8ff19e6bf6cd9108_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_62035ef3c783452fbcc37ad97ebfe103_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_ec316166275c4d918a6f9b5f33fb40fc_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_fba73f29829e4844a5b6580113695932_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_db5d7eb5f7784bac8022990c39fd84f0_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_460f3dcc70534148820db7682a49b6b3_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_f9834792e0374b7884dd8b87416417f1_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_85a62c7deb744fe8b9223b60bfd5775d_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_082c4250e14f42be87140f9734278993_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_994c2b63899040c89e6e2fc79e3c45eb_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_c968dbbea3414c1aafd0a0c55070c041_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_f292b1c4aa4240e787bed65d6bd21e1d_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_d2b279308e544d1d876f6dff2bc4312c_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_3092b2dda3db4716b3209ed74d3456fe_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_855f965a48e44f00b31ce1053e7a4771_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_4dd10cf56fe1411ab02235a46a25eb1a_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_0779303ccdb94e5c94c30eb20cf6c17a_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_1151f00fbd2b46e5af1478237927e079_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_7ca9cc46780840a48ac5f75759504c72_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_9803a04d43184df390c0c1c9388bd950_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_11c6b791d5aa44ff9c2861f7a5e0edaa_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_7183f67f02aa473e94412fb2614791c6_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_c91f18f43450429f940421a00bc10d10_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_47f9812b51314caf98bc6c401ed0ed04_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_5e50a71b33a24c00831eb0f116c6a7af_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_d457c9f0588a4456ab343882dcc69282_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_2068c57e560b43f09dc928995ad224e2_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_1209b717767047998018e4b704929e8f_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_8abc395e4261466aae4a31abd6eac8b4_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_1e267c61f7d140fa9adfa2d157dc472b_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_b8c1bf73832c49ad830a601198e835d3_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_5cf80e779776401a960d5942f8b561ef_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_60b0dad39e214891bef2f9237d934699_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_926af892a85d4cbabd1a0e56bef20a0c_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_edbb0464e1a54677bb61c612e3e9fb95_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_29ebd8b9463c44c584ca54a457c147aa_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_933251b843084c25852364a331a94f81_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_c67f0c0a62934825b727f77b2fee56b5_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_5cd82828929547ea8ce450fd838e88a6_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://autoscaling-plans.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_7107fb8f22cd45c389ce98ddfc09096c_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_43b20d4bc12243bcb873dc60075856d7_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AutoScalingPlans")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_1384cdcd9ea74bf6b76e2a30e888ca12_Test()
        {
            var parameters = new AutoScalingPlansEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAutoScalingPlansEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}