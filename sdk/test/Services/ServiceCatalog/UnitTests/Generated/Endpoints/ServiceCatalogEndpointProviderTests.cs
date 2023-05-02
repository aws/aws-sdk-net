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
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.af-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-northeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-northeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-northeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-southeast-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-southeast-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ap-southeast-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.ca-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.eu-central-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.eu-north-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.eu-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.eu-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.eu-west-3.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.me-south-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.sa-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-east-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.cn-northwest-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-gov-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-iso-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-iso-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisoeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"FIPS and DualStack are enabled, but this partition does not support one or both")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-isob-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog-fips.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"DualStack is enabled but this partition does not support DualStack")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For region us-isob-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usisobeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-isob-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://servicecatalog.us-isob-east-1.sc2s.sgov.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For custom endpoint with region set and fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_region_set_and_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For custom endpoint with region not set and fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_region_not_set_and_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("For custom endpoint with fips disabled and dualstack enabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Dualstack and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_enabled_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseFIPS"] = false;
            parameters["UseDualStack"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ServiceCatalog")]
        [Description("Missing region")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: Missing Region")]
        public void Missing_region_Test()
        {
            var parameters = new ServiceCatalogEndpointParameters();
            var endpoint = new AmazonServiceCatalogEndpointProvider().ResolveEndpoint(parameters);
        }

    }
}