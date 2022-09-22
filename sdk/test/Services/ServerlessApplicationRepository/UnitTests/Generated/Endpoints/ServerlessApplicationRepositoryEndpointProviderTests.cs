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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ServerlessApplicationRepository.Endpoints;
using Amazon.ServerlessApplicationRepository.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ServerlessApplicationRepositoryEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_cbd3b18b9afe47cc85479c4577f56e7a_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_48b11c15f7a447859d7fe9c351c8bc86_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_af6ba6659db04aa68c227d666aa1d770_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_2e2fba3ac7804d1196f21afcfee3b76a_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_b1787e5b5f41434eb413aec9bec8244b_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_0c3bcbc1be2242ccaadac33dab556488_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_0215fb3614f24cc4a7f53b4b95415c46_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_0a7772b6bcea45ab967c6606e8519ff2_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_6f75408cc2b64b84bbda9f83e69fd046_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_643f8e86d13d4b0b83a839cc27efaf39_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_31182fae11cc4a4f9c329fafeb82649a_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_091e4c15b4db4065aad23a14c647bf6f_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_eb17dcda256542a8af14096faad23278_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_006f77e311424679818e189d8603426a_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_d155cb5a40bb4225b6ed416250f3c313_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_eec05f52ef3e4394bc21f255df85f989_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_de6a32c7792d4941a4d27768d9c95fa8_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_28cd43ff55d240579a1eba313895e818_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_77d9397570b8443984316480edcddcfb_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_f19cb73514e041c4a4960ad3c5b43a26_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_ba44637bd18349899eecc62824a67f9e_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_d4e40f0760494295b44f1dd4b0f84839_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_a026c14832d440a2b6174111a1169749_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_51868d6a675d4ec3aeb8e1a2794ff5b9_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_c2fe89a4f33a424cabd18b0fab689ce5_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_41560e2b93ed49439fc10be32228bbec_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_86a7f2050c33417385e107e37e7773d0_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_c2994402b6384bafb1f4afd63cddf848_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_22d4922fdd134d45b25ed44e4d7cd950_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_93f50ec0078847e4bfe17565af666c6f_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_53661330f9b44314acd2b4c3c45e6908_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_fad6fbd7e1cc44dbb8eaec4de9f0c20a_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_a0fcfefb509f41f4ac66fbac599e84e1_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_ab4e063521084635b3185dac06433ef4_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_335688d828e44821b70948bf45413d0d_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_2533264f4a7741678538405927e36ed3_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_38a3c9bfe555426181e880d326878fa9_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_6cdc17bbdbe043e78a1c6f69082afbcb_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_7018856db7eb413a8ba2f3ddfa96d7f8_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_55214617f1934c288349d952402af0c4_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_bc6cde092f7c45688c88473114e6ec45_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_d4a30617a5704d5c8b3ba14b1ffcecaa_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_642369699f7f4b06a676133031f82978_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_511086dfb7c54e9ca050d402d9dbc2cd_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_b5b4eb23a1a14d2cb31fd08f3f56dd0f_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_ad28be0d461f4d26a65c8c5960d88d7e_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_db0b9b584dec4a298bd3c894f81fd0a2_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_ad7aed653916438086aa22e274830330_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_455563414f7e4d4aba709cae3dfe971c_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_e2cc88285d3545c39969c78bc30fdc7e_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_90debacd5cec45e5afe64e25d91d81fb_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_ff1d56c8f737404cbd26df340a052fb5_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_6595600c63fa448c89f81eba485c1549_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_de6e72432b40478d836793b42fa512fa_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_e68915be01304b23bdd7a273ee25fc4e_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_99a53ed6986a49b99e6465ec56b285b7_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_473f51955fbf4fd7bf2bd29e9e1848c7_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_138abf9769a6460fa81a90888f404747_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_fe1e4e293093448a97ab8033932bf6dd_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_bae5a12d4986415b87d7fda444ef290e_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_eb47888951ae448087a840ce9d3d2b8a_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_d4f50b1dd54a43debe065f222ad87571_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_41b270104e0a42149ac5d189aad88331_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_23f62feae4db4d36a4a59a9d48e88555_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_7d0a93dabe9d40c98fbe0679c1eeeef8_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_30563d67b1e548de8b736ebe2f243ed3_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_722ceab18c1a4563b1d07fa079ff3098_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_03a7f6a4536b493aa07679b3158faec8_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_fd4ab3d63e7f458e8a596b3998f42689_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_ba1fb90fd91c435faeebcf75599f42a5_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_5baacedb8e614f4da1f715cd6cb521f2_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_3a429c013617461381408de42355d794_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_f9dcaabfdc9646a2bceec229776a97e1_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_dfdbe477f91c4370a4624644f0cbd660_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_5ccf4aace76c46179df32fd67987623c_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_bad41117a6e445838ad123645fe0a881_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_6a1c547cfd3e470db5832c9b69246079_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_9811ba26b8dd4e6b8be6fd57950ad340_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_f42602b4b04845caafb27ac7ecd4a6ee_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_1a8d7676916d4d0591a29217dc255e4b_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_0effac057c9c478e91d77227043815d9_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_dae9ff03da0145e8b1a778b9148b66d6_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_92e71c4e60a149d6809273256213900d_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_6e4e4ee7dab049f2ba0a42c2d70e6df6_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_cf7fdfc5aa4b49ab9b77f04856832e24_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_791d1929ab2a452fad40f7dea92ea184_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_b0819b3595cd45f7bdb8ea97cc916c56_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_7c7863000675465e98556ddc1a9ab762_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://serverlessrepo.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_15933c51bb17493c93b98ad2604124d6_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_548f1c37f30c4e0f9266d31e2d39bedc_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServerlessApplicationRepository")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_40fab9de99644c218bce16c77423d9ef_Test()
        {
            var parameters = new ServerlessApplicationRepositoryEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonServerlessApplicationRepositoryEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}