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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.PinpointSMSVoiceV2.Endpoints;
using Amazon.PinpointSMSVoiceV2.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class PinpointSMSVoiceV2EndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_64a077757553428cb4d13bf73c55cd6b_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_72a0dd59786443ff83ffb22cff24d0aa_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_c92681a73c984a9a8f81453df91b854c_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_27a17d8574a34ab99f38465b6ce2423e_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_e5b380434018438485ef9ed5ab4bf45c_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_2dda8ef3f3d845b4a316e63333f6632a_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_d4587cba6609402c9b469461e81155dc_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_cf57768d050044a5b1b238ed5d5b828b_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_7904973bb54442f0bdbe885586aa134d_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_c9c2081baf9e4244b64ca999c604e254_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_b3b6565517a442f09ca627c7615a210e_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_b2caa9d34d964611aa24a8abbd7c5895_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_16f9a8d88560475aaeb926eb6e68d1a2_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_46c0a0435bef42799565d3c5d150f836_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_e1dd8cb0cdc7457fbf406737611431b6_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_80c55e973bbd491fb6c7f27bc1dd8918_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_63070753117443c8b064a0d2d3d33ec7_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_f059de9f834f4b82adf4a16a452741d5_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_4939975682924baba460aee3d320a4a9_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_7230475584d446c6aad2328fb20c9317_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_b1aa5674f919423697e52511b778af3b_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_76ec56b6bc6b4af388679272504297d4_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_0e3c58bc77ce455bad8b5a2ee1479739_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_ef19fe7de1d54d27ac86835b47818c24_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_0477f0d1ccbc4febbcbc81100d8e24f6_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_de6df700aa024e60b4ea504ba48ad087_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_20547207fa594912942b48c84d27d22f_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_64103ee3094b4aa9a65b78be84883dc4_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_e0bf88954c9c453d8bfc93f997fc630d_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_1d615ee10ee545e7884b85a9a23e3468_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_88a053695da244f1924bbdebda85434a_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_fae029dd005f46ddb6bd274c3ce281d7_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_0af16790d1954ddcbd92a9e8b43caeb1_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_d0f90e766c744b208100a5143208ad11_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_cdddde385f4a43a782fdfbff326afa5e_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_145a978364834fa3b635ed429a03b353_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_a06a5d37f4d944939f125ecf6a304396_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_183f0c7fcf974400a0c0bc5057c2c197_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_dcd1628c33f247469520a75653e57b12_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_59d59bf8ec8542f3be5ccd4bf72e88da_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_e5d4ebb01e034e258623fcff8bbde3a4_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_125afe40ecf34352b5770e78b1ffe8cb_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_97ac76e287bf4dd791fed08d4dcb4267_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_c39fba0dccb740f68f14383e5d93533f_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_a698b5ad1fb84090bf4e41756a3f1207_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_76a73360efd64d049163428f737bf753_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_f050e7627d8e47e8aa82783e365df9dd_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_6db4654b547144e2a7b9a64f10fc8e16_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_a8f7e395559145a8b13dd4898521ba66_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_af22b9c7e18644dc98d21c90502fc916_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_abb015d4d10347c4b68962bdd8459c92_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_3af8ca6af3834058a9214c18ffbc2316_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_3223b40f129d406f8a2fa7d3324121c5_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_a08cdc3168774c00a1c417c3c462c55f_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_2636f30b2f4c41d19fd3ba2c06b4d6f6_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_0c839b7341fd41218ef0727226a17c5e_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_544aaa43bcff448fbb906017a4ce57a7_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_84c4489009dd43c487591352396e6013_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_94423e9c582a44eb8bc267c213e84f86_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_45ca072f4e864eaa88dd8fe3337b54e5_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_22a4feaa881945bcaad9a0cb9301057e_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_c20f7af127e24d52a6712b95c6e66066_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_d8e43fd8f6c44fa6b8c809859cdb236e_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_374850d1121541de914c99db7f5ef75b_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_b2a3278c3ad14c89a026ac7f6c56b444_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_3ffd2a291c354935b1c75a2277f00799_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_70926d03e2ef4d26bd89f6e764dd4bd3_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_62460c089bf443d1af4fd0e9a1540638_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_16b6b5ab8e8b42d1b1c6b5e2bf3122a1_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_44f72a5643a84d0fb583d299197e8039_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_5085bf9f2d9d49df9773d745e0b16c79_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_605383e471df4a1fbebcf1b129b4c16a_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_33505e820cc744878793ae212740f055_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_50276c9e2bf04a28971a912d8535d0d7_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_6e7c81d5c73148459b2aeca9cc373417_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_6d4036f50bef4020970c930987430e3a_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_8871172c19e94dda8f7fa423707e4ee9_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_fb1ecdef946040e49b6f80ef2cb0e9e2_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_510074ee587f47a7baecc0c2c4801759_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_bd7d3524c8a647448b3aa072f9335a28_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_4451c18ecb84437789794d61a0c1b02c_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_514d88c108264edcaa9d12ed211c694a_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_c54bedf1bd11458993c788fc8d14e642_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_3a08ddfb033046a693666c9e1a791b39_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://sms-voice.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_5ad499dd7e0f496e88cc5c3c8565a913_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_cbd996ce02ea43d9924b233119a956c2_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("PinpointSMSVoiceV2")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_ace05a8084c74d23b9a127b21ac02ecd_Test()
        {
            var parameters = new PinpointSMSVoiceV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonPinpointSMSVoiceV2EndpointProvider().ResolveEndpoint(parameters);
        }

    }
}