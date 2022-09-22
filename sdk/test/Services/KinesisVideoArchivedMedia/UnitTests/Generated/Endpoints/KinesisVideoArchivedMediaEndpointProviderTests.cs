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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.KinesisVideoArchivedMedia.Endpoints;
using Amazon.KinesisVideoArchivedMedia.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class KinesisVideoArchivedMediaEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_5d93a3897ff94cbbb35116ad22c82219_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_50501acc27dd4b4e9bc8f12d093cc10c_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_dad83544a872469a86c79dd0d2a6c342_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_b0f90d092d854fc498989386c86f9d6a_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_f3fb812162db4c2ca530dc99abc977f5_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_dc560df3ab6940e5b22aa1e2368d6cc8_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_8a5bb42adede44efa9b6735775c2cdc1_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_bd3e8cebd7ef4166a13737461dfe46bd_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_3f8d8b4b5e9b43a8b47dc6619890c866_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_a7fd6b99b4b34500b59d245cac765adb_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_845aad07b1d0483b97072d8e27b8f5cf_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_b2ea9418ca0c407683c4095409bec1e3_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_2ebd1762d5c94a359a1a2c5855b46641_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_3636cfb200764b4f9a550591704eef19_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_473b5501d81f44d2a5f2ad0ef45f654a_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_366e7630ae7942079b0d925733bbfc5a_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_56041633d770471785c272f1cc0c5939_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_5ddddb86984347fab29c9491097b1191_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_b8d5fe5ddcae43c09fde50bb1b76107f_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_1bcee4bd3ff943f48793e0aa5ce262fb_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_6f02353eb04f4e3c94af8bc4721f8bd1_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_c2114da0cb484bf3b1cc193b026b4e14_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_4d5402f4bb3346fb9b155d810f7a46c8_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_edf5d753a4214497a1026a7eb247fbee_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_c1bb7c40853a444c8a68147fccaa98c9_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_b546b944ff0b459287e1130e5324fdbf_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_4c608f93714144b38d6f7398cecba5b1_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_beed484d13cd4ff783a2b5280dfcd377_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_0fda95e49ec94f5cb35e55c4d3716824_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_0d040711a6d04777b502c6876c7aeb6e_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_70eb145cf8a9423cbcd8dadb062fc7ef_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_9520de03afb746229b66c8d616872347_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_f04c545dba0a491fa4215eb3eb9bcae2_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_97d66a5987ec43349670659ed388df16_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_10f8c6dfdd164a15903ef99848dc0d4a_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_0a5f6930a5ea4b4dafbb21aeca2521cc_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_a307e42ba99d4522bdd2a3afccc0fcde_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_c5c68ac588cc4f6bbe05324fd090d973_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_70c11c1bce1243d396a86f6a2a2e54b3_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_e66d19a917df4803b2752c3f46e5b314_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_41d4c2a8623849788480da9a4b0e4fb0_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_e8d1c2bdcbf54c97b4205bc64cda8b57_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_61e15bf85bca490182879ac723b73c72_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_3cd9dfd1945647ed8d06a8c2d082a54e_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_0e9b0f1f38fd40d491973c4bfece048e_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_de5e5d23656e48b3bfaad78352282711_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_84e5f72157714ff49224ad8d079974a5_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_4ff520842086439a97a34cfb186e4547_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_b3235b5458234e5b9d512f4cd01418b0_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_9ce50b875335463d80c37b39dad20e29_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_fe565d06c5594790a3b117887563c177_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_e1c89f0977a048c890b236b80368af42_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_fd82434fc4984af29e506bab37578390_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_cf6349582acf44a69f721e3fba22c209_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_fc6eb887048f4b519268807b1cc3e09e_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_78b01bfe87a6405fb359bb43bbf01afd_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_f44ab16c7e9a4ee28091dfc1433d1035_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_0e6db11834b843819a13bc30a3b47200_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_0f227e7d87be4ff7b4c673503dd19bde_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_5d3e58d224ff46429b56524418123028_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_b376872f7f2d4c1ca4caded0085aa858_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_34060ee1fb77445baf744263579ecc6b_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_1ff26f7aa46747898b76220bb5948914_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_c24bc7e47b3b4d33ab3203b4458f25ec_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_c844d81aba244f0b845367ca1501c2f1_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_843a22ffe5704b94a90d2bff611dd6ff_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_d8323795b1c743d68ba475e910f74c4b_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_e22fff573c834a7a91c5f77fdee5b37d_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_cf0cda7b524d4b0d8fa87f6c7df06f0d_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_2dfc4362a86e412ca85a01b099b23555_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_fc0c5aa1cb004acf91fe723c6793fe29_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_c70892caeaad4852aa4e90f0b2adf814_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_06240e04f6d64986a5f0873dfd21a02a_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_223e3f8d395f4c61954791379dfbe4a3_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_84402189f40c4e6daf8b7075c8d18310_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_6389e584d48b421f81c6ecf47c5d9003_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_30489c2b9c044e68a9fc09a204f47e9d_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_50a13785609845eb99660d73944afa29_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_079a74d57d50401592a072678ea45b90_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_3aa42cbfccc245c794c8fe62a307461e_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_e0e8c45bd45e477e89c2fb3354fc3105_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_3b8a1b13d0744021b52448d8a5a538f4_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_52bdf21ae8184a45bdcf3871e4ddb8aa_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_cbd6c0a76b21476eb987401ac519c0ad_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_f7d54e4e63574f94a0a3718fbcc721f0_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_49d744818a054212aa000eb10c311ee2_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_61da03f51ba949c2a03c546ca04f7feb_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_a708bc860cfc4fed985bf34b13b227a1_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_eff475f29bf24055a63202f70cc36379_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_1d8b4f055fcf4771b5f3a5b3d11dc1da_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_8832a9b8b52c4fd386c2b3b469f6df5b_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_eca36cf36eee420b872620c925a41e8d_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_3a3346b49a40416e9b8b34b3651dc669_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_6afe0858331c4686a38529117235893d_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_3905034c7d2c4699b007f70012c44959_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_e5bd16db6d5a4ad183ed67c46f3ba20f_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_5b3daa2257c54bb58ddfbe872b3001d6_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_0567a11a283b4d9283154edf04737521_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoArchivedMedia")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_f3f8ac547b664c29b5c93c8f98f57391_Test()
        {
            var parameters = new KinesisVideoArchivedMediaEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisVideoArchivedMediaEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}