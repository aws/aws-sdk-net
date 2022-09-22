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
 * Do not modify this file. This file is generated from the kinesis-video-signaling-2019-12-04.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.KinesisVideoSignalingChannels.Endpoints;
using Amazon.KinesisVideoSignalingChannels.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class KinesisVideoSignalingChannelsEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_0fd73ae500604dba831beb2ea85e10f7_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_22ed8274709343a1b9a319a1d9e32b11_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_ea36faf42ed34df7ad9420e5e1ea50f4_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_bfc78ef3663949a191242931c3106b51_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_2826d8d231c44e4894254c8d0d0b2488_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_704f92a2a83f46b4b42fc31fb54d99d5_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_838d116df25b495d989334558454a75f_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_a3740e0e08de430586bc4cf0a1e55cee_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_8f58e10ec3ea4f709f22c7d0ae9f83eb_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_905d06a900a841068621471be2d4093e_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_976531a340104b2398799d1f2aab5e32_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_259f9056a3b1454d88d03a96c05741bb_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_bceb2846cb65447ca8e5b926bc841120_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_232799e389ec443480e5dbf3f636e231_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_638e80b5d8194e598f12a0d2909c3ac4_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_dcf3340b1ee64064b7e6f0285d38e4b5_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_fc0c10de9b2f49808af2206e4eb02aac_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_dc34dc7e26cf4d7b80354674ab7830cb_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_047f33227f4f43e1b9727dc793abced5_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_517a451c9e5f40598122ea93b4d3142c_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_3437000cf280454c9f2da1502ae575ab_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_2a44da265f734ef4858a8d6d7ae2a1f7_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_ed4b7d3d929a4c59bba981d7b1651a2e_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_9fec96c76e39427bb9040000efb9ae57_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_d050812e71e842aca17039978d3cfb71_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_832349aa42fe4ccb8597ba885fdc3cf4_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_c7273352f4e440f2b2d160086960330b_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_f1487dd3d9664ad0afd0bc65de11d8e1_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_7ad77ebd7c7348ca9fc73e40d83d977b_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_e411b616be734dc9bbb1cb217023d337_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_7fc04ed5273143ea8085549c9b1f9e88_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_1b78d4bf0bb243959f4c0c2bfd672194_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_e55108686d7941d18a7f75fa3c3d2fa8_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_c6abcd16f40e4371908e25fe2d4ab6b4_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_7ab1035c42ea47c98babdb02e2cc1c2d_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_7fdb5e7d96c148f7bcfaece92872a68f_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_dfacc8b2607c487ca014015baef17016_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_9beeee7274da4d16bc82a4b2a7b6a144_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_6913adec815f4e6c8317df7394d663c2_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_8b5f9d34b3934438afb49ae66ef7820d_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_93c62abe5e474537b4dc88689be8e8be_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_1a7a5820dab44b5e8054eabd52d4992b_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_364c36dd16ef42d2a7cd63dd68b8ee29_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_da0b8e0af576430f9c4cea47c3c687bd_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_1bc495aead5d4980925c22f33987112a_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_cca26e8b3e7f442d9baa3a5bbed78ebd_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_301640ca6234478ab34192319169122c_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_df2e6a60958645d29a68711ce35a9d8d_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_9db0515a02384e97b0590c73566a7ddb_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_8fbc0469e68e4ded9a21bfa2da2d4c82_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_d726b729f9124b429e3bc7d49f3991a5_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_c880442dfa64440f9d5f8006e29aa8da_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_b4bd0968c615445091b86888dc0fbb26_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_f2c1b75cc050421c80b09f4060803126_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_3ac960999afc442d82771e8582ff9b60_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_ac006697aca644e4a056c7a8c46c7bb9_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_f9099af315fb4d0a9e11f47142f5dc0d_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_49c8f0dd99a24cae8c8341a5f887ac65_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_a7f0a3f9fd0642a1bb63efee2bd2c9b7_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_17d5ff9706a645b68326091c80bc1956_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_37faf5ff6ae2468fb78b39a3077ded1e_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_c4cfca62581f43f088d656fca22b5330_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_320d3ce93dd2410ea2823ddd4e3afe1b_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_76e7a34d2db6479092cf21bfc0118a2f_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_5e04bbfff6d246e1916fc1c0ecddc096_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_c1b0593da5ad4db79f5db6d4bd67007a_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_fe856f33c0ee40b9a348dadaf2241d8b_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_5352355da57d4df59a67cdedff2e6ba2_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_be3f6062c5cc4170a61cd5197b806e1e_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_47e1afd4ea434e8c8d421abf4d59d979_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_1ea8bba390814de3b2673c9bf3aeab0e_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_abae5fad2b304a638aa16769f0e59a53_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_0c689457581d4d31b70e6ed09b8487af_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_5f286bcd0ce74958930b116797cafeb4_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_0cbadac093454ddfb8e5933180adafa1_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_f6a3168995514d68aa674e7013cf6cd7_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_74deaf56207e4a05b85071d8a6778ff5_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_3188641193fd47108c99db4b0de5ed2f_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_fc6e8e7295a74f488c6cddef0f2bdf99_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_eeacc873b2d6485ca2a4b9c6c79cb9e3_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_ebf8ae54e25b4167a07972f646cfcdfb_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_88c9f9f89e5b4afc85c214bd0bf26039_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_ddd294a610f840559da64bf37f4e7114_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_95360787e9f44acdb6ed159bfc598636_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_62d4417af2094153bdcbf27fcdd15433_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_0034e8bdc8d84bd5bcab50094af79fa9_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_69f4f3cf8cc54954bbcd36f5d7b11f92_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_bcde1a41242841a6b6e8fbd8e5bf7fb2_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_87b0676f7d024b3ba156a54853a18df4_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_bc89d00955a141f7a5e490ed15c1653c_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_09dd020e8dcc4d0e84199e5ee6318d21_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_dec62d0d5ad44635877388766206646e_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_4cff0c9a7c8c4496b8d1c0bd39119b55_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_9dfeecd54d97490498d54a0620916aeb_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_7ab0e3fb632c431d8d7fb6725565c53c_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_9ec9b29dce79438397e9d7dc52c8eb7b_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_f452c301244540f6a03a3368f8e80d9f_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_a55d75b73f1d44f9a8992bb1989e480d_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoSignalingChannels")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_81bd98b0067246e7ac596858ca1cc973_Test()
        {
            var parameters = new KinesisVideoSignalingChannelsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisVideoSignalingChannelsEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}