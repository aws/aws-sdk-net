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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ChimeSDKMediaPipelines.Endpoints;
using Amazon.ChimeSDKMediaPipelines.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ChimeSDKMediaPipelinesEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_072720811f024e37823edef45cc1516e_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://media-pipelines-chime-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_5ace7d26ec4b421ea5bf492ef0425919_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://media-pipelines-chime-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_c093d46da67b4870b330e5682c6fd5e4_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://media-pipelines-chime.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_b5617e78d6d14a2fa82ee85465997641_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://media-pipelines-chime.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_a489f2a26e9d4abeb30bfc2f020555df_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://media-pipelines-chime-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_d7a5fec432264e1aae1539ab99bf0d5a_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://media-pipelines-chime-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_f700169bc840484c8c95ddacdd9646db_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://media-pipelines-chime.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_1e04a3e52e7b4d4ab6653bb38db61f1c_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://media-pipelines-chime.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_268a2c841bae4e7299b0c4a411d0f7f2_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://media-pipelines-chime-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_b58a9e01833d4f43bf0c40e8a93d748a_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://media-pipelines-chime-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_c170509800f14fa39ad8a79210aa9627_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://media-pipelines-chime.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_ab5fcf9c1fd146cd96812f33b3e40169_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://media-pipelines-chime.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_c87f8ad091134a61b088f3fbd3c7b7fb_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://media-pipelines-chime-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_05e5b6affec14061ac3c08b055d7b5e1_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://media-pipelines-chime-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_775c82a87904439bbb2e659f4eb73cd3_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://media-pipelines-chime.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_ad54015c4f2a4d75b193c297c6faa596_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://media-pipelines-chime.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_43d49eb256774ad48ccc17ba05061a6c_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_16aefb526a0944038904ca2a573f7e17_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ChimeSDKMediaPipelines")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_68bb173159274efba4c2fc4c3c418db9_Test()
        {
            var parameters = new ChimeSDKMediaPipelinesEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonChimeSDKMediaPipelinesEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}