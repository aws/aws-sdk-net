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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.CodeGuruProfiler.Endpoints;
using Amazon.CodeGuruProfiler.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class CodeGuruProfilerEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_f521e277e2c64947ae7876c6ade0f048_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_0e1ae9282efa4e0eb7b088cddf6ed74a_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_1cd06f76b438473688b7afde255e2b66_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_d04427191a8140a3ab90fcc7a2b9d7e4_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_8455de44e31c4dc9adde68eb57304a42_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_bb93837ed73948eebd835b32b783acb0_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_ffe711e1f20a42088a2158c52e82b5c5_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_00d0388ee9634119b3ba04367610de35_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_03bfbee315e64a00bbe4913aa17a510d_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_7bf443c878bd49f6b777bf30b42f425f_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_d78cbaa405764699a97549a788ef9e4e_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_f7a1c6c0a7404ec8950faff660b4ab3b_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_7321e00baaf14ad2ad748e2244537252_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_33bfdbbf8fb343bfa632598ecf515910_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_1379090edd124b74ab12d5e27da7e09b_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_2f0b4d991e7f4a16a3c2477eee392753_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_7df6f9ce19c14a3f8b8abf3817a44e6d_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_a31b9fe22b3f47bcab5b45c609612409_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_c5c6f032856140d6aca7022f2a72c316_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_74f041b6d8254504b01b6d02384deae1_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_c27aaa2d750b48319db575424ca6263d_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_546c580f608b4459afd1e95e1a1b942e_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_b0b66eb60b8a41279cdf98a2c1a21fe5_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_2bb116465ffe466cb16ad72618a23845_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_6253fb7fb2374816b47288425ac460b2_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_e08508f7f665428c828014639a7f7a12_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_56e14e149b2c426abb444c318e3d1b84_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_29e8487559b34be9ae902edef53cf7d5_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_fb9049dac6fa452686c2f4673b5e32d9_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_09cef137a42e48a68c6206dea2cca729_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_037a16be482148a495fffac654df73bf_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_08da62d0a2c84b7f84650e3b8c0851ca_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_925071ecb8c8453586ff8b4b18673fc0_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_054d71d8164c4edd97fc82c430bb729a_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_68faab34ed7948e784d8aae3e3f7ecc3_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_a568499ef1d2439186f4fb0790923bb4_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_e5a61b97a26544cd9fc6651e74242653_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_26ff14be85e848829c6fdfa203a693c0_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_896c9eabeb224436a81d846fec955723_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_3873c3717a544b208e98af66768cc067_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://codeguru-profiler.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_e990ab811b4f48419de78ea7ca58ef6b_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_dd8a9658f9de48708d84715aeff5b9f1_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CodeGuruProfiler")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_4e613b2b3afa44e68d1f89ce38ae410a_Test()
        {
            var parameters = new CodeGuruProfilerEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCodeGuruProfilerEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}