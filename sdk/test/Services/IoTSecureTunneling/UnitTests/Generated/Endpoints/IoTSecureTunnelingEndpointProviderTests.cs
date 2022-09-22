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
 * Do not modify this file. This file is generated from the iotsecuretunneling-2018-10-05.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.IoTSecureTunneling.Endpoints;
using Amazon.IoTSecureTunneling.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class IoTSecureTunnelingEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_137a3f5c87444770883668d80c1644e9_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_7b3aa4d922c741b9a8d9b6c91c1e8bf7_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_41e13666ef9b4b21b21fbe74c6acb885_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_39ed5703f8fc494d9a720f8e229cd38a_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_1c50215d183e4fe7a00f2966b875c245_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_3c2d8b0ae6dd41c4b4e01faf2a95d974_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_845b6268fea84ea0b8d384ed50318bbb_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_0e9386bb8b7648cf817eb65966f2739b_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_85ca8c4ca1444b6f98f166273a1774c5_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_fa220f04b0d74208a03d1666a6361ccd_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_697f763b06bf4c3ab55a73f6e16558bc_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_43cd9a2cb3b34802873bba7bd1fb1662_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_b04c6ae920864c33b13a3ccbba33d3ab_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_1b32ba56a6e24c619073a10855de1260_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_60b4fe519cbf42adb3e11bcbeab681e6_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_320a18ddc3db433fb6ee9367964df95e_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_91ad31454f9a4d6089bc3abb54495f24_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_3dd1f0207f504e3a9ed5ffb4a0d83141_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_627d3ceecb994744b84333506cadc28a_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_aa625826defb44f4a078c1807a396888_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_2d48f838937b4562b0fefdd5c4228313_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_5e6c92d8a1b34b4d9a508440012e38ec_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_340afbb81fb64f5d84bb6bef3b816509_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_0773fb18795b40a38e6a2029ec2791dc_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_2518a91e04ee4aeb8e127f55fa21780a_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_9e8205914aa947b2bfa5258eb03d9977_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_69e5d612974f4feb8b37aef42b358caf_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_40deb7b2cbd74ca9a74a91096f7e86b5_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_f42dd838164447b49f3732dcc69a2d30_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_f6ab88cb468847f580e8ddc0c6c1afa2_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_6f30c3fd4c3943939fe059e52d8acfcf_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_dd40797d1f994d96b65e5882cba7dca0_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_b27aa6fc8ce8418e9864ad4635d23091_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_c17a1cd241f645f58a2de194e482812c_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_a6105429026a4245916f390fe4b73043_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_b1511820848c46fd94e25202d02d55d0_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_f07be294507a41cfb00788de5d90b1e7_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_e84a38d5cb09406c881e8dcf3b5b8187_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_5f2964b948a24eceab0f33925bdba5fe_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_4c4767783ddb470fa98dc229b3870dfb_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_31f0ea96cf44410bbf9aa6d55dc1c87c_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_8fb8ab4c330e41a198cc3099ac348f08_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_94b0acc3b90f4d76b209efcaf790199b_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_80adea9e00204e6191de82d0a5f07ba3_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_bb3514e2a4eb4496a149db300334ccec_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_4dc11fed1e63483989f4a1791eb2480b_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_27852497e46740cdab8c7303149cea9e_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_636d95890c9943b195a768d5321effe4_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_674b9ecc51864a7bb5dd2ec87a2528bf_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_00d1ece27fdb444586b385ee7305d95e_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_72d4145758dd448c92bd2fc4d5964599_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_ee975c4822b6486782ecd10363a3d3da_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_871e83bc672c49ff910489299eac9b50_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_2753cab9066c418b9a1725c622d88779_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_910daad9d2e7480d9a7e8446a56ccf31_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_07576fd0bc934e038c80840fc5d84540_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_367be5c7270743dfbb657ab2a8216cd6_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_5262327ad7984b0db2b5761f096f893e_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_f538c31846df42729374c5f92b89324d_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_c150dee5d0a34ad48e42290797ee16e7_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_784c78ebb821463a9135febd4e9314be_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_92fabbfc0fe241b795a32f9dd516c827_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_08b420be0c404c23b03e05b39af65dd9_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_93e0d68a7fc94595ba212d1dae6ae6f6_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_3c705ae55cbd4286a74c371a25eae643_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_8458725be0a342ceabc709d8961ae495_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_b11464ffebe04aab937003f681f54bb9_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_08d1094c0a07473db3895c5fb14348aa_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_d4c2c3d708cc4f9cb38de8542927579e_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_7dfa1f6627ac4a9e97426343bbc52d2f_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_2e6a0ba7f5864ec7823cc87f6cfde1b6_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_d628b68743484e1596276114b8ef8aa0_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_37a33a90521c43928fdb3276e6d7812d_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_ceeb9ff2ab9b43d2afcf010c96cf6eba_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_dcdb14f499e442d4ac7bef13c85f8c83_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_176c4559aaae4cf788f434add5a3ca3f_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_9959669ac795443cbabb533301e4e4b7_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_c81c2fdaa2b448da98be72c4420d44fd_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_7b5bf4caaa884e4db5ef41464454b218_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_c1812f26856d45e097f6644eaab2a09d_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_b6d8d764517a4104b6b747d3efe0c363_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_2b640299327d4e1ea0903c75c2c6c391_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_558bf580d3f34857a1505a044faad320_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_a8e356cb5c7242aaace009f3f9b9d0aa_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_d2a96a53f53a426f8c902c29bde79877_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_96504b782e6040a1bbd503d241cfe012_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_d54c8593ea13411daa3855b9e7eb9624_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_74d2d6d08b9543629e43666ae54872ce_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_7f61aecd365d46ca98c0b4ae0df73b10_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_f6a3f42e28704d82959d4dd35d886f9a_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_68da93531426462f95ba0adeeacde6ce_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_1af2d66145b14efcbbe5f31cb4e0e093_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_4acf0c00bb77409d8ce2d5db52119cc9_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_ddcf34b57e8d461197245415e8facce2_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_635292241fcd45639ee5d4bd9c0e7cb2_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_959ac304fe95423da3dd1b5c26ede9b8_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.tunneling.iot.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_737e169736be42e595caa7569d29ef36_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_ec78fa434423465da3c1b24b619518db_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTSecureTunneling")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_b8c95e8f08664c32a8c42e41918eb1a8_Test()
        {
            var parameters = new IoTSecureTunnelingEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonIoTSecureTunnelingEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}