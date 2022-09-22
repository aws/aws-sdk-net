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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ChimeSDKMeetings.Endpoints;
using Amazon.ChimeSDKMeetings.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ChimeSDKMeetingsEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_1dc572538dac4408a702d32f60206e92_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_18b527ac7f434dc6a7688d04ca6860cb_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_19c7a881391a4749a4c50252dbc742a9_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_8a5f7831e48843cda3d7a11f105b75ad_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_0e38ea2878674851bd3201f32010a401_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_ad6daaabfb864e0d9e9d469882c31d47_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_0aea6ab4e0394eee84b90c6e5ccbb23d_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_ba1fb5894f9544c894121c905204b21c_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_04014c9184a14a188f562ab35c55e098_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_939f29b54aab400bb98649ca49c57344_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_1187c957cb644d808b4637ea83c07951_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_98c0577cd1954bf0af6cedefb20860f1_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_52695f7969cc4e9bbfb31f56df8c090f_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_8e7c9504eddf4c95bff895ec1438202b_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_8e2de511aafa4ec2970d0a6fe9c6aeda_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_90ffe1bccca8456ab9249c89c44744b8_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_e91d20351a1d4ba0a68166c1668bf241_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_846f623884a4447ab39542f8fbba908f_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_37f8a8c06ceb4cd79911c218e7d379a7_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_125b98047233424795dabd777c14867f_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_74e18635434148918cc7a08178df01d8_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_8c0c6bda5ee3462d97a5d0ae3e7b3937_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_301b85f0099d4da5bd0aa2f06da05f00_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_6905006dc00b4294afb9d7a19ba508a4_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://meetings-chime.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_64fa8befa81941cdb5a564fab5bf2a6c_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_bf55b752b93f423394b0ccf23f4d36b7_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMeetings")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_27b8ffd14f10429eb5b1709e6bc950be_Test()
        {
            var parameters = new ChimeSDKMeetingsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonChimeSDKMeetingsEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}