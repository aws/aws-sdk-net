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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.Kinesis.Endpoints;
using Amazon.Kinesis.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class KinesisEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ca-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cawest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ca-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ca-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cawest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ca-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ca-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cawest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ca-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ca-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cawest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ca-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-5 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast5_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-5";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-southeast-5.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-5 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast5_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-5";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.ap-southeast-5.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-5 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast5_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-5";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-southeast-5.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region ap-southeast-5 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast5_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "ap-southeast-5";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.ap-southeast-5.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Invalid ARN: Failed to parse ARN.")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Failed to parse ARN.")]
        public void Invalid_ARN_Failed_to_parse_ARN_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["StreamARN"] = "arn";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Invalid ARN: partition missing from ARN.")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Failed to parse ARN.")]
        public void Invalid_ARN_partition_missing_from_ARN_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["StreamARN"] = "arn::kinesis:us-west-2:123456789012:stream/testStream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Invalid ARN: partitions mismatch.")]
        [ExpectedException(typeof(AmazonClientException), @"Partition: aws from ARN doesn't match with partition name: aws-us-gov.")]
        public void Invalid_ARN_partitions_mismatch_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["StreamARN"] = "arn:aws:kinesis:us-west-2:123456789012:stream/testStream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Invalid ARN: Not Kinesis")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: The ARN was not for the Kinesis service, found: s3.")]
        public void Invalid_ARN_Not_Kinesis_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["StreamARN"] = "arn:aws:s3:us-west-2:123456789012:stream/testStream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Invalid ARN: Region is missing in ARN")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Invalid region.")]
        public void Invalid_ARN_Region_is_missing_in_ARN_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["StreamARN"] = "arn:aws:kinesis::123456789012:stream/testStream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Invalid ARN: Region is empty string in ARN")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Invalid region.")]
        public void Invalid_ARN_Region_is_empty_string_in_ARN_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["StreamARN"] = "arn:aws:kinesis:  :123456789012:stream/testStream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Invalid ARN: Invalid account id")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Invalid account id.")]
        public void Invalid_ARN_Invalid_account_id_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["StreamARN"] = "arn:aws:kinesis:us-east-1::stream/testStream";
            parameters["OperationType"] = "control";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Invalid ARN: Invalid account id")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Invalid account id.")]
        public void Invalid_ARN_Invalid_account_id_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["StreamARN"] = "arn:aws:kinesis:us-east-1:   :stream/testStream";
            parameters["OperationType"] = "control";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Invalid ARN: Kinesis ARNs only support stream arn types")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Kinesis ARNs don't support `accesspoint` arn types.")]
        public void Invalid_ARN_Kinesis_ARNs_only_support_stream_arn_types_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["StreamARN"] = "arn:aws:kinesis:us-east-1:123:accesspoint/testStream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Dual Stack not supported region.")]
        [ExpectedException(typeof(AmazonClientException), @"FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void Dual_Stack_not_supported_region_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["StreamARN"] = "arn:aws-iso:kinesis:us-iso-west-1:123456789012:stream/testStream";
            parameters["OperationType"] = "control";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("OperationType not set")]
        [ExpectedException(typeof(AmazonClientException), @"Operation Type is not set. Please contact service team for resolution.")]
        public void OperationType_not_set_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["StreamARN"] = "arn:aws:kinesis:us-east-1:123456789012:stream/testStream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Custom Endpoint is specified")]
        public void Custom_Endpoint_is_specified_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "control";
            parameters["StreamARN"] = "arn:aws:kinesis:us-east-1:123:stream/test-stream";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint targeting control operation type")]
        public void Account_endpoint_targeting_control_operation_type_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "control";
            parameters["StreamARN"] = "arn:aws:kinesis:us-east-1:123:stream/test-stream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.control-kinesis.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint targeting data operation type")]
        public void Account_endpoint_targeting_data_operation_type_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "data";
            parameters["StreamARN"] = "arn:aws:kinesis:us-east-1:123:stream/test-stream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.data-kinesis.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint with fips targeting data operation type")]
        public void Account_endpoint_with_fips_targeting_data_operation_type_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "data";
            parameters["StreamARN"] = "arn:aws:kinesis:us-east-1:123:stream/test-stream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.data-kinesis-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint with fips targeting control operation type")]
        public void Account_endpoint_with_fips_targeting_control_operation_type_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "control";
            parameters["StreamARN"] = "arn:aws:kinesis:us-east-1:123:stream/test-stream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.control-kinesis-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint with Dual Stack and FIPS enabled")]
        public void Account_endpoint_with_Dual_Stack_and_FIPS_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["OperationType"] = "control";
            parameters["StreamARN"] = "arn:aws:kinesis:us-east-1:123:stream/test-stream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.control-kinesis-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint with Dual Stack enabled")]
        public void Account_endpoint_with_Dual_Stack_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["OperationType"] = "data";
            parameters["StreamARN"] = "arn:aws:kinesis:us-west-1:123:stream/test-stream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.data-kinesis.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint with FIPS and DualStack disabled")]
        public void Account_endpoint_with_FIPS_and_DualStack_disabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "control";
            parameters["StreamARN"] = "arn:aws:kinesis:us-west-1:123:stream/test-stream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.control-kinesis.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("RegionMismatch: client region should be used for endpoint region")]
        public void RegionMismatch_client_region_should_be_used_for_endpoint_region_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "data";
            parameters["StreamARN"] = "arn:aws:kinesis:us-west-1:123:stream/testStream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.data-kinesis.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint with FIPS enabled")]
        public void Account_endpoint_with_FIPS_enabled_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "data";
            parameters["StreamARN"] = "arn:aws-cn:kinesis:cn-northwest-1:123:stream/test-stream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.data-kinesis-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint with FIPS and DualStack enabled for cn regions.")]
        public void Account_endpoint_with_FIPS_and_DualStack_enabled_for_cn_regions_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["OperationType"] = "data";
            parameters["StreamARN"] = "arn:aws-cn:kinesis:cn-northwest-1:123:stream/test-stream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.data-kinesis-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint targeting control operation type in ADC regions")]
        public void Account_endpoint_targeting_control_operation_type_in_ADC_regions_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "control";
            parameters["StreamARN"] = "arn:aws-iso:kinesis:us-iso-east-1:123:stream/test-stream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint targeting control operation type in ADC regions")]
        public void Account_endpoint_targeting_control_operation_type_in_ADC_regions_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "control";
            parameters["StreamARN"] = "arn:aws-iso:kinesis:us-iso-west-1:123:stream/test-stream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint targeting data operation type in ADC regions")]
        public void Account_endpoint_targeting_data_operation_type_in_ADC_regions_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "data";
            parameters["StreamARN"] = "arn:aws-iso-b:kinesis:us-isob-east-1:123:stream/test-stream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint with fips targeting control operation type in ADC regions")]
        public void Account_endpoint_with_fips_targeting_control_operation_type_in_ADC_regions_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "control";
            parameters["StreamARN"] = "arn:aws-iso:kinesis:us-iso-east-1:123:stream/test-stream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint with fips targeting data operation type in ADC regions")]
        public void Account_endpoint_with_fips_targeting_data_operation_type_in_ADC_regions_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "data";
            parameters["StreamARN"] = "arn:aws-iso-b:kinesis:us-isob-east-1:123:stream/test-stream";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Invalid ConsumerARN: Failed to parse ARN.")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Failed to parse ARN.")]
        public void Invalid_ConsumerARN_Failed_to_parse_ARN_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ConsumerARN"] = "arn";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Invalid ConsumerARN: partition missing from ARN.")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Failed to parse ARN.")]
        public void Invalid_ConsumerARN_partition_missing_from_ARN_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ConsumerARN"] = "arn::kinesis:us-west-2:123456789012:stream/testStream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Invalid ARN: partitions mismatch.")]
        [ExpectedException(typeof(AmazonClientException), @"Partition: aws from ARN doesn't match with partition name: aws-us-gov.")]
        public void Invalid_ARN_partitions_mismatch_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ConsumerARN"] = "arn:aws:kinesis:us-west-2:123456789012:stream/testStream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Invalid ARN: Not Kinesis")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: The ARN was not for the Kinesis service, found: s3.")]
        public void Invalid_ARN_Not_Kinesis_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ConsumerARN"] = "arn:aws:s3:us-west-2:123456789012:stream/testStream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Invalid ARN: Region is missing in ARN")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Invalid region.")]
        public void Invalid_ARN_Region_is_missing_in_ARN_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ConsumerARN"] = "arn:aws:kinesis::123456789012:stream/testStream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Invalid ARN: Region is empty string in ARN")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Invalid region.")]
        public void Invalid_ARN_Region_is_empty_string_in_ARN_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ConsumerARN"] = "arn:aws:kinesis:  :123456789012:stream/testStream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Invalid ARN: Invalid account id")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Invalid account id.")]
        public void Invalid_ARN_Invalid_account_id_2_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ConsumerARN"] = "arn:aws:kinesis:us-east-1::stream/testStream/consumer/test-consumer:1525898737";
            parameters["OperationType"] = "control";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Invalid ARN: Invalid account id")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Invalid account id.")]
        public void Invalid_ARN_Invalid_account_id_3_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ConsumerARN"] = "arn:aws:kinesis:us-east-1:   :stream/testStream/consumer/test-consumer:1525898737";
            parameters["OperationType"] = "control";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Invalid ARN: Kinesis ARNs only support stream arn/consumer arn types")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid ARN: Kinesis ARNs don't support `accesspoint` arn types.")]
        public void Invalid_ARN_Kinesis_ARNs_only_support_stream_arnconsumer_arn_types_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ConsumerARN"] = "arn:aws:kinesis:us-east-1:123:accesspoint/testStream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Dual Stack not supported region.")]
        [ExpectedException(typeof(AmazonClientException), @"FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void Dual_Stack_not_supported_region_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["ConsumerARN"] = "arn:aws-iso:kinesis:us-iso-west-1:123456789012:stream/testStream/consumer/test-consumer:1525898737";
            parameters["OperationType"] = "control";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("OperationType not set")]
        [ExpectedException(typeof(AmazonClientException), @"Operation Type is not set. Please contact service team for resolution.")]
        public void OperationType_not_set_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["ConsumerARN"] = "arn:aws:kinesis:us-east-1:123456789012:stream/testStream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Custom Endpoint is specified")]
        public void Custom_Endpoint_is_specified_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "control";
            parameters["ConsumerARN"] = "arn:aws:kinesis:us-east-1:123:stream/test-stream/consumer/test-consumer:1525898737";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint targeting control operation type")]
        public void Account_endpoint_targeting_control_operation_type_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "control";
            parameters["ConsumerARN"] = "arn:aws:kinesis:us-east-1:123:stream/test-stream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.control-kinesis.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint targeting data operation type")]
        public void Account_endpoint_targeting_data_operation_type_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "data";
            parameters["ConsumerARN"] = "arn:aws:kinesis:us-east-1:123:stream/test-stream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.data-kinesis.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint with fips targeting data operation type")]
        public void Account_endpoint_with_fips_targeting_data_operation_type_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "data";
            parameters["ConsumerARN"] = "arn:aws:kinesis:us-east-1:123:stream/test-stream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.data-kinesis-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint with fips targeting control operation type")]
        public void Account_endpoint_with_fips_targeting_control_operation_type_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "control";
            parameters["ConsumerARN"] = "arn:aws:kinesis:us-east-1:123:stream/test-stream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.control-kinesis-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint with Dual Stack and FIPS enabled")]
        public void Account_endpoint_with_Dual_Stack_and_FIPS_enabled_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["OperationType"] = "control";
            parameters["ConsumerARN"] = "arn:aws:kinesis:us-east-1:123:stream/test-stream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.control-kinesis-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint with Dual Stack enabled")]
        public void Account_endpoint_with_Dual_Stack_enabled_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["OperationType"] = "data";
            parameters["ConsumerARN"] = "arn:aws:kinesis:us-west-1:123:stream/test-stream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.data-kinesis.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint with FIPS and DualStack disabled")]
        public void Account_endpoint_with_FIPS_and_DualStack_disabled_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "control";
            parameters["ConsumerARN"] = "arn:aws:kinesis:us-west-1:123:stream/test-stream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.control-kinesis.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("RegionMismatch: client region should be used for endpoint region")]
        public void RegionMismatch_client_region_should_be_used_for_endpoint_region_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "data";
            parameters["ConsumerARN"] = "arn:aws:kinesis:us-west-1:123:stream/testStream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.data-kinesis.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint with FIPS enabled")]
        public void Account_endpoint_with_FIPS_enabled_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "data";
            parameters["ConsumerARN"] = "arn:aws-cn:kinesis:cn-northwest-1:123:stream/test-stream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.data-kinesis-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint with FIPS and DualStack enabled for cn regions.")]
        public void Account_endpoint_with_FIPS_and_DualStack_enabled_for_cn_regions_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["OperationType"] = "data";
            parameters["ConsumerARN"] = "arn:aws-cn:kinesis:cn-northwest-1:123:stream/test-stream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.data-kinesis-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint targeting control operation type in ADC regions")]
        public void Account_endpoint_targeting_control_operation_type_in_ADC_regions_2_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "control";
            parameters["ConsumerARN"] = "arn:aws-iso:kinesis:us-iso-east-1:123:stream/test-stream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint targeting control operation type in ADC regions")]
        public void Account_endpoint_targeting_control_operation_type_in_ADC_regions_3_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "control";
            parameters["ConsumerARN"] = "arn:aws-iso:kinesis:us-iso-west-1:123:stream/test-stream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint targeting data operation type in ADC regions")]
        public void Account_endpoint_targeting_data_operation_type_in_ADC_regions_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "data";
            parameters["ConsumerARN"] = "arn:aws-iso-b:kinesis:us-isob-east-1:123:stream/test-stream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint with fips targeting control operation type in ADC regions")]
        public void Account_endpoint_with_fips_targeting_control_operation_type_in_ADC_regions_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "control";
            parameters["ConsumerARN"] = "arn:aws-iso:kinesis:us-iso-east-1:123:stream/test-stream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Account endpoint with fips targeting data operation type in ADC regions")]
        public void Account_endpoint_with_fips_targeting_data_operation_type_in_ADC_regions_1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "data";
            parameters["ConsumerARN"] = "arn:aws-iso-b:kinesis:us-isob-east-1:123:stream/test-stream/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://kinesis-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("ConsumerARN targeting US-EAST-1")]
        public void ConsumerARN_targeting_USEAST1_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "data";
            parameters["ConsumerARN"] = "arn:aws:kinesis:us-east-1:123456789123:stream/foobar/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789123.data-kinesis.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("Kinesis")]
        [Description("Both StreamARN and ConsumerARN specified. StreamARN should take precedence")]
        public void Both_StreamARN_and_ConsumerARN_specified_StreamARN_should_take_precedence_Test()
        {
            var parameters = new KinesisEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["OperationType"] = "data";
            parameters["StreamARN"] = "arn:aws:kinesis:us-east-1:123:stream/foobar";
            parameters["ConsumerARN"] = "arn:aws:kinesis:us-east-1:123456789123:stream/foobar/consumer/test-consumer:1525898737";
            var endpoint = new AmazonKinesisEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123.data-kinesis.us-east-1.amazonaws.com", endpoint.URL);
        }

    }
}