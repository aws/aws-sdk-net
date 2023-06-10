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
 * Do not modify this file. This file is generated from the sagemaker-featurestore-runtime-2020-07-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.SageMakerFeatureStoreRuntime.Endpoints;
using Amazon.SageMakerFeatureStoreRuntime.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class SageMakerFeatureStoreRuntimeEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://featurestore-runtime.sagemaker-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://featurestore-runtime.sagemaker-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://featurestore-runtime.sagemaker.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://featurestore-runtime.sagemaker.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://featurestore-runtime.sagemaker-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://featurestore-runtime.sagemaker-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://featurestore-runtime.sagemaker.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://featurestore-runtime.sagemaker.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://featurestore-runtime.sagemaker-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://featurestore-runtime.sagemaker-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://featurestore-runtime.sagemaker.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://featurestore-runtime.sagemaker.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://featurestore-runtime.sagemaker-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://featurestore-runtime.sagemaker.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://featurestore-runtime.sagemaker-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://featurestore-runtime.sagemaker.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For custom endpoint with region set and fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_region_set_and_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For custom endpoint with region not set and fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_region_not_set_and_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("SageMakerFeatureStoreRuntime")]
        [Description("Missing region")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Missing Region")]
        public void Missing_region_Test()
        {
            var parameters = new SageMakerFeatureStoreRuntimeEndpointParameters();
            var endpoint = new AmazonSageMakerFeatureStoreRuntimeEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}