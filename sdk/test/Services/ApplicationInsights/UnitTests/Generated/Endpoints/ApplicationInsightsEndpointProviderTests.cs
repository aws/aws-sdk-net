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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ApplicationInsights.Endpoints;
using Amazon.ApplicationInsights.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ApplicationInsightsEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_cea5068bada84a00bbc1319384e36305_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_fb944cdc425643ab8d0fec2ca46478b0_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_5f583dbb306e453e81d3aa9ff41ae475_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_fef0277488d648a48cf8cc3d2957b116_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_91162905149845ddac714a51d9e51e39_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_3956abaef2f147f0acbf56efb5cd7e7e_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_4dc2cfbdbea54fe7a1febc5763db24eb_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_c1e910dee022466a913be6f90145793f_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_ab27bc775a644567bb07cc54f11a05c6_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_cd754ae7e0234592bd8837ededdfeafc_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_e341d716eae44a3b96df384654d71a79_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_a380a52a8e2746608a90b18a02656cd0_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_b07552ab3f64490eb81de34bcb9180a7_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_d1662f5230ea4f718cd134b2f2cbe4d5_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_214650c3a6b6478d8200750dead00b7d_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_b00bdeccaa974e278a9e574d1a954b9a_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_3307005d5f7d48d992abb556f086d32a_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_6baef64a81a8411f862fafb49a68a512_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_9b99b79b09394c83beac201a4dbe4550_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_4443cc46789648cfb124bae0bcd81c1a_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_0e532304a45c4191ba55bac012911a14_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_b137e305366d4f799c17389d6d4496d5_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_e1d57ed727fa45ddbeb9f5d20043d6a3_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_e2d63ef81e744e8988504793cf4b095a_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_f42c34d49dfd446483031a49ef6fa935_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_fdf4598ba5644212b263fe1b68fe2582_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_e5a45f62443149c7b3d81bb4bac6f398_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_d733edef3151497aa5ba6db9d200fffb_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_d89dad9410f1426f8040f24df0ad1d8d_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_30fb868d35b84d05bbae8c236c979129_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_f877088066574137af5f507f03776b59_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_52031bde179047828c8d738160d8d078_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_06fbea6c58ff46ca821b334bb7608133_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_f074b88139504b139e296bb8230d9889_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_659ffa08d9934e8684093f23335661a9_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_10a9f7cb5c3c4e7a9578677391a39e36_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_92928155f41847828a946f2b2c30a319_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_56647a7213fb4dd68f9ccd937b4a2ecf_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_5443b3cc785a4ee8aee8f8fb6152a9bd_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_2eec7f37ee504bd8bde688ecdb7ea803_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_28002ac9d5df492cae677a47a290162f_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_023cab5a9525487e9d2d5866c4eb5c51_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_cab6fb7b5783431cb8f36bc6cef44c2f_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_1dda5415898f4cfdbf93562455947cd1_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_03cca7522d8341b3bfec4e644174d8d8_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_229ce1ad7719444f871942b28b07259c_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_ef61440ffe3e4e23bb5de94e5e150252_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_570e1dc02b794203949c7bc6152c4f3d_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_98416e5946ef49dca704d5ba5d313233_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_24d120c49f2b453d94c1ef99b78cc179_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_b426bed985664e52a321daf45381b31c_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_a0cd04fa5e1b48af9a38412293c08c5c_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_9f223ec0664642dab35a93b2a8343441_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_95644d48ac07486b887cff40cb61ae62_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_4a88ae6bb73948d4bbdd42feb199b9fa_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_99b630bf6c724e358afb80380a680434_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_68270b786e99427abcc361b408e5c64f_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_e1ea93e9e28c4aadbc9419c3a6df52e2_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_74838be3065e49399eaf89be8f66943f_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_68ccae12b76b4de7ada5177ea2d1b923_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_8575b722effa4088baac2f0618e507b5_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_94c98bd1ba0a49ee84e6d5c90f8d0acf_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_00907050df614bd880d3edc8b10dff19_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_32673ca13fd449d0973417bf792a56af_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_cc282988d46143ffb0da878b39751457_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_4b37cd48f56a49b1a541870318b12ee3_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_541c81843457429695e54f84d3f66b63_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_0bf7f7581f464a66a44c76a206659de9_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_75a9225d165a4699a0cb47edd1fd65ee_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_0aa1b3f5b1674760a54d5a107fe5f749_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_5e029969b6744137aad20087a6b90394_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_6f4be52a5aca4128878606a3ccc66d23_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_a9b2cbb59028444c926e3e084ac77d87_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_4297171aa57e4aa1af200ab53b2d838f_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_34cca896cb5145d189a3d3ad9c4c09e4_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_c4350babbf9d487e973bbca56590d902_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_0e7723987a084f0a96114813133b4fd3_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_a3eeefd0d1ad417d93a279319f03293f_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_d3d954c138c0428bb2ed3621a0660d4f_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_a896ece3e5de4716acda61629e9b14a9_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_de47eb6a20664c5b985264c72e31eb60_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_aa223ec462854d79b41fe9882d4fa0c0_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_be642a0ac9f64feb9bfb80a7fb26057d_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_8eba00e88d53411380c4bab8a6c1407d_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_34db57684c0341d0a515547fe7f536f2_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_c9fd651f4498443e83d97071e9599c84_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_8608a50e1b7445aaaabaf20e9d71a940_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_9f83bf5af5024c6982d4b112c5534c88_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_d26e8bd670cb4fe8bb8913bc60bd3c64_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_8c8824713af545248866e6776cc59994_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_2bc8babd78b648bea7137f3a96e120c0_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_bc754c188e944572ab344dbf645afe7a_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_390ed4515dac4cdb8f843f324b5fd908_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_03e018aeef864843bfd0addb0b899133_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_dcee4bdaa86d440588f735972ef77a4d_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_e32e690450fa4b0daffee7c30f3ef8f1_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_9d57c80e71954abbb85081bcb2bf9cb6_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_3ad706937a48464a834e2163980d8e5f_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_1cfe5c920cff4698b17ee0bb7d3636d7_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_9f3079cd1e1c49b6b5e9d68c30fb2e4b_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://applicationinsights.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_82e285d2f4eb4eceafca83278ffe3145_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_dc53f62428244a30a00b5528418190b6_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ApplicationInsights")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_0f00bd98c09c4e0f995fbe0d498a9e02_Test()
        {
            var parameters = new ApplicationInsightsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonApplicationInsightsEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}