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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ServiceDiscovery.Endpoints;
using Amazon.ServiceDiscovery.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ServiceDiscoveryEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_9cfb2f9e50c141189f5ebd587b1ef1d1_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_0675d4144b2b40238195207a3c3db91b_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_93aa8dd779624927b918ff241357c73e_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_34a15c4587b24e32989bd3837399ea18_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_f1247461f403400580ad5d642830fdf6_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_23b16d17fc1d4e21a5da498a63ada138_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_ac731dedce8c425d880e814f72cf91e8_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_92ef98df87de43dead8ec482ca7f2db9_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_0891d882f93e4c69978e780dd37fe029_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_39d051053a89438194faf192814b3bdb_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_6a2120b2fb334b02a1517d9011311a4b_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_6aa1a654ff6340b68bf753b4dcb5d34c_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_638dfee5198c45fc853c608603175dd9_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_2dc33a10cd58446d99c04b337116c009_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_be8c7894e0464df3b35063810bf67552_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_da544532bf8344c3934e54d5206d4c02_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_abfc12e1f8674d9fb0c04473f7a4b64b_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_d0b84412e4c44b91bd8cab52a063f3d3_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_124f1f02caa84440928a33303e4a7aed_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_cbf7b727d94549e89f787e0688c3694d_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_eb40939cc92547429c69f49468fffe89_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_3e0cc6a862bd4a238229fd4ef2eb3277_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_68fe68e149e248f8993b84484e737d82_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicediscovery.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_78fac086377e4a42a83b5baeeac390b2_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_cb0561ce825447428129259c8053c213_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceDiscovery")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_92212a6c27d54430ad887c838cd16039_Test()
        {
            var parameters = new ServiceDiscoveryEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonServiceDiscoveryEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}