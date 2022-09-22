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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.AccessAnalyzer.Endpoints;
using Amazon.AccessAnalyzer.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class AccessAnalyzerEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_e8253b923fef48d0b1145f889e7c3820_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_100914dfdb1c415d84d17d0aca71b93c_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_662610251728420c820a697e2416a039_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_8f3584120f0042c2bd1280131c40467c_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_dc597709539d4bebb4e7a032813b47aa_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_4e88aa9df10d4f649d7003d9fa644565_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_e42e0e506d68461eae3313a991a01a3b_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_43f857763e7d43e7915a626cc3354820_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_d6889d3f457b47fda52a0e4a41a7b435_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_d3da9f4c99584109aa13eb0db0746687_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_0c8927f2790b4709b039b0271209f42c_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_d59622dcad65471490d8225205816af4_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_7d0572f0160143f781cd4aa24536e7fa_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_6b3af2b8f3c048658b4b1dca67e0a118_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_a02a3f6a7c02494ebb3d5ba30fb0112e_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_df80a49b801c40f69e088586a233af83_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_5dda32393fd34e3d93abc191b7121133_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_bf9ca3f5d500479988fa79cf69dfa380_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_d87db9a24c7f47eba666e8984a3be261_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_518b808dd81c47799027dc01807ac735_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_393016d66d9e42378defde2cd5b76e8e_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_4c62663e064840d2b0a1501e6edc5351_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_4056fd0d9cbe45f79e317accf59814ca_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_598f07825e8f45c8a711f218e1214cc1_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_b2c2f798c60b4c7a92c028f895e4183a_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_44ac675e67aa44f8b051becb5659abac_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_d1134c9a739747f2bfe0df77ab91eecc_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_6d950b67006844fba143b7ad6fade67c_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_dbf04997a9764459978ebc45cce0c2fc_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_557f7cc644c940b0a75a77fad442396a_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_9982bfccf823470f896853b12043c769_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_2debefe9f44d4c679080d8778b320e60_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_0639de4b7f25482dbe057efb8d0d0e0f_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_42a9357d68324b049fc68dbdcee922d8_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_08a593b059294d1f932a1c6703e00059_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_a951f9e7ff07431682ebbd30b3dfee04_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_926ea4555729458e84eaf5afb161a4eb_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_bebc98fae63949829e717598af9c86d3_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_e3d0edfb583942a185c55c85349b628d_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_5d312a4ac60b445e8202229ca757357c_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_700f56be4cf14905b9bcb0c7bd432a6c_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_1129b0c23ba3412ea11b157683153c75_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_2caa1bf0b8374a4f8d6e28b70ed2e402_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_b664473f37ea4d3583d32a867d8adb38_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_c5062b78ae294b2483e35d41c9731447_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_dd505e34abea455eae9062b1696aa041_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_37a6d67bec044d63a95107b46aa77a0e_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_2fad5829d14d4b47a7c4d9bf73cd7f9e_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_e7930e6f0e8c497b8a9f2ec1cb7dc0bd_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_421247177d24429f866c5116ab113b91_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_dac5c0597a954feda25057953d304eec_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_b79973ed0ea349f5abdaa632f6c54b3a_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_6f549ef3ef1b470ab9d23ce566248e1b_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_02ff80e518f44b0f9efd9bd86eeaebee_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_1294e752280d40e4b8d54fa6d20cee06_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_61ad52e490444c4b9e1dbbf262adfc15_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_bde02a7634b74d06b0ee3f6b2f60c9e0_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_96311759a3064f109a1d10a9e5494b8b_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_f72d211cf2ec432e8f0f6ada12757760_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_51e996bb61eb4d0288deea7b105c12c6_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_80c7b0773f54461eb6e79ffeda9cd3e3_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_40ac11e5815343d8b386c5c2811eae2e_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_47139e7670324093ba28f71ebcb45cf8_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_02e4556bb94b4dd1914c26d91d722b13_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_224d323998634595bfe51ea5e820c270_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_592a47a051504141988d39fba865a432_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_7ec3435baa2741da82380804409f37a7_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_7c829d21bf304140bf367b862f54f808_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_7ae63811d120462a969df27713fc74ee_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_029041e21af549deb317078c52259607_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_d42b62e8fe5e4bf48e9bba0198dd87dd_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_e4bd80372a51492f8f227e03a623d443_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_b1fcb914a0754cc989aef3522701e2fa_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_38568266011b4d4a920a90c96d5948d7_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_30b3ecb35116490899b133609a3eaf5f_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_b5838468de13405c8add543517ff1297_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_cf6f6ab904934ffdb949b62eab8f8180_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_63c0e3c8b3a349ee9d5147d76c38a5c8_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_4e8507c3bee9450cb3047c7bb55acf06_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_e3582afcbf734b05995b06e97146a7b9_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_1792f9478dbb4402ad4f1052b0e12465_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_4e7c5e97e9244fb4a1570d5e2470a195_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_18726915d0834513951dd3073c75bfc3_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_3da1719dbd92415aad16b1ece95e0528_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_fa945e728db44d7591901e5f8eb438d3_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_5f39080b428c499f8c5ca1d64350be62_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_8294bd264f024603adb606817c4a29de_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_dddb56b285b04e879171b26afc09793f_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_5f2e296c1654476db3ee8577985be792_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_889cba7ef1e149c3b07fd96e652b50a3_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_9fa3b59a668746a5a291a24fe00a99c0_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_c6b1ae3a66ac466594839e5ea3711605_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ca-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cawest1_with_FIPS_enabled_and_DualStack_enabled_8296c2f86f634f18aa2b2eb91145db0c_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ca-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ca-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cawest1_with_FIPS_enabled_and_DualStack_disabled_305db0e43c5e42da8c09dca82d11bc3f_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ca-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ca-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cawest1_with_FIPS_disabled_and_DualStack_enabled_312e1d37b3c04b11a1ed4a30f73ac9c4_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ca-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ca-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cawest1_with_FIPS_disabled_and_DualStack_disabled_44a1ee2b7a4d4bfc91bcd8616be4f56b_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ca-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_a6a25eacb37b4783954a3c8d217055ec_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_71e12f3b5f1b44e8b286dfc0d6a2f82c_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_abbc583e1fed4193af56b42945d7af2d_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_6fb8a0ad2bf74bf1a609474c0327d5e3_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_6823f8b5ba0b465e9e55eb1c598885ef_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_a19f40fecbad4092a0fc606e93592caf_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_7774ba7e00d04ad989e7221244fbfe3e_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_4f7b1dcb65c14021971239f4999f4368_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_ab639aa13967400cbe41de75c70a5567_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_9f8a349ffa9b4827a1efc6a34a16a8ef_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_544ee9b53adc4d5d8d42f7165e0b9479_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_73844f41ac374c109d66b285ff71d545_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_e3713bf402384bd889431139b10b8a39_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_89d686c0f58341b0921df116bfbcd9a3_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_fadde4fdc2b744dfb563ecebba508576_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_ca4ac5b3b08f4bf7888bea8ff4a681a8_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_enabled_d1e5d6ae7e1949fc9caa967e32311f8d_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_disabled_2758d8bcc56e44dcab36904061f6688f_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_enabled_a5d52615aa6a4dc1a526fb151d46f81d_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_disabled_32385a4630e54a00aaf1430c19731b5c_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_4c53e2ba8ac4494c8f7d16e982f85032_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_3fedfaa9a81446beaaef9c7b102d0ae8_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_7696a7162bd74904b23cf0056b2557d1_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_32a3b7da2ac940e1b58cc8a76f850304_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_dc41fb69e98a4eaab78e7f6132945129_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_7ccb7a22e89e4cd7bbb3b194f911680e_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_24bf68b0c0404c53a483a808fe6b1573_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_d2d6fbc84a544105abb7f276c8367a97_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_b6abe35f1e9341938298ca289a12fcf3_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_638f52415e904282b258860aa8cafa3f_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_b94da452d99d410e9dad8f71a15be356_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_3e159e21a7d549f2ac34068b9230eba0_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://access-analyzer.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_f07765fea91c4274b086151efcc8d877_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_579a5eb943d74b919cddb4c4dcca6071_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("AccessAnalyzer")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_fdca58f3b32441dd91cab0900cc50ec1_Test()
        {
            var parameters = new AccessAnalyzerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonAccessAnalyzerEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}