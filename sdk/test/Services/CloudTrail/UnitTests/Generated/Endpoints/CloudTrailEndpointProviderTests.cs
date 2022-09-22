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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.CloudTrail.Endpoints;
using Amazon.CloudTrail.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class CloudTrailEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_e7ff885b367746b4b08b22aee5d2ccc2_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_869d44b03eac498faf3aaf19e6610092_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_8d9aa67c77a64ae89a7248c5afcf3b3e_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_f12d26df522b400286e35b4771b32da1_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_f46562fdbe9545c3ba48805816bf5956_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_37ee20eb5493442dbfd4ca4580ab1fac_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_55adc2df1e8e4162a12c9c1b01bde14f_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_d6d0910d72d647cea6c4e6a655c6a3bd_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_e45bf3fd00d149d0ae5e779267f31b5b_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_7b678cde96b94bd29ae93a5064dcc409_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_d4d53e755329479398b7bea8bcaa4f1a_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_717b37a94a0d4dbabd36dfd86eca6e46_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_56811b074aa24da3a18338842c352d3c_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_0c95634235594aafafea41e7ad696365_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_1f1768608f2e4c9ea1a6912638efff68_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_863d2fb321dc40aebda4c2a746a74df7_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.eu-south-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_43e79742dff14759a07406c06aac6342_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_f56a99bb1c8e495bb1d985029315277b_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_235b2210d19f4c74840d2a48fde27a49_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_20478c63a0324831abb62f8822c59003_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_20989d593f5046ccbb68b116105c740d_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_9a72d42823ae41ed9069310eb638c124_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_93703c92f69e4e81993cc52d48ba0309_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_64a11b52c40c43dea68484058a8f2c26_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.me-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_1ba96ab487f249aa953547ad27adac26_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_90d9215b217d4d47a860566d947bd2aa_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_e14696afbce847caaac8f8d0e3b35f09_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_3cd329b5ae094f119493c34aa099284e_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_86787ca973244c909cc59f38305e80cd_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_9e6e89178a8341f2b3f8b83543a46c91_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_ac2ae6f3021a46d1831c5f50e82fd921_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_7c8bb100d5e84e5eadfdcb923466e53f_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_enabled_6fb2ee26730b499e8233f821779fa20c_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-iso-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_enabled_and_DualStack_disabled_21d861da958d4d66bfd837a4719c9249_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_enabled_028309c18dde4046bea0420d2e8916d4_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-iso-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisowest1_with_FIPS_disabled_and_DualStack_disabled_affc969ce39347a58fbf8bf3cb0c50f8_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.us-iso-west-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_d8c499beab3c47c5a6795f83f0b4b448_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_ec67fba47cce42af94012fb82a26fd76_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_409645db1dc5401fadd7c06233d8fa56_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_ae88f39dcdbe46f6873faca1c0c8b4ca_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.eu-central-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_9c54254ae8bc42b995e060172b960772_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_fced31a4c2b84086b89fbde7ee50f6f6_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_084d2c703ff444e6aa04146aa1fd065e_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_460d25a8c9ea418696d5e020c01e3922_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_18724bcc334d41889193ac9118352738_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_173a9f0c7b724cd2b86072a32ca93366_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_bcd9e66fbcd140268111e80c4f99f554_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_fe2fa37e92fb467dbf98a348b0b205e6_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_44521cdde8754a068db0a3c4eb1a9070_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_62d17a917efd4062a13bfb8a3ba38d2a_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_b8a82efac7694df2975602b6f0f7df21_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_b00bf82804d6403ba6291bc755db0668_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_f31e29c754624d0cbbd0861074246cce_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_4d3cb5d8300d4a1c9f09eff1a6b2f4d3_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_cc4ba8f8edc7406f991a859d27ee0d8f_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_979b925993d84d34bcd7dd27c78d2ef4_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_113fc2b1edca4385897bab271669102e_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_d3dfda1fa0654f788ec67d6076dbce75_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_b68be504581a4e8090dde540ff70a56c_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_ac1955d7a2ae4631a13bdbd49af314ac_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_b163e087eeb34c389925fb03ffafdece_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_7cfaa3dde9da41debff861824bb6e03e_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_61354b87526a440bbe4d7da633b19295_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_026a7f06c3af4fa4bad1f66647e73532_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_cd09e7061cfe4eb7af041036e9ba8e79_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_1a692dffad0748b98a37866f8d82c98e_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_b5dc6278155042d9a45efe7d463d502e_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_8bf67f59ea5247c39f7671e5ec8fb339_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_20c0e290cc514b5e883e853d3ff9be69_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_dafc5d1df274497ea16f258c849f0a55_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_c36c55302e674341a12a399d27e4b096_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_7f4bd75f40a048ac95eabc6b9bd22ad2_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_e15fb2c3a74f423c9de229f64060a2e5_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_6d48a88334074f0e951176d5cfd009e7_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_36e8b1f440974e2eb651d7f6d2a0fd09_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_70290c58c5c64fa4a4aa991b2d9b5cf9_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_f7181e3719f64fdab46b892e047412f3_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_4405d99ee8ab4d6eb1e08be688626e78_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_2362fcd499184777a35966de212e764c_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_82316ce831594fddac4038b5681ce330_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_83f666ca27d5484fb4f62d1deaffbbd0_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_2c8cdfc621da4fd5932d0864496f55fb_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_ae57f0c4c62d4aa496565f747e105b16_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_b127289789f64dc9ba04951194120127_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_c94a8c301b274141826b7566b49788ed_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_947510bb434546ccbec47d838e318c13_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_e536a3c574bc4fe8bd4d1b6aa5ea6261_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_c96208aecc3b4dd083333bd499b05c7b_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_977a35173e7346cea223eae3f2ea0792_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_aeaffaa043ec4f8f81a089b3794a226e_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_c7d5ab5174bd499a969428b50032771a_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_0aad96dd07f14bf182d6efa7ace95fce_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_20b3fad568c742e68415c5f816e49392_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_bb8c1a04045c45949543c9e86c55a239_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_df1804c6d8f145bf8150fac2696a29f8_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_f50c912a83a74cca819c6367fd01445b_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_e52e9148b05e47bab9ac5df877f97726_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_6d411818ca4c474589d53dcc679216b7_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_54854cb803ea4bdfad022f7b48d6cb46_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_a25301ceca9b42e9bc56770c8e9c5ce8_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_dee620b8150048f984c5fbb377ac884e_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_65987dab27814c6096c09bbcd72054a5_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_6ecb2cd96d364f2ea38f1376029757cf_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_7fec8fcc0a6a423891fd5192888b9c2b_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_d26da1119f6444a0859ccd179047a316_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_605bbb330f484586afd7850cab92f016_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_ea4f24cf0d62400596bd292c4384f1f1_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_f79de51edf534dee8f516f4912e25281_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_134152cea6564061be928ed3ae86129c_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_8504ffbd44374e43a6084b88598e233c_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_b89c5ca8a6a54f82b89209fe6c91cb62_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_0a19de3654c44f4294f22767397a612c_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-iso-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_9fd60b4c15af4d42bb2ef6d9b36b62f7_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_fa943bdc75254f819ff977a4e8ce9c68_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_ba0eabd80f9f41adaa1d9be74a71fa61_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_06f7dc72462248ccb918b0514df24a9b_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_enabled_22f238a1a6864e4abb4505385975b915_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_disabled_761c3c8878534c5ab2ba41ce88d5400a_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_enabled_253baa02a2ad4c7c923ea87c5e26a29a_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_disabled_5781a3457dbb4f67b701fbd85b33b1df_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.ap-southeast-4.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_f49a7ea147734c53b7bca10965a8acb2_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_0bbf67e2a90b4f969d5630ed426471f6_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_1453aa97325d49a18c8a33925307f86d_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_5445136f6f6b4f979a16863d65151450_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_f765da8b8a3d474ba790df862068b766_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_baf024eff8b645ca838fbdab3c97b7c2_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_e563919f20d94a3b91a7b860d489bd11_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_393001a7e19a4a92802d024b6c49e2b2_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_3b80edf6f2514389852162963b96c600_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_10457292164f432e9e10cf93bd2a1079_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_0d1f997a2dbb450498269fadd6815646_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_688ffd7591cc4c2a895f7989be4a03af_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_346570dc99704c0cbc92e3a4cd8d235b_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_dd8580e9f42040f5aefa35d50737e292_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), "DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_2559656137e64e178440fca5cd94a1c8_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_0b79fb069cff48eea493d444afb3adf2_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-isob-east-1";
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://cloudtrail.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_b986c94cba04450597cbbef0e17365c7_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_2449d16c976b420ba0ba201fb2d1aa4a_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = true;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("CloudTrail")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_918a240e960f4268a038f351b6937f26_Test()
        {
            var parameters = new CloudTrailEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonCloudTrailEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}