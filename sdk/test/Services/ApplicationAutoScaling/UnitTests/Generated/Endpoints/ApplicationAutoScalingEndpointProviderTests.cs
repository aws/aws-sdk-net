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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ApplicationAutoScaling.Endpoints;
using Amazon.ApplicationAutoScaling.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ApplicationAutoScalingEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_8b13c8cfbae143819db077f7ba0db25a_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_33c3acfdb59d4e30a412788066805404_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_1a8e7d5acc49415fa9b33e95703944f4_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_9413dcc254884d27b7a8665504aa07db_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_f1f72718c9d54ee984372a74071a6d54_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_21cc68c48ce344dfa7edbce0c1d76c09_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_74b473515d9c4461ae8fcc686e40e35c_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_370915f915024e0fb5923f00c7a53884_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_3cc4a6a8e0b148f786cd012854d51060_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_d4bc85614b414e07b7ada8a6dde40125_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_7e16e4ec40a64705a3691b242822961b_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_eba772e042fd4e43a0bda13dd1354dd6_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_75833a5ee87e40149daf3283a37d3de7_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_cacc9a72221f4c879174dc79c8b5c679_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_7dae729fbc6a42b786c1edd19dd74a3f_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_7f3e848133214087b16b9dcc11d62a0a_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_afe026cfce6a4c7bab1f2f899f4c6ad1_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_1762ff2a26a74b2d87b962481d2ccc2f_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_276173e4435d4df5b9901028d7532cde_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_f9661f05f0db4467bd3d5a2af07cd3d9_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_a9a53e458f134538a434068813106ba5_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_5eb2f76cf0b547f2a86cb35c99af68fc_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_b10744da74044e22b671f75ee49c855e_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_c599e067fd2645f28ebee902a1201b4d_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_9611cc22fe4e426b8bb1803a4b7ea7f1_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_abbe9b2d6f124a3393e653ead5b6fa97_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_832fd410c1494a29ac6c9f8a2e60b858_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_fcd7f4b5222341b48c7c691a52ef83ee_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_2271edd7eba34d098876760f8fa87b08_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_7b19ef8d35eb4e50a5e129310eea4c45_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_3051b2a1240a4d2481e0c805046b4062_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_9f9e00b1a9374795af28d3448af5dbce_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_7f0a72059319405ca5e4ad2e5c932cb2_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_200a5939bc7a45248d257737156e413b_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_8888b50ab7a24e328c7ae9b3185f8aad_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_136b71ba710347f8a440ada1725086a3_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_70e36840b31c40e29c863edb302d046c_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_bc06269cb8484332b91684a2d75af684_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_e7f91773f38e436baa402e8fee07c308_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_5e48780d7cbe4b85b7e0617ef8ea5a6d_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_45185fbea3ee44678c66a18d074cfbf2_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_79dafff9a0b7489d939747a30d2db461_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_b26273f26cc8489a8656dc42e7591062_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_4f3a2d41a71f499eb200708b06b431d2_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_5ad58967955648d787045126ead2fceb_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_8d98b0b8770440b19b20d250281137d4_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_03e65d713b01406199d1f9d6cefaa0bc_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_323f4e98716b469e83cb8bbe55eeedf9_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-isob-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobwest1_with_FIPS_enabled_and_DualStack_enabled_9daf8e53aecd4ef7b437a8ba3623e8af_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-isob-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-isob-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobwest1_with_FIPS_enabled_and_DualStack_disabled_b450efe56d5947c59efd2ff6e27deba5_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-isob-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.us-isob-west-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-isob-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobwest1_with_FIPS_disabled_and_DualStack_enabled_d23875dc3091436d998591369aacb6b7_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-isob-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-isob-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobwest1_with_FIPS_disabled_and_DualStack_disabled_dff2a4af32f04112a35dc38f58eff5dd_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-isob-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.us-isob-west-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_333e356318e94630be19cf44d06a7a83_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_0b8c68d446e74302a73db032282a2517_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_c7bcb2e1e649419f8c1ef7c9992e355f_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_20430e8ca8df4737a091c67533f73bd8_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_541901c435cb4afc91379beafc7cdfae_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_9ab34f63d72c4b088a66366c2c6ce793_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_c8da8b411e644c9b9055731d83f37fb0_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_f77132865b6d4b1eb05d1fa0ecdbe4b5_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_b2768cb72425462da1f33e28229bc1a7_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_af21115dc5e64287a8958c103b188a9b_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_43b89f19473e467dbb851e544bed5525_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_19597a64d54444d58891b187900c71c5_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_efd232129b5a421e911ba1c5018e5649_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_16fbec7e45c74f8e9dbda38d845de7f6_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_19161d8752dd411fb9add6ddfe42e3e0_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_d5d872b5cf6543129f79acb63ea09be5_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_4dcc31b5004f44a6acb3f45129c097b9_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_c6b1fb4719454edc876bbce8718368ba_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_261089453e574b33b4a5555a01aecd5e_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_b435fecc25744b8a8d37f3ffc76a9b17_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_8958cdfe5b974d80b9b53f2e6a40627d_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_f51bc99471ef4345b85c29d60a875d42_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_8e9e81da354f412ea1d4cc66d404cdf4_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_8b053c6a11dc4c939f2990acc4536289_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_87b5fcc38bad4834afc4828216cc33dc_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_aad7d56a82de4688b5aa2fe6ebc18920_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_fb068d4027db46e99e03b22208ee7dea_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_6cb554fabc9544e99d0949a4bb0e7fdb_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_38090df7c8fe405081c251faa63b4e61_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_ff63470e59f249f389edaedc9b90647b_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_e2433f3b84bc457fb2cea3d444a04e49_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_55a7b014adf44a5ca95d7ff0cc09e55c_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_ca217b63332f4d2a8bd150acb44ce0d5_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_2fc5cb8901e04e16960a590cb89ecbaa_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_ca32d181e5684849b390deb2c243cdf1_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_dc1439d4fb5140aeaa7b62b05d4a37d0_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_cb962d7da5b44f59ae542b49bbad47f9_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_194cda9f61a747e2a2686dd52bdbc0b9_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_ad8fe96b139c479bb535f8ae78f4c783_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_0271a8c548ac43bb8d59e23a7e2a861b_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_27cfdcc08806494699d6f39fdb68af5f_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_91ecfefaf1b84f19aa2b17e9258b4898_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_9bb3e75e9c354c3ebdb67d2198824ee9_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_2ee0800f9e3b4b0d8636db366db7ba5f_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_0eee8c6720bf4163b3b2f6108cedfb92_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_9fca228c99ba431a8dfd87eb267cc58e_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_dc76cb034c7549b686a5239a92d6ee7d_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_154ca5ee6c5d435f8ed8bab64b923113_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ca-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cawest1_with_FIPS_enabled_and_DualStack_enabled_79b07592d44f4fc4907c805de2981aba_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ca-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ca-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cawest1_with_FIPS_enabled_and_DualStack_disabled_bc67386b3107419bbd20a5b4110c1eb4_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ca-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ca-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cawest1_with_FIPS_disabled_and_DualStack_enabled_b26dd9e3ef5e4ad1aa9c1cba93988c00_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ca-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ca-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cawest1_with_FIPS_disabled_and_DualStack_disabled_81af23ce626e45b7b5878adbfc654274_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ca-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_ef5b11d0ba8843b1873b5a3df73197d5_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_4df7dabadf054fe89000ac4d46d8e4ed_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_e96f9fa97e6e4d04b4c29a93ec3e75cf_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_b0180e29ad8a40f7ba22b8d2aaa276ae_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_42c7a3a6f2ac40ca9160224762a465bc_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_9bc062c1f05145199cee9912fc896387_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_aacf1657491a48ad9914d11ca8f6fa81_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_5068e4fc634740738088cee08987cb4c_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_7b57b1ef58b345ecb1236cdbdfb3bf36_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_f48d8f7628084d70a0414bfb82cd26b3_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_95417848272d450ca04a846f9be471d3_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_86a78a0ae6044788883ce81d9d9d50fa_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_63b118658e264a4497e42f1c2037f6c9_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_a4f9f48d19fb47659fea5851e57e7f11_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_91f31ccc5e1e42769f674851450de1d5_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_ef2b831b103e4818b1213f34e68142d4_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_dda4e34febdd4d1eb8e4a0b871767019_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_b9476c5716424de69e8ae6f70c17c26e_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_63a69828f94d404d9101f772537f55a6_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_30ca295983ff4bc1880b1bff13e41fc7_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_enabled_6921bea5744d4dd98f162c92a792f921_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_disabled_566128c02cfb4d44a11de076261abb11_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_enabled_8a35db89207e461696eda4674e40fb16_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_disabled_2b4edf13449948cbbe995c11dca4577d_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-5 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast5_with_FIPS_enabled_and_DualStack_enabled_688b5b1e44c640a0bdeaa7662a098d4f_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-5";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-southeast-5.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-5 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast5_with_FIPS_enabled_and_DualStack_disabled_adce2f933255454790d6a1ed4326db71_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-5";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-southeast-5.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-5 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast5_with_FIPS_disabled_and_DualStack_enabled_3add034b17174dfcb1dbe199317c5b9a_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-5";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-southeast-5.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-5 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast5_with_FIPS_disabled_and_DualStack_disabled_295ad1fcb18e4f178a221d102c0c86a4_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-5";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-southeast-5.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_3188e5cb209146139bde586e88730fe3_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_af4c18cafe8345138c45ef107e4f53bc_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_844cf03d201e40aab193198fa6fb27f7_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_ca053d64433b4630ae3fcedc188ae573_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-6 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast6_with_FIPS_enabled_and_DualStack_enabled_3ff63d791ce24a499356e1e6af01f9e3_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-6";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-southeast-6.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-6 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast6_with_FIPS_enabled_and_DualStack_disabled_9105bda3f617485fae3f4c3335d4dc1e_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-6";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.ap-southeast-6.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-6 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast6_with_FIPS_disabled_and_DualStack_enabled_7aa8123c95c348e69f9a3b97fd6656f1_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-6";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-southeast-6.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region ap-southeast-6 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast6_with_FIPS_disabled_and_DualStack_disabled_e38662fcedb84504bab18d737a0b5fa1_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "ap-southeast-6";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.ap-southeast-6.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_60962bb6a64c4aafaa178e7159b5f0c5_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_64ee18c0a7644aa8a03f4191e724d3a5_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_9556d6cc98664ef2a4efd97a418067cd_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_561d327d7892422f8503a1530e852c81_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_22a1bc63d1ec4c3b853224427dc0e52e_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_a4b05495781f46e7b06f6b5596ad94ce_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_7a17f75c0f9c40c29eef19d0b7fc800f_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_6f3bb46977fb492195af123bbbcabefa_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_7411882a35f9415a83595515237d161c_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_23cbca7f365b4e6689f3780ffb30607e_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_b1ab097265994349bbc3d414d0492c49_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_cb75c42188364e028ddd553fa5d6fd41_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://application-autoscaling.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_50be3413576a47edb91ebf610ea91245_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_9d65cccff9b34c98813388a3bc7cba2f_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationAutoScaling")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_0425227086ba46209a169b46059da85e_Test()
        {
            var parameters = new ApplicationAutoScalingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonApplicationAutoScalingEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}