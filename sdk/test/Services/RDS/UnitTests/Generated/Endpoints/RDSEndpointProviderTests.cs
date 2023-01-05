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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.RDS.Endpoints;
using Amazon.RDS.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class RDSEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-south-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-south-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-south-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-south-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-south-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-south-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-south-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-south-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-south-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-south-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-south-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-south-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "me-central-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "me-central-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "me-central-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "me-central-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-central-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-central-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-central-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-central-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-west-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-west-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-west-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-west-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-north-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-north-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-north-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-north-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-west-3";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-west-3";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-west-3";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-west-3";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "me-south-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "me-south-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "me-south-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "me-south-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "sa-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "sa-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "sa-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "sa-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-southeast-4";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-southeast-4";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-southeast-4";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-southeast-4";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://rds.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("RDS")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new RDSEndpointParameters();
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonRDSEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}