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
 * Do not modify this file. This file is generated from the kinesis-video-media-2017-09-30.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.KinesisVideoMedia.Endpoints;
using Amazon.KinesisVideoMedia.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class KinesisVideoMediaEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_f36ce3b583ee421fb4858dbc64404dfc_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_813f4a8cf43649e39351bb833a805adc_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_66c0e8f346bf46d1b6a351565e5f6996_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_606f40ee491f44b98690570717f2f018_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_a12b197e4b314c1bae40848aef6c3858_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_5139ca399b094ac29af2827c6d4694a9_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_27b639b34ac945a0a1cfd385f506c28d_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_80cfdb927df047b2beeb46ea6d08f5d3_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_2d6079c0ef5f48f4967cd881a8e8a28c_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_4d51b64deb5e4425a3a1dbb1847a5d5b_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_7c0c10bf86bc459ba7abd2f63d331247_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_449c03226884446d86e65cc4d120fdb5_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_6ba1f3d2b4264302af0084e6d708118c_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_6213df81bc914a138591837cfd858553_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_8a7bb21251a64898bfe0a51195a4f46d_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_f4736eee004b4bccbd1b23f78f3c1362_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_40ffd33fdcef45698b019ad7374400df_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_24584ef027834cf08a7fbaac11b6752d_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_85c179d46b724c03ad2cf067449d57a6_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_4adab0d8b1554441aaa66ca4ec6fd2dd_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_b82697d8adf94a45a622fdc5e8fc6b99_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_5e535004a2ba444cb268f4ce59e81691_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_2865b506227948718e0f7bbc96ae98e8_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_5e79b6ea536a41aeb63bafc8648f6453_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_6e86a396dfc04fa1b08d3f9c528b559e_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_e98c3a5f705745779fd3eee4ceaf16af_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_b6241c7597ba4efda54a5cc6987e1c9d_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_5e596017aba649ac99faa42363556de8_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_00f3e6cfaae14a7fa56ff5cac12110c3_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_0fe932e9d63d43729dd461a860cf2ed8_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_788b52262d5d4a1d9025e3800fcb0a19_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_438878a6398b4173b4a9ede5d2a0e988_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_e0a279e838ee4bfd909250aee2417a73_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_c83fe595eb314d3c8484682c4785218f_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_cb1f812e566d4f0dba5c1fc9016ec8ef_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_18ba7b2cdfc9444d89d07f64bf9f7928_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_5f1bed43505e436caf28f7fa1df65e7f_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_31481d301e83455db39c41b993b18a6f_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_3998168fa19d484da7d85abdd4ee58e3_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_bb11735b28ee4a75ba303c0887f64ee1_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_e3a3d119ff504617a69747cb086f6bd2_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_2e935ecf719248c0bc895685e885492a_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_6f8592e23ad6418fa48612f3fcd5ed02_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_7cd1fcdc001a4035aca60b4ac26bffb0_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_2e1683f64ad44ecabaecf1730ac43359_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_73e3ff02931944f2838213413043d54c_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_bb56b8050eff46c790acd734816bdc6c_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_27539149f5f24b5099973d1bfbd79f28_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_fab482c0728a4c769f86066b5dedfdc8_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_9d17c9fa16cd4f1ca4d86076e3fc8e87_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_3b7b1946c72f429ea319805d074da16c_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_28bce6dbc06f407297eb1e5715f88e3c_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_1c436af98ded4d979d28831a1743596b_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_be472b5ea3da4ad1b896001d45a9b694_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_6dbb1a5886d645fe972d404049a110c7_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_bf765c4db99748259d5c52bd414af46d_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_93c2480265b549aeb966731d2651a57b_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_a79570f5dfa649ad9c0ec1894be24af4_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_3ca0b7246e5b445a8566501649c2d447_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_a35192a19af74e3aa7fcfebc03c3c26e_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_29b4c60694be4b5591849204eb80ea52_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_999ae1d9f85543d886fcad527ef48d96_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_a8597566646a4323b566fdd4e6ef35ed_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_bdc87160b5024ec2a6de12101670fe20_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_660b1f72847041099d8b476d38c2a5ee_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_6f23ebe1c43b4c13bfb1d26903ec7089_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_1787c8210f7d47869dbcf886ad8ecf7c_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_676d7805fa4e443a88191cdaad1e82a4_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_2318839aa19448b0bc7a864aadd8dec6_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_9dd3d38cc5c8499ea13d510568e88dee_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_8abd551f87c74495ae8309b0b1a12f5c_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_ffd7966051ab4b978da98cec16526fb8_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_dffb2a28226d48159437192e9d9b1926_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_74fcf07f1e374f3284c72c47bf55c157_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_4988a7f360054133a63bbeac4cdee2a6_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_c445c57bc79b404d908884dd0ccbdfab_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_8b91f96456444f7b9ef7087fef164935_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_14a1d7a7ad2d46e796f0a2f7f3acde42_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_b99c525d390b490999dc18ce944fc3d4_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_cee59725c5434ea1ba121cc367135211_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_0669e2d99e99490f85be32c0963bec88_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_e6833528e5a1424e9386e5caba526c7d_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_58e66f84be6d4b4fa6f6eace5725d764_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_691614ebee2441bc9826a17740e17dc0_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_7f236407e00f42019dbdf3e76b0a9c0f_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_42255f8e33524b1ab68654d4f3bcd1fe_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_b46a4188a5b44369959f87e9197fa1f9_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_0ebe8cf359274907a493a498ef22b13f_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_b67214110a4e4748a108ea428cd7f43a_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_3915a2aff2d742d1a7847bc8e44631f7_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_20134fe0ae3a480da15f988350538aaa_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_2ffc04d5143c4ce0820a7bae5336ab1f_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_c670cf0afc2f4f19845a2ca679eedea9_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_5d4a38699d244032a54d208ee4a3213b_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_2c0cad23dcb04093bc47bfc16734eb0b_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_4eaaccaa4e4b4771afae422acd6bdbba_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisvideo.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_8659a452a6d543c2a285c0a7fa9ed3a7_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_dbc672096fd84055a34062960e312af3_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisVideoMedia")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_b74ba7e55b814bbfa730c965629cbee7_Test()
        {
            var parameters = new KinesisVideoMediaEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisVideoMediaEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}