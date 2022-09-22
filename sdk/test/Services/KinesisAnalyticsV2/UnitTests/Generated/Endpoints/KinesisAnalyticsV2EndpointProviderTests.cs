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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.KinesisAnalyticsV2.Endpoints;
using Amazon.KinesisAnalyticsV2.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class KinesisAnalyticsV2EndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_1e65efc0cd494af8bfdce2556843f104_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_126e08d4165f45cb8d552c6b4adaf3c0_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_361144e2b107420aa666b27538493afe_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_ed6d2d968d3c4e62825d20df49ec369a_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_e6755bbc581f4f6caffd9e93a8565d1c_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_6d2ff0b830db409198fa360a2dfa57d9_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_a50b03aa57464d56959c4cf4d65bd9e1_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_fd6fa8a98d67453f985eec6e73a92c0f_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_6972dc3488f647ceb6b5b49c30e7b734_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_26597dfb6c5448fea23de57873874438_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_9feb58ccd3304c0c84b4cc1639b48c22_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_978ca40c33e64406aa103e7aa0634ce7_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_bcbd948cd8d949518a89333ac0537b05_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_a797520d13c84ddbb540151bd54d9173_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_eb29da03c5e9437695ba5318c38c7927_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_ed4e6ae7b9514abf8eccace1816f6653_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_8cbe962def394b0eb1d2e3008af47800_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_f8354820476947df888a67f0442c0382_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_5f72bd6b57984822b8ce95dd38ec100f_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_a6bdc1d63e4f464fbdb65ab5fdb57694_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_91613226b8c24a779eafb93d9390199a_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_2d83502e0f584185924c2b4bfca8d2ae_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_5c6f4e5d18f14e92b5e6d94c25a52d47_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_eeed26dc076a40db81506ecc2af5e3e4_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_b63fa4d81b1e4be4ae7fed5d31686fbd_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_81ac2d35d37342728a8326a7d043708a_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_04cf9950bc384b84b5eee72b8c61fa8b_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_73120b61e90746d0aedd2298dc30ba4e_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_cee7e496eb4346f8a081c28dd77ea6f9_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_522550117a2648958764fc85419b3027_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_a60ccf854a1e4277a08618452101f427_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_2c04d0fbf7bd47a5b2286d3ca2b25947_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_699c958c52f241adb492841f381190d4_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_545f521924c946d999d79426d7b96f7a_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_14d3d8859e674a728bcdce535fd6c3fb_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_587eff82965d47faaba328e349b06c0d_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_53e8a48f90ce4f7db2a09e476cee4d2b_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_1d05c52456bf41238e9fd76ee6d0c4a5_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_6a43803376984b899c6b25238ed274f1_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_17754fb7e19649b6b69ba19a8de4767d_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_1e4bf4667c1d46cbad04c3797e2efe84_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_e545c9e5c99f4307beac1e8c24e88d7d_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_910c27537cc8443a95bc850cdb66ce93_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_d98f5fc5a7b64243b6a925b89625439c_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_23739c2a13a347629c8f25322516cf23_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_6ea7160c074a4fcb8f6ce35d600740b3_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_bc484aa52fdd455bacf6a31d7aa8c782_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_b008ac43c1444d9c9237bd0e4009faae_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_dd22d2309b164233acca94ed4aa310bc_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_34f26bf498eb4dd5ba5235276ad47ac2_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_90cf6aa74730450ea53c0b52511d3fd6_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_ab5c991ffc534a4ea8f827308d8d566b_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_59f05d57af28405095154d2facbe83ba_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_89da400b7f074deaabe45922315db9f3_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_2769f0cfa2714b9fa7bd15c1e5d403c5_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_817d2f33a7c644a494ee3f181b3464b4_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_8e477f5444c94b5fbbe41b994f2c22b1_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_f4283d4a133f43a5b769476ff1f8f906_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_df868a8516454f5db0ee103dab60b556_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_dcf8e19bbbc844d192bd7eb97e7ed254_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_0d30fc2de5c340418142a4035f9ed572_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_ae160cbf6cb449c0b910929089692764_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_999e64d23f444dcb87b9f56f279e0d4d_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_83593c73966444fd991de3bfda639e11_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_c70150666de64298b5be473c7b24e177_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_18b3d5ce6e3e455bb4e1a88e3fd81ca7_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_7385829040174952a102b23d7bb63487_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_2ba1a87a79ee404a86b20e27abb7508e_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_4ff768afda1c4999943b8510e1c2c961_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_18dc297c22e84e609a9e5cebb98bb830_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_ae3a847b902a42e7a33ad95caf28ae1d_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_08a9a371e763491b8730da57450a2db0_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_0434f50227ef4e798f21837663d59ffb_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_dbfc9774477042b7a8ab7f730a693346_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_3c2e20fe7db54c829c7becc20ffea47d_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_c6e0ea58c5204fc194eeff1af7d855f6_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_39771aaf5d3d4aa5aa40fe868718e8e7_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_0beb2b42b27d414bae19c3a792df8500_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_6ae2879a1355452b87c91359058c7e7f_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_a603ef1ba7a6441aa8081d1061b40ea9_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_fcb686d33ab54f7e93e83590046aa0de_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_9e636c00ab80456f9f009f0746f20a99_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_6499e4b6be9a4b5ca512c863babb2cbc_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_c83c17df143141bd852f291c8ac96609_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_5f8aa3b130db401785094af09ff985a8_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_cd50d5406e7741a5aeb058ffa528a186_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_900532bdebc84628a01cbef909f04873_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_c0b1eac49ff9409f8a5e5793023ea9a3_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_a2295d462c5a4b809b2297a9c039f750_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_16c1e946cc994f5b9c65698e54a1ba58_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_6209894f7f3346adb019f6c18f9722a2_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_eb54064757d1444393ba994ddc208b68_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_43f847f037ce4f358bf2290ecb01ee3b_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_5e88fca78f0e46c9a6c2ed89e4246222_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_cdba2050867b42179ba30b4e118725ed_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_16c3771635d342c7982b96fc7c0f16b5_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_af9d79919ccc439f8d585ff28a8dc274_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_5dba7d787af1453590b86d372c98eb10_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_c94268aebdcd4bed9d27db32cf60f5ec_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_332f888f868d4cd5922e48e53f29d9b7_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_549deeef297c47dab7f4a51b8c6e21de_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_ac73aa270533477abe857823d727070a_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_5a5a3bf87c3f49a4b5444727aeacccbc_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_74a6e283b0fa4857bf2c8c1ab79635f0_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_dc25fa15c6084d539329777b52a3fdf5_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_0c600eb1669a4ac79b8c20990ce6dcfa_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesisanalytics.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_aa75ba9b5e654aa590bb95aa974f69e9_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_cbd56b50a92b4c6f8e3355786f7f8a9e_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("KinesisAnalyticsV2")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_7ace1b6ae63046d8b7dfca0920072cc8_Test()
        {
            var parameters = new KinesisAnalyticsV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisAnalyticsV2EndpointProvider().ResolveEndpoint(parameters);
        }

    }
}