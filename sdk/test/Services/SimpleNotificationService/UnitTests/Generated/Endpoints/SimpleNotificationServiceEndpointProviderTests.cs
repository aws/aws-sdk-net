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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.SimpleNotificationService.Endpoints;
using Amazon.SimpleNotificationService.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class SimpleNotificationServiceEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_01656d1dbe2c46e7a728f223e1a23cde_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_8ac53edb5cab4471a8667eb8e6d94b80_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_6842b540e38d45b29f8279716d1f21e2_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_e0bfa2758152470eb617c5527371efdf_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_93f8dce7ede4482882b230eb27732388_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_4326b9b2a6cb489fbbfc96330b774e6d_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_b4203d7d33524d4ca841e286b0c03f6b_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_3db651ff388b41af93c3ec660e485365_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_5531ac046ce0403b8d9a08e66572e256_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_b59084e29255471eb326e27907dcc9f8_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_8b20952ddee549679a2313412202ab80_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_a51ef7311b1a41a2b6190424b161c83d_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_57bd744482ec46dc8c53162f66a3648b_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_cd6baa857f994be7a034b2ad1cb1b6c7_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_6218f643196141bc810c7296b655a792_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_5e226b3d115e420bbae000091e3a3777_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_4abba15a23674d089c24a825e3ed585a_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_e6cb2128ecc94809baa1cd8490bbe18d_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_aca5266be65c44d09cda41695d5835cf_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_59cd9c11869d46d690546695354ebd6d_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_584b2322cd574fc49f8f0e5f9f718760_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_e8da1e24999a4ed3a30b10e15647b092_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_29bc29f8222c457bac20942ab51d0807_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_0868e3c46dac43a4a0463e1ebbe75bc9_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_e8da1d4be0b94385aa9af7c6b58d2185_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_30be2a42d61049b6bcc03535c3909aab_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_69cba833902c41f8a4e964b96fa929eb_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_9c51a7a1169542349b85ca50bbf677d8_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_ba14e51124ec4d1a858180e8c23cd7f5_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_a6c55e47421a48328a5fab4012ecfbb8_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_7bb257d8c1424b919b4c980fdc88ca17_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_f5da9600d16849bb892fced0ceefc160_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_2125866687874a93ad0928d62b952847_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_444ed5d6dbb24511abd105e0ed35fa28_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_b2e257e7555a4ae0a4e026c4754cd51c_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_0aa03ff0aa454cd3a5d062faee7bcae8_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_f59796110dc74fcb8474569f66881ee3_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_79ae0d3354f142be8566875c9456f2bd_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_5925c152450146288264601629df81cd_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_c1879eaa39484254bc569a34b6968047_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_48963cec494149ce86e9b7eb56d31b37_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_60ec8a7ac69544f296a37339bef87953_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_3da39ea255314400baa1edd9b0da3c01_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_9b50e491a218440bafcdb9683b222b15_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_ba12499a01aa45739f3ee02922d6a028_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_91d318e54de34236834a2fd453f59852_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_ff60234d9127420397ee7a04c370a3ce_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_312239f198094f1f9fc572b4a77f942a_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_3ab8ae04446040998dbd08717f4534f6_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_97c7d1eb540541738fb08f0788e5bbc8_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_5c4ac240511d4ebc9ca73c5d75ee5174_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_1b7c76c97b5e42a8b93b6e66ca67b846_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_3cffb196b24e4f7f9326c7c015c68262_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_d31dd593ee4945eaaf61c06321ca5c67_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_6ebdb39abc104a9084237754e4686b0a_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_454f6f8a954a4819b9c05ca133f2375e_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_b1341bbb8c9243ba875c6415d5f1ec74_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_74ec3242734644f79ac6ee99fdc3be9d_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_ff776e89835f4c73b0650b6d78e148d4_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_96b1aa5d35a94c919ef9088d6f4a1950_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_2f7ff828e007483e8d54d63b04fcf578_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_94bdf3b3e5454d3ba4b773b1815d24b7_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_28303325ca2b4018a5923528ca3cc293_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_d2a65abcb56c4c668cc8007f30d56571_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_846138d19de94a0399419abdabfa01d1_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_31ed7606a3ea47589218372b51ca1736_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_ec1921238c274d1db32464cc0395ba1d_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_4f7a3ec68347409cae37a7b1985aab00_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_4daf1a3d138a422994ecf367a7b30d0b_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_927fe8ac5baf47e8ab73a0524b4acf39_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_7b8eac1baa134a2da6bc9905d901613f_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_659b15a82fa04e158406ba081044f632_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_e168a30c5f094082a4f4f47285b617a2_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_7247ec26f8a447f986f5dda5d02fd21d_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_a5fe0747818b4e2d966463b62a24e701_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_4d87eb524f67409093d31d3e46137b66_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_0a50f017957b4768990258a194518e87_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_6ba01f2879ed4cd0863e5e6628780c33_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_cf49ee60ebee4d9bab674170aa3ae36d_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_559e79bb77c540ae931f53f244712367_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_a7abc42f590f460cb47db472f69e596c_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_5e3da58679114a2f93c11215f81313ef_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_83bf0e9df72b4ebca4794700fed15fb0_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_875a4aab7cbf43ee8a91e054d42dbe6c_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_3f43c74a405b4368a1303018d3d443e5_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_e1c5203454134637a7051cff1521dad1_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_71d44f390aa54dc0b340f5bdbf838fa5_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_0bf5ef416d3b47f78919fe84a55e7328_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_9765bfb5bec24b72af721b23683599de_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_75a08d3c7e3d4f01a19efaca6c890864_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_60884a183c7e40b9b2c6e1859124b673_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_6a33d970e53d42ef8f0cdf051023c7f5_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_f1f83ca7436b426180ce29ba2aed1170_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_c62441e24a7742cc94399985849be794_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_d2a4b00547854bf097724a1d06a2ac7f_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_dc2fd99a129345c3962f51bbcf45ea8f_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_771d9f9a72754d0da16203292c770fe4_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_1b7bcde861db42a9a8fb43688018a23d_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_15050b2d8d224845b80581c2e83a6454_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_f934f3d106684de78b4e56d98212c717_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_bdb519410a5a41e5a3147110f436e7d8_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_b7c361c331e0400eb8756e94f241ed8e_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_bd1a7e6df27942cab8a2ae899073ba75_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_ea8595bd91d54f90aee29993d9c05198_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_7314ed06330446419f3443886ee78bd6_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_ddf0eb44518346fbaee9178d936978ea_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_85bf73a8009e40e9a8cc58c669f7cf43_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_b77672c389414eb3a237663686605dcd_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_8982d46925c34d7a9a5d06a97a1ec878_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_e2f3d6132cef4285854230c1852c2874_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_1b4932e6494c42b2ae23e1e59a6211bd_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_c56d40ddb5db4c93b1111b6556604eec_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_ad3aff8baedd46db94d47148c47c4de3_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_6083024b670b40b7bf95eaa685524826_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_f44df3eb42f248f998f5ebe7662e6749_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_7fb526bcbcec439e8da6f3f308d9af5b_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_enabled_93163765ccd248bd9b5b93712187b9e7_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_disabled_dd5975746dbf45e39f0e2b36f9b43fb0_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_enabled_31c69e5443a64888add6acc0ffe361e1_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_disabled_8d7dcd0bb3ce4f1ea0dda0d4e8192a9e_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_b1dc6206db9e42e8a341abe0ab7e0794_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_bf7d2179ba6940c9ae7041054b199a41_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_572f16536fe34769a2192f4ca2a10dab_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_3fa1f3e8b7954e5a82a00e42b0af5491_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_dda5408752244a7f9477e25678786fc0_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_c119298466294ee18b8e33559a0da7b2_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_8285680d7cb84e0bac3a73e8a71f65b1_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_ba80e64a53e04db58c677bd4a50e9b7f_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_92d1f6f890444d6bb4d4425bd139c5c0_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_437e9e5616a64843abf962ceec65e06c_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_773fb5350aae48ab9af65bcd667f55bb_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_5ec3afbf947f4983b50746d2e31bf529_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_58dac58da5184a26b6033d5b0e3eced1_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_47516fd513184bf3ac3ef0cfa070f7af_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_d4534415a5db4d71bacb6e7bac8e6b20_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_301dececeb2f4813bc4dc7f3544484b2_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sns.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_a66f60d42cf749c59281dae895fe3c20_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_ec14b2e6481f483cad7d8234b1f73928_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SimpleNotificationService")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_5a8424622b654d6bbce60bd46b705c64_Test()
        {
            var parameters = new SimpleNotificationServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSimpleNotificationServiceEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}