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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.ResourceExplorer2.Endpoints;
using Amazon.ResourceExplorer2.Internal;

namespace AWSSDK_DotNet35.UnitTests.Endpoints
{
    [TestClass]
    public partial class ResourceExplorer2EndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.eu-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-south-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-south-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eusouth2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-south-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.eu-south-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-gov-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-gov-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgoveast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-gov-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.us-gov-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region me-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region me-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region me-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region me-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mecentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "me-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.me-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ca-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ca-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cacentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ca-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ca-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-central-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-central-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-central-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.eu-central-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-central-2 with FIPS enabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack enabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-central-2 with FIPS disabled and DualStack disabled")]
        public void For_region_eucentral2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-central-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.eu-central-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.us-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_uswest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.us-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region af-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region af-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region af-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region af-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_afsouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "af-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.af-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_eunorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.eu-north-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-west-3 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-west-3 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-west-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.eu-west-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-west-2 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-west-2 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-west-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.eu-west-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region eu-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_euwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.eu-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-northeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-northeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-northeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-northeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-northeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-northeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-northeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-northeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-northeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-northeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apnortheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-northeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-northeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region me-south-1 with FIPS enabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region me-south-1 with FIPS enabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region me-south-1 with FIPS disabled and DualStack enabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region me-south-1 with FIPS disabled and DualStack disabled")]
        public void For_region_mesouth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "me-south-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.me-south-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region sa-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region sa-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_saeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "sa-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.sa-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apeast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region cn-north-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region cn-north-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorth1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.cn-north-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ca-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cawest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ca-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ca-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cawest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ca-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ca-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cawest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ca-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ca-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cawest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ca-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ca-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-gov-west-1 with FIPS enabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack enabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-gov-west-1 with FIPS disabled and DualStack disabled")]
        public void For_region_usgovwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.us-gov-west-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-1 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-1 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-southeast-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-2 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-2 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-southeast-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-3 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-3 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast3_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-3";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-southeast-3.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-4 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-4 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast4_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-4";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-southeast-4.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-5 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast5_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-5";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-southeast-5.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-5 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast5_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-5";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-southeast-5.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-5 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast5_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-5";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-southeast-5.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-5 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast5_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-5";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-southeast-5.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-east-1 with FIPS enabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-east-1 with FIPS enabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-east-1 with FIPS disabled and DualStack enabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-east-1 with FIPS disabled and DualStack disabled")]
        public void For_region_useast1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-6 with FIPS enabled and DualStack enabled")]
        public void For_region_apsoutheast6_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-6";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-southeast-6.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-6 with FIPS enabled and DualStack disabled")]
        public void For_region_apsoutheast6_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-6";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.ap-southeast-6.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-6 with FIPS disabled and DualStack enabled")]
        public void For_region_apsoutheast6_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-6";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-southeast-6.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region ap-southeast-6 with FIPS disabled and DualStack disabled")]
        public void For_region_apsoutheast6_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "ap-southeast-6";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.ap-southeast-6.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-east-2 with FIPS enabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-east-2 with FIPS enabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-east-2 with FIPS disabled and DualStack enabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region us-east-2 with FIPS disabled and DualStack disabled")]
        public void For_region_useast2_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-east-2";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.us-east-2.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region cn-northwest-1 with FIPS enabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_enabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2-fips.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack enabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_enabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = true;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For region cn-northwest-1 with FIPS disabled and DualStack disabled")]
        public void For_region_cnnorthwest1_with_FIPS_disabled_and_DualStack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "cn-northwest-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://resource-explorer-2.cn-northwest-1.api.amazonwebservices.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For custom endpoint with fips disabled and dualstack disabled")]
        public void For_custom_endpoint_with_fips_disabled_and_dualstack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = false;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("ResourceExplorer2")]
        [Description("For custom endpoint with fips enabled and dualstack disabled")]
        [ExpectedException(typeof(AmazonClientException), @"Invalid Configuration: FIPS and custom endpoint are not supported")]
        public void For_custom_endpoint_with_fips_enabled_and_dualstack_disabled_Test()
        {
            var parameters = new ResourceExplorer2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["UseDualStack"] = false;
            parameters["UseFIPS"] = true;
            parameters["Endpoint"] = "https://example.com";
            var endpoint = new AmazonResourceExplorer2EndpointProvider().ResolveEndpoint(parameters);
        }

    }
}