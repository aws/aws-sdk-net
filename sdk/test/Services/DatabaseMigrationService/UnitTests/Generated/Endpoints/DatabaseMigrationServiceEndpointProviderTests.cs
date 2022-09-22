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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.DatabaseMigrationService.Endpoints;
using Amazon.DatabaseMigrationService.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class DatabaseMigrationServiceEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_080e17fea5e64d4aaa62e0cb306a8021_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_c2e24217e6874bbb87ac5d1bfc17a90f_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_0a3917217cf24187bdbc632265cbe101_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_31ba930fb84f4c97a1065a08ce38f753_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_ac3e649899e94bb49f6aa44e9c569742_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_435ae44406ac4ace911df65d35f30c5d_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_16c8e8d5a926416caceabe9f7967169f_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_0ada0d5df96140f1a5264c5511e9102a_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_af8d273625c74818aa44170b788a3721_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_71d93c2fd85e48d3a20813e072bd7155_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_88f65d83602b4d6084d23d160b66029b_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_aa93ded1dcd742159b9cb56266e8fb6f_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_c1ef8ea3bc0d47beb92779aad6b6364f_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_ac971419307848b2bf4371a454f2d97b_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_3c1aba3d6899439d941c7f2e323616b0_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_ec0722c31cdb4d96965ba279da6ce4d4_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_397bdc5a05db494fac6fef3bc278a8e9_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_7c7b42e155d34c6e95beec175d180b1a_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_c1137cd1bff344d98bc82102459cfc8e_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_d552f421981d44729d5c67e0726d9343_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_1a988b6f2ee84f5bba42d2cb53d4d5a9_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_2eea1c21c9de44ceba131458cb9ba3ed_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_3eef0b58f1684e5f9708e28d051b098f_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_81d635af3b0c4be38b6d7cdf0fd761b6_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_672eed4f5db14905b8cb5af67068996d_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_8a3697ec180d454a9c47c42715dcf7ae_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_2edb8fe82bab4a4a99e80f80cc122535_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_50bde2e9edcf44f8a5b8b3c0f4c2ad35_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_65f3bf6578dc45068958308d2b76ecaf_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_d41e688648fa4d05abeb85dfbba15dc6_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_7c8728db75e544229900758d586d41b8_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_42e9a51aef93440f8bf846c6a1d9c21b_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_890141f7b029493e90c80a36931754d2_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_45dc893faf994e72a21f5ce5b7fc3f5a_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_714d8c9c931547dd84d39089f3e0b856_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_176da59e3eb94537b84c879e700ae070_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_d2fc410edc5f42b28fa212c6ab7f3fc9_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_0b4b1eaff185485bb637d30b648fd135_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_a5bb40b68558432091e01ff6dd83a794_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_8a1b709bbbb84df4a65a2c269cc5185a_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_7c9c77d3579246e7b5f8508285aea02f_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_6507d9be3b214aa39c6bcbeafff9dcb1_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_6b381d4a1f854e9a9195c49ba030e868_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_03df06531c264592a6e0bab6d004129c_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_282f17ed61a24f20b9c05fb259fd5da7_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_47fce203a70343e68f7aa8a5d3d20b7a_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_deb28351d509475e801bbb220b357871_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_957fa8e545b94b23b92a8384daebd9fe_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_5e3c274fba2644748c0bc58fa5d12fab_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_9393a6445c184b89ad973921d25d29d7_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_a8d6abf7738d455dacb6048acd4b134a_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_02648b0df2ce467095323f90c3c237ed_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_67b8a3234d5845f4af4445d61881f2ae_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_c24f5b00a81f4614bd64b2d9197a5b07_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_b93218e55c954f03a8d46faa550a90cc_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_280a33c2fff347d28a8e504fe4bf611c_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_c627d2c3bfcf441faa686ebbcb951322_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_122f3b05aa6b43a181a87b2cef24c834_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_bfef8d508e8445499a785878f07c9d62_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_120ea376a02048d5ac927087dade5cea_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_18364ac0ea2e41499ea03862811df9c8_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_761cc66f810f47efb8d5efbd13898f58_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_1d7366a5a1df4922a52728bd3f68019f_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_cd4b273a6c2f40a98141fa07d3fa5c36_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_b4aece6cecfe4942ab49d366d208526d_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_7bb161ee129c4760ba1cf7765a75c348_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_ec0e39acda014cf2bf011b42fa93c658_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_0379e52610f4469da3d02f6e9748a718_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_e5571ec8f0ae4154bbff6503d6ebf567_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_e789c2a352674f6cbcd890d5118e140f_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_e6e106d124b34268ab3a175df678aec0_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_68b65adc08424912a9dc343b96af3800_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_6861d3fc38a6428d83273704d79b61a1_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_ca536032fc344e61a87433e216928cfa_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_b0a16995b0d04c28a8a10522581cbbc5_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_65f1b58dadf442988999d9e40ff70cb9_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_3e147881ed114a3ea3ad8d043a3aa0ba_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_964c29b53b664e749cd15b966f97dde0_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_de74734191fb4bb68728415f6c41532e_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_d10fea10145c451b8083fc19cda10458_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_385adf4a8dd3423fb88141565200d574_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_ec3e006022e843fe867f0c2111847550_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_b9b610f75f944e02b9107d7aa6c549ea_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_3d69123fb5ed4337aed31fcbd62f3993_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_27e8d3d3747f460b875e96f484a53867_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_5a05494d6fae49aa8d7819435e063ff7_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_1fae82214cbf46a6a7eb35fd7ce0af90_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_3b14ea83c0f347a290178cff32040e68_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_46fd53410ad4400fac3f345f5eb2c8e2_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_954747fc17f4426991ca0341d2e599e0_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_b6631099cb3c4b4b95f0b4cd142356f2_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_bbaa9ad29cfb4a4c9addf558465c21a3_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_bf0f89e45aa34175b479a388a04088db_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_c45fa4a09e6c4d94a72d25189aee0f9d_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_92ace621392743609ebf53a16f1795d0_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_08974c82445e490e80c9f71c30d9cb28_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_3f73a8fbd5b64ceebd22b6664e17cd28_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_8a116f29e6484673b8a723da55592ac3_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_2cb541a8c71043a2bbc6d3316b7fdec3_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_d1368aba4c254368ba2240e4198ecd3b_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_81729ae8e42d43979e4e92dfce6aa2da_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_2e5527981ca44e0e92438018591e7e9b_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_d7e8f5a7f454408aa7859951509dfc06_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_8c49b27a2f864ea594f4cecd332a3620_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_2f961db3252c43299e20ff663a225b74_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_1324d40cc7c4442091ca1a579bcd4c48_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_fed4fb1af4904ed5aeb0e605c875d756_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_2ce5b47fe70945009ea2e8b00af4d48a_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_f7ba85d6225e4fb6ab3d9fa8db90b63b_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_fb4785c98fc94247b602d3dedc62381e_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_c64722f2599f4777937850e1a392b19a_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_04831aa4733441d59968ae46f1c3a9dd_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_enabled_c0aa04990dba4e198a145f2763d18efb_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_disabled_498f518001c347b5b07226d537257e36_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_enabled_80a2f7176d8d4d4aa7c4d48901e44dea_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_disabled_dacbd11402924c8fa05615c277887ecc_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_f69ee521819d406e8edab923dad95a4e_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_6aa3d6f80f1b4f87a8a3a10c8561f15a_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_498c0596d8ff456385f264eeeedc33ed_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_83696d7cebde4929899d9322cd70190b_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_ef308ee6ae5440078ac537b18632544d_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_b397a3d0904e4ae2a2bbb8176b94c1cc_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_cccad97e24eb48bba3b3b03cce662220_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_0feaa071b06a4dbfad29bc6376cb1474_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_3d5081f504f64a52a0c3576ea34167cd_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_14d689ad697f4d178c9e8735e07a4a94_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_473f2aa53d42495bbef311a3f79e8821_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_b7753e6dc62a41c3ba16ff6ecd56c999_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_bb9fd92cdf91409baa20d27c0190f84b_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_d9aea6a271d74796981b28741740365c_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://dms.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_6c53f1af28474d8393b97b77d7e7615c_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_4cdd669e3bcd4bd4bff2e676904c9b90_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("DatabaseMigrationService")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_23e36f9b790f41ca8550f38c8feaa750_Test()
        {
            var parameters = new DatabaseMigrationServiceEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonDatabaseMigrationServiceEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}