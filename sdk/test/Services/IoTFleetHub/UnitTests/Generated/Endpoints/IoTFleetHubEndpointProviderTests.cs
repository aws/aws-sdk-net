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
 * Do not modify this file. This file is generated from the iotfleethub-2020-11-03.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.IoTFleetHub.Endpoints;
using Amazon.IoTFleetHub.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class IoTFleetHubEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_a3c466a573f94ce7b2322de40e770892_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_1534fa69d4c546c6b1bcc6e691ce6b21_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_68807b4d867a4c5cafb9dca2feb33e48_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_5a3211b167e14b24ae886bdf3e1dad6e_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_bd6c1268c7854386ab55e048142fdb8c_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_78189e5a49934416ae4d86d604ede8d2_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_57e8056d09ed417bb0ae014b72b824a4_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_ca522235ae1647a2bb3da74e8bf1df3d_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_b6025ccce0204e0c85a453c17c10bd5f_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_0acd986485d744bba780b4a43e41c674_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_0d4e5da77eb54b908a940a65c0cea68e_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_1f54284058464a66930ae031240cc342_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_3ccc5ca2c13d4a8788ccc9eff6a6ce6e_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_e3f4bf5f002c4c2496e8d268557db8f9_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_ecba3a99f7bc4d35829f9da3c9cd5832_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_a1709a2f5a0942a59402a26bcf512645_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_8d9aa142f5774bcdb19724c9ef145612_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_990b52ae0867474594d664c88e20336c_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_76b90e88614142c4b776d0d6b12bd216_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_c086325cded34354831a9783225d8678_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_a34273fc16d7447a9ef9f68f117ac965_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_22a4d6eeaf5a415c957dfce501ffe739_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_8f03b87d8c714ce1b08751712080243a_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_21a5530ab87d4aed96464ea8168dcfa0_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_3861471fbf724875abf1514d2e9038d6_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_939d34e5d4b94ee0bbf9806378e3dda6_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_c9cd364d05894cd29e69cdd73f76a51a_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_a2a995c156a445eaa9f6e4a017631d32_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_45d0eb062899467fa3d090ee552359e5_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_e75c0dc733eb46818f096eaaab2eee03_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_8b471b81f9a84756ad1881c725506c29_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_5852acd32aad4c54a88249e161fbe46b_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_eb7ad86ef0204cae89bd2a1606eb2a6d_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_6a9cbdc752bf4035b4a2dd4c01e4b0bb_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_a342e82682074d2fa94b78747049c32f_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_b99365d767874f7aac92d071e3bc0ad4_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_dcbf5d19083b4fdda00058f9efdf37ea_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_2c534b66cadd428fa01ff10649dae5ca_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_724af484a4704f99b85bf7838d034e20_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_f5f2cdebb790483db51adc8f90f46034_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_5965d6607eaa4b63a7c7f711cdb19b8c_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_b8ce1bcd2de94b1c857be47fadc72b42_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_4cd07f27275243bc9a62e139e5397c95_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_9270dd0394624dc69513d1d7949a20af_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_7c6bd2e905954c06b7229f2a535d61dd_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_02a9966363f8445d80e446c7db326da1_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_851fc6ed35614ca88d945cab2625317c_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_15b800231ea54f2380501eb58fe96483_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_6cd28da79e5b43b1866c0def18d1d2c1_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_bb4c80f484fa4136a27bc6561d7af963_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_02901cab2cb04a84b8e383c84bc9fd93_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_562e8b7cfa61454587e0338c65fa228e_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.fleethub.iot.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_d8801a3895104247bfc2df9ab04ae325_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_425e4c995faf4e87b47db8d4eb4e7987_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTFleetHub")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_ed3f1b74603e48398afa008038a8f774_Test()
        {
            var parameters = new IoTFleetHubEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonIoTFleetHubEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}