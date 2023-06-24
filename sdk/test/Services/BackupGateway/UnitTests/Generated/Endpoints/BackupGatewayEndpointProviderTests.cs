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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.BackupGateway.Endpoints;
using Amazon.BackupGateway.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class BackupGatewayEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-south-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-south-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-south-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-south-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-south-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-south-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-south-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-south-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-gov-east-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ca-central-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ca-central-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ca-central-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ca-central-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-central-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-central-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-central-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-central-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-west-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-west-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-west-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-west-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-west-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-west-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-west-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-west-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "af-south-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "af-south-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "af-south-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "af-south-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-north-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-north-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-north-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-north-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-west-3";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-west-3";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-west-3";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-west-3";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-west-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-west-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-west-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-west-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-west-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-west-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "eu-west-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "eu-west-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-northeast-3";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-northeast-3";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-northeast-3";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-northeast-3";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-northeast-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-northeast-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-northeast-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-northeast-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-northeast-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-northeast-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-northeast-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-northeast-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "me-south-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "me-south-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "me-south-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "me-south-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "sa-east-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "sa-east-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "sa-east-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "sa-east-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-east-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-east-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-east-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-east-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-gov-west-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-gov-west-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-gov-west-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-gov-west-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-southeast-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-southeast-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-southeast-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-southeast-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-southeast-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-southeast-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "ap-southeast-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "ap-southeast-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-east-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-east-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-2";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://backup-gateway.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("BackupGateway")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new BackupGatewayEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonBackupGatewayEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}