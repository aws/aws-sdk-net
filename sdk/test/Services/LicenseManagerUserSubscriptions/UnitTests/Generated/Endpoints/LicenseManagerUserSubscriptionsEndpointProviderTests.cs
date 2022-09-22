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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.LicenseManagerUserSubscriptions.Endpoints;
using Amazon.LicenseManagerUserSubscriptions.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class LicenseManagerUserSubscriptionsEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_72dde344d911426c9001ec39ed017488_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_de9ef12942ef4644acb8c698c0a1afae_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_2cccb3ded0cc40d4b174255f3c286779_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_0f887198626b45a1892f417bb9bc8102_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_c3710158f4a74eef8d88d522ebb85e6c_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_c31b58f4bcdb47b0bd9890e4b8ca5c68_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_6156a04bbc064947bd6e85303cd01910_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_cd4c15c34cae46bfac4116cce1afc72e_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_4fdfcc0519c541f4b76dfa3bfbb5513c_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_05f2f14f0a6e40da801143e156e9f295_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_c3d40b452a6c4551ab2bd63a1e66d76d_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_0ca4c1e7b09c4c2fa88b8389846067bd_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_75f622018bd741838b205449dc4edd9b_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_ef0ed2013d5d46fc9cfd099214dbb412_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_cf7f23c56a67470fab93b00db3019d8c_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_e9de4ee7b8ea432a80d7f3bb1f4b4cdf_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_43cb99ce796f4b9bb45f22f997e0153c_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_7b894d3765154935b8e07d8305c48015_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_cda2b7fdbcc64b5388282ab10cf760f6_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_3c5e9674626d4d4faea8d2a6901c51a8_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_4aab723b116e481dbe3e53877601d1ef_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_a07de507bc1a482a99da0f14923bb755_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_02c16b41d48f4babb3f43a0a37444a54_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_b8f2022e5c534142b3735881cc2d36c2_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_0733327b27f94475955f0b0119e035ae_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_a68ef949edee45daa74bcc9124ad63d7_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_3b47738d74d146ccb5a0aaa5a3c67aed_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_3b7a200641474b9f9a56ba0681ddbc46_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_ceb57cce653243299bac6d7ab22f8d83_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_a3bcfea8b7044df5a7552fdc86f8ecf1_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_18ec9f790ca44afdaa3c3c73f0c12115_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_9a1b8719f635428db7a3d0b467b4a323_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_3cded54cb2ea4a9b8c8652dfef6e68d8_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_8eface9bd6a7421dad8b3912c02ba7b0_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_eed074c578e04066bce251f8c1551dc0_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_10e13335563342c0a62292eccc89d6de_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_8b79e13419334d229306fe3b10b4e819_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_e77be3fa4c90476d8b10cf75c483206f_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_68514fab307345a8a7ad3ef44af711e7_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_7dcfb09274a649da820065ed8efcbaf1_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_c2882b08431e4ef1af7b772d5da67184_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_d1809fbb553d459b94ffb31a705eb80e_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_d5d73071396147ddaaf7581893c41a54_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_bb18cfdbc79b44b781fc5d3c5f229e61_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_6b989baab905425497b6869c4dc48442_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_841af385797f46ec9b5cd773fae83f5a_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_451f811aa02345d29b89c9749ca80075_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_bc35999911a5432288eedef6cf11c454_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_d639cf1b3d15480590c6222705b370f3_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_de827d45355c44ea914c24e005eb4a3a_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_c146731452c041648e3fa9e05ca6af76_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_cd809cb980ac456ab6791f5680704bcc_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_8e060a3f25fa4b3c9308130c5b65115d_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_ea7412fc8ed4482e92d0fab4b2290b1e_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_2923321e6f9e4c4fa9c16b8882710395_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_ef4815bd97a140a385c24461277b35cc_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_76167dead9264a1db278b5e98f03e113_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_0ce081de33ac4858ac1457902f32d17f_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_1d8940b4f7154b338d333f8b250f61a2_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_4609ce21d6304e14877249cc92912586_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_bdd2e42531ce4b248970f8b4e3a23707_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_bc474f3a88ed4a938a1a8050f52b1292_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_2ef9f57f196346a1a0596c56607f141a_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_7fe25073a418450981d778e6df89aa97_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_8c803dfa10df42d087ce8507aa4cfd2e_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_ff01f6c2203c46fc9a628653428e8e0b_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_964401c031ca40c5b3d8814ce837da61_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_bdd09b5c6027465eb0a1f23801ec165a_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_0cb342dd702f42d2842cf4af9c8a2be2_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_0d0a6ea5b6a34ca5809c3036a5a55726_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_a0b7defe288a4a7a87ac7f45c32bb62f_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_e9778b99d9f04021864b82a9445d942b_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_b4cb1f43da994d44a4192bb0ea502cf2_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_1a95818c5d894f6aafac3fbf5eab7a9a_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_3c71439f57734c97b1cbc8cf48451f5f_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_4170b327063642bc85bb0b8b06071758_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_c677675d9fa74f4ba9e3dcbdf7f821d1_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_656182f195f04df5817a64d6bcf88790_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_07c4d49edb8945a1be188082a07c9ba7_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_b4899fd792f3462494133267c109818d_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_00d49c6d0c2044be8ec01bf0368d7621_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_eeb769ababaa4d4cb5b627f1356ab35d_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_a463b107a8744f0482d5fa2fc48e236b_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_462179bf7dde449d8c71e6c8f8c1f31b_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://license-manager-user-subscriptions.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_42d512badf074f2ebdeb837fa171fdd2_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_4578c81934f647af82b7cf5556bee7d2_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("LicenseManagerUserSubscriptions")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_e8a0fe76719a4989ad22734ba5cff356_Test()
        {
            var parameters = new LicenseManagerUserSubscriptionsEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonLicenseManagerUserSubscriptionsEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}