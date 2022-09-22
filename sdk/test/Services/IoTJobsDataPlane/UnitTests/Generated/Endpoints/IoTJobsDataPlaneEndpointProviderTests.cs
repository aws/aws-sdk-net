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
 * Do not modify this file. This file is generated from the iot-jobs-data-2017-09-29.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.IoTJobsDataPlane.Endpoints;
using Amazon.IoTJobsDataPlane.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class IoTJobsDataPlaneEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_902f66d5c7d04e0f8622fa3cd0276656_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_c7cc3c120a794670ab2193c039852b47_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_ea1aa843239d482497f087e5d12edc84_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_7d408aefee604643b3151d7a588bfec1_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_ee460d860c024239801a4b1dd6fb63c3_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_b883765e75894d3b87271e9f7b42958a_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_dd3ead1e4dfb413a8d16369623aef15d_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_e0cd1a86f3664ca7a00634d823b5839b_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_25a885df6fff4b3daa5554dd5bc42baf_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_3dcfb0eab4b649d7b23121bac6fc16bf_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_c28f5f6ed1b042db831c62ce1f3754e6_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_985ca1b177a34d9095e5111f4312137f_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_8fb39275f96445158d1948635af7576f_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_cc552ad073294a23a3183e6473b9d5b0_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_83ba4ef7fca44c31ada657a1e30db33f_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_1f1629dcce29441dac8b7cfe8c4e7b0f_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_b94a63fd1c774e2fbce83e5c98453846_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_3cb3801b50964649889646a267fac0d1_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_1ca153cd319543f295d44785039f1ac2_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_72ef6c8c6e1f400998908535f4b8f70b_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_a897744dec6b4c21aa9df876fb1f731b_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_e7d7079bd2884913a9bbd5b9be953133_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_033d5ad4d90241f49c78a5e4c7ded8f6_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_068bace857e04d579e2780407ed951ab_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_9e8932abba1f4bf5a8c1a04ba1b61570_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_73637614b8af45929a5c16180d3e4eee_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_9b81c18f034b45369120cb9181fc65cf_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_6173f6a3884a46a7a0b4e744a4d019b4_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_889d5256e892417485864783bd69e0b5_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_b1d8e774d41844eea77f01aa4a0490d9_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_bf20484ad00648d08441027903c67d23_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_8c0cf0ce1f564fa6a24f21e5888b246c_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_ef44ae45e8214b2d822320b1ff2dffa8_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_d649051249db4f3cb8151623340e2766_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_f84197c3ce314b2e827c386f3a30cefb_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_5dec5dff0843468091670742af2c2ea3_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_221652f9b760474aaa64353a80090223_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_9dbe06694c554b168f8f8b68706ca0a5_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_ba3ba1ade5cb4dd58ae71a7c112bbbd5_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_b0ab01b784fe4930b4e5b4be7e099de1_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_dae3ad5093014eabb50740c97cd7853e_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_6ff838e3ba074f1eb8af8f1a9200bd0b_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_dc26898ebfd14ee8ba398ba8224c4de5_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_e2677e8c34384d2394a243cd91ce047a_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_0e4da3cabb9e46eb9f3497d59f215ff8_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_99d8814b28cd4635a5997f9b14f49fa7_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_d950145831db45d7a9388bf1aa7d2375_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_4d71fd63da3445f8a39a80521dda0382_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_044530e5041a4d089eb8e9b510ba1fa4_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_8e3b501ee40a4172845a4cc86fae4216_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_4de33004382c445b9d118971a751441b_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_dede57d7033047fcb8df0857d009f995_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_63a6e1461b88414dbe8ae3133e5693e0_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_9fa564c3eaa44e3a92ed44b2c25d3df3_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_6badcac3ce29474c95e070451faa77f2_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_969c1105852b4d559c6f031c9fcf00d9_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_2bd2189620a94dd7afd29f26c93fe5e9_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_6095f166d70849ba84637afeeb0ab466_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_96864c1f779c4d4587a09d5b1fb3208c_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_d2e5f968e78a46cdac05dcbc37743a57_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_9175d327b28748aaab2368f5a6141172_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_2749d60e288845fbabdaa4f22f89a055_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_bb65041e7af441b0a1b60a094998abfb_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_848753b30c224a19b49209892d58e808_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_68d89e7fa1eb407b8d87d4210ec7e6f9_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_4c2d6548448e40f8903b89be3c9ffee0_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_4b4a9b26f1f643fda3bd50f9cd0951e5_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_91c0d9cb06d744548f32ab81266daab9_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_346099ad11224ecbbc8cf2557a36099d_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_8cd2de7bde314d7c90f217fad9fe1613_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_3b882171234e409ebddcaad81db555e6_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_622842d8ec6f426e8355e7f9cc165590_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_b37bae0337884df98fda47d53dafe44a_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_7aa2f22e4ca94819a0aec8492a05ce9a_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_8831c41df8cb470ca67627b24e39ddd8_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_2d92474ccd65404fbe909a18fd031973_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_cbba99bc76c74b4fb833b50e30ecd09a_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_e19aa4e793b443e1b69c0f262de76535_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_8f6a984b190149ecb937007b42da1f9d_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_c45d36c2e4924d5285cefd34c2563271_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_3b3063c5c6c045f6beb23b17ca825683_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_8af463d49b3b48258e9e567508dcecc9_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_cfe2651473ca417a992ca1980a77cef0_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_4c155ff9b7c649f0ad78a996c965de0e_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_b0da4a2bfa3542149b1d8050102ffa87_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_9a22a784700645bbaa0db3e3fd4878dc_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_831b56ca869249398782a29c15992d6d_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_ffc1d48624de438eb54c399235769d9a_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_d5db6bb38f88427086785b8fcda2ba9a_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_0f2d04e377544e8db395ed2bea7c6181_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_d7f7b53e8435426da58dba75867e4fe3_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_3b84f30ab32e4463814760492d11de9d_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_22d7c74459ce42dfa854a81fb58a52a6_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_174a9a7bd57f41d2806d8eef658aa308_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_1dfe33b5361c4719aff93630ccd44263_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_991c3cd1640d4679b4ff70eb0884c837_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://data.jobs.iot.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_a3f5cdaf97314ff28ea3c205e955c4f8_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_1a701b1b707142358240b5150445b8c2_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("IoTJobsDataPlane")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_a3dee2b327cb47fd8cfdbec7fe8f9671_Test()
        {
            var parameters = new IoTJobsDataPlaneEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonIoTJobsDataPlaneEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}