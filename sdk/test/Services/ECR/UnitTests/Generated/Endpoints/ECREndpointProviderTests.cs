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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.ECR.Endpoints;
using Amazon.ECR.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ECREndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ECR")]
        [Description("Valid with dualstack and FIPS disabled. i.e, IPv4 Only stack with no FIPS, with special prefix")]
        public void Valid_with_dualstack_and_FIPS_disabled_ie_IPv4_Only_stack_with_no_FIPS_with_special_prefix_Test()
        {
            var parameters = new ECREndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonECREndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.ecr.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ECR")]
        [Description("Valid with dualstack enabled")]
        public void Valid_with_dualstack_enabled_Test()
        {
            var parameters = new ECREndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            var endpoint = new AmazonECREndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ecr.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ECR")]
        [Description("Valid with FIPS set, dualstack disabled")]
        public void Valid_with_FIPS_set_dualstack_disabled_Test()
        {
            var parameters = new ECREndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonECREndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ecr-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ECR")]
        [Description("Valid with both dualstack and FIPS enabled")]
        public void Valid_with_both_dualstack_and_FIPS_enabled_Test()
        {
            var parameters = new ECREndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonECREndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://ecr-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ECR")]
        [Description("Valid with both dualstack and FIPS disabled (Govcloud)")]
        public void Valid_with_both_dualstack_and_FIPS_disabled_Govcloud_Test()
        {
            var parameters = new ECREndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonECREndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://api.ecr.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ECR")]
        [Description("Invalid with DualStack enabled and partition does not support Dualstack")]
        [ExpectedException(typeof(AmazonClientException), @"Dualstack is enabled but this partition does not support dualstack")]
        public void Invalid_with_DualStack_enabled_and_partition_does_not_support_Dualstack_Test()
        {
            var parameters = new ECREndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-isob-east-1";
            var endpoint = new AmazonECREndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ECR")]
        [Description("Invalid with DualStack enabled and FIPS enabled and partition does not support one/either")]
        [ExpectedException(typeof(AmazonClientException), @"FIPS and dualstack are enabled, but this partition does not support one or both")]
        public void Invalid_with_DualStack_enabled_and_FIPS_enabled_and_partition_does_not_support_oneeither_Test()
        {
            var parameters = new ECREndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-isob-east-1";
            var endpoint = new AmazonECREndpointProvider().ResolveEndpoint(parameters);
        }

    }
}