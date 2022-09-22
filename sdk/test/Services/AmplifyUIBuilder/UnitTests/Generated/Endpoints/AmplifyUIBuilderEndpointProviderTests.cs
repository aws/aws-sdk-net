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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.AmplifyUIBuilder.Endpoints;
using Amazon.AmplifyUIBuilder.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class AmplifyUIBuilderEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_002f3ab6f1164260989877127317a00f_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_043492f861fe43748fdfddb421c9b2ea_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_b40fdf3ac37b4f75a247d7ff294221e6_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_ab9d235da6864dc7ae388a9b30bd195c_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_24e5ef066c0442899263adb022c5544c_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_8a2e3f642b6f40369b12470457074731_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_93582fdae74e4a2b81acc3448d8399dd_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_39392f7cbd344dc3b2180a8a2cc5c716_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_2f84106c36a048dea21f4fc42b29b1bd_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_bb26fb18191a4d1b9e09a9f1f9778b4a_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_da9339547a3d4da09a2520c3be6db648_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_6e1ebbad57a442ebba5b2ab3f9decd39_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_7009b24696de4f6baaed520591abd7c1_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_07d7541b2e30431cbfbd9897a2e8038c_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_cbf9f3784eb9443bb084b7fa3c5d6db9_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_20c43b56b58f463e98d3a71c9332ca2a_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_442078074cfa449681a9cdcfb8c2cc93_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_0fb8f82b394743b68e68ff71286ae783_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_d7ea7d0e896e436d844313ac5bc0c2ce_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_3f201fd2079d4019935bdd660ed21826_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_3ce124444a9a4d2bb9596bf739dbeea1_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_cf9b5c311f6b47bd96c1783d250de7a5_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_9c8c4273acd34782a6fefb5f39f584dc_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_2a33c84a4e824f92989111ea1ef53895_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_dd437cc7ff2f4f04a81a22e068d3d545_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_55548167875a4c6c9a690ae418da242e_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_4b2f07d73ba54a8584a7bc9a7201eb9a_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_d5d02dce21e943cfa4745184a15323fe_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_19c059107f13415ebf8f72273ee30ebd_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_d00e74cfb1184527aee9134424af772a_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_3873d292860d438cad5dbfa20d256562_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_137aaf4f41864556b4c65a5a7d0a6b22_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_46fea976381749ecbbdd1d79c4751eba_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_bb1683d456144b3287a6e8c46da3bf84_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_193ddf98a14d4d7088bd4cf76a357a4b_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_5368e1110bbe40daaa700bf9464fcd35_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_f907b9c508fd49aeb21fd4cba9069b23_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_2ea2e6a5200f471188f21f1db7815eac_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_4c1c53fb5d1a4ba3a14cbaba367ad581_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_fd7a62620caa4d088fbf364d6964a17b_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_bf2a9f2f5a3d43af83d1cb2e1665b7e1_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_5562960572ba42b4971c5baf7bed949c_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_af6f72e2d0454a07b53ee6127edee6fe_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_45fabed25d58428a9bea1ae646399884_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_46005a02c5fd4b39a602ad0096fd60aa_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_38ed49842ce04e39bd517e92d6d6a35f_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_cf7803a4a3e6423b817a61ef902fe782_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_8731bf8dd0d34c518f3fd925c7205bd8_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_a92e4918450a403a85a503e414a58fa6_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_4beaab44168c46db9377cefd2aebcfde_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_733c480a9aa14bafb6810f61402d02c6_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_e05f7c462f66422b897f8f24d41c297f_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_ccced71221ba47948561a484d2923353_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_21773e9372fd414c8a9758cf977516f8_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_2952f86279234ec6bbaa91cdfe0e4015_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_a5fc80bce6b4403db0b80664c9067d41_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_617b8b5e710742afac2fa80fb1172063_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_47f761828ed84396b29a0216a2bb9049_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_0f38f3718de74f62ad8acde807eaafeb_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_071ea7163cff44c39f1ae726cd916b0a_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_8ce2b2953f5d40f5921d640a01716f3c_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_802924b3a2034024ae4984d71f50d5a5_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_9e2c5afa92a64fc69e8239726e0a3b97_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_a963cd709b134c7ea796fa8642018229_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_b99a13dda2ac43168fe1017a6a75efb3_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_df3b48a273d74db7a2debe50a56a7488_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_6568e058757740be9e9761b87e1ff920_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_d018a79dd9954f7d878b5a060d41192c_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://amplifyuibuilder.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_40bb6cf2a93442ac871e3536bccbe82d_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_95aed836cada48099799ec6aa6616bb9_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AmplifyUIBuilder")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_4b2214b434c747e1afdc1c61b2f82cf4_Test()
        {
            var parameters = new AmplifyUIBuilderEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAmplifyUIBuilderEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}