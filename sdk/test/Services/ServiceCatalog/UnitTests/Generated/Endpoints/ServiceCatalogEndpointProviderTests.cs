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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ServiceCatalog.Endpoints;
using Amazon.ServiceCatalog.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ServiceCatalogEndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_1b28cd5b0c6f46e3befe2d2d9e9febd3_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_85cfa45376b840f785bec120e5219033_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_4a66604913764d61acf7c50de4240e7e_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_6d2d1818565d4505b66a048a8cf59398_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_e46a0175bb1148218ffa591d9f8a3841_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_7cb7242f2e66415ebbed023876baa135_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_e97b6c87bbc6416080ebce38e42b4ae0_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_346b28f7f57a4fb7b7756f8a1c44654e_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_0f0770c74a4f4888bd10987326e1c131_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_d1bad09b3a764a6f89555b1fc252076c_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_b2114cf819674dd3b98b5e76353cbade_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_63af7b4651a84897a15a5112f7f62f73_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_c387cb3068c64d799d3d150ab5edfa06_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_7b3bcf8690824ded90de1866a5a23bc9_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_f7e58308ab054c9292176750389f3081_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_3d07caee789e48b4afd8491cbb9c3226_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_2630b18da1bd4807bd727bb034520669_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_221edc62ed6c4db68f4d52bf24661e3e_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_b69f66ebed3b4c72afe5683164ac92be_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_deeba6122f8a41e9b9f2c0ac56f1353e_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_c9316d434e504512bf0b6da753d3413e_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_ee88768da9144515ae751152847f904d_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_4453e52e2a96402cb21bc4b517962009_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_9f62822c4b2c4e94a9db20f46b7e75fd_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_22e16065e8cd40d4b0219bbb59b88add_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_3d4e69b9cabe4f96a277d7b0424d04c9_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_04d367df1f014b37b2a42c521847a2d3_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_b41035267d5c4258950bc72d327b281c_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_1aea432ec5254f8da8869a5f56401699_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_e0278984f799451ebf8d7ef67abe9210_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_296f01642098402faca098c505be0343_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_2f6e733b26fa4839a4986aaeb25ec78e_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_2d551b088352496c87294466b87c89b9_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_6e582cf79643484eaa14b65f38a52b23_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_9d91f50e36b14b6894cb91ec6e68666e_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_f710b8f0ed084d3e96f9d6037fad7d81_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_5f5b7c6cf03d472bb23894f5143f033a_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_226a79c4a5944a00a9430f8d65a311da_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_00c84dd6ccd04e0aade586779c17ecfd_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_30aa109d86e64124870af8cc6051178f_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_a7dcce5c762940728bd6ad0468637c88_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_b7049d99f0e6430d9c4af3c1bd4f14f7_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_b9dd2cb2aeb544eb80ea40f3a673a189_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_9c870c31fabc48e5a4c110143171637a_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_570f3c33b3794ccca928c31cfaffe5ab_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_e63aa98df45c4040b677163c413703df_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_410a57d7356746ecaa647483b886496c_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_618cdee8aadf4e71b68a1d139cfb1969_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_676f2bad44f64bf590a5b7e1a82a2e35_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_d0a2920f8a054481978400450cf570a6_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_5c9d03e63cf3425d9602f10eba3f96e7_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_6bf9417ddc7345769c099248b4718bc9_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_830dfec3fd2644a9b37e4b94bd294523_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_90332c13eb9a484aa01a64b600f376ff_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_b604f704e7314bfabf18e5d4043190c7_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_7a6e1391c7fd4cbda3ed848b6c2aa08c_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_d2021c41045b413cb4aa476cdd991b6b_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_578e806b15ae4bb9aaa80132ec4f5808_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_4e32cf3acd1d4f36ac086d8a81ec380e_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_bd2c25062bcc4a5e94657a55bfe3cc1f_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_f95ea5acdb8f4b408954ccd2f6aa1d97_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_8dd9ae2ae2c44e199519d48d28b74d58_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_9d9cd18b27ea40c3a6e317a23192bb5f_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_0cb4e7f501b04993bac4fa4534aa0760_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_964c2204b0e640a8b35351c56a9c4b71_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_8bf0a285017c4bab9f3b06ca2b6a0a57_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_ba8e09de23884db1bea81118a4527bc6_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_baaa947f8a0e4828aa372aa36533ade6_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_2c08ceedfabe4bc0b15864c40f32d3b6_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_38857f711b934980a0d2ba559ed7023c_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_dca54d6ba48745438105c278e5bcc62c_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_d2e543f6ef7a49549b8cbadca19ddd8e_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_ef12c5a797ac47b989a97b9f572ed9ec_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_dd8c025f9b33451b8f14d7ec034a85d4_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_ee6e749823bd4e72b1710541a95cbb20_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_54d5f97478624b2483c43f314ed67843_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_8b51924f98a747a2825381df36db3256_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_355aac53fca94bc5a4e74d598732e471_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_3731495fb34a4f9183084c5e1864cd6f_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_80d00125b81a452ba4fd6c636078e0dd_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_cce9cde6e00c49798b83db17b2892d3c_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_c13803b710ef4ed6ac973539ea00b4e2_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_e175b3dd3560486a98749e3c568cf9e2_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_544d9fd382d7416aa5d7a04f9b34adaa_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_910d23d2b5b241889413894ac0e7d52b_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_62ead81b6bba4b48be19253f638467ea_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_fc4c158b9d6d44f2aa7507ca0f339ff9_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_304269087fc24412a603fef962bdbf6a_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_3e3ac53514584ecfa2fada09a40a2816_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_4ed1a1b7a5d84d948db105ecc19542cb_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_cfede1f5fae94c4a8a300cff46e2ea76_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_4654ad8fbed24bb4b7f58e754602ac46_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_0709d3a216c3455bb7e2702ccc87b36d_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_450569691e624f068a94cf23091d53d1_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_a00a13409b5e42c6bcc39d22a526eba2_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_0bd0c7dbf8f447848f9ec1bf41b48c8d_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_2fa832ad4cbe48c3a73e54a12e205b5a_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_4cb9c38e5e7b43fc91ae9761c5c9f785_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_c27df8a489804a779c0e18dd7c613984_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_bb5d433fa609484eb9d11858c5ed5d34_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_8f19b78e58844c44af38174c9a58ccd7_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_e96aa54cd3a3431383b36f77a4864e88_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_ea1397909b954387beb4ed01cbfc4571_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_4a0a8bc88b3143b59ad6c6645d40a7a7_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_d028a6a7120145ecb4d0d227292f8ee2_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_269fe6bbfb984e59bb2957cc78b7f221_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), "Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_ef75f4aedea046e1982c297001c18c57_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}