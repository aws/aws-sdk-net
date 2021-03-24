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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */

using Amazon.APIGateway;
using Amazon.APIGateway.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class APIGatewayPaginatorTests
    {
        private static Mock<AmazonAPIGatewayClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonAPIGatewayClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        public void GetApiKeysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetApiKeysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetApiKeysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetApiKeysResponse>();
            secondResponse.Position = null;

            _mockClient.SetupSequence(x => x.GetApiKeys(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetApiKeys(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetApiKeysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetApiKeysRequest>();

            var response = InstantiateClassGenerator.Execute<GetApiKeysResponse>();
            response.Position = null;

            _mockClient.Setup(x => x.GetApiKeys(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetApiKeys(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        public void GetBasePathMappingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetBasePathMappingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetBasePathMappingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetBasePathMappingsResponse>();
            secondResponse.Position = null;

            _mockClient.SetupSequence(x => x.GetBasePathMappings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetBasePathMappings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetBasePathMappingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetBasePathMappingsRequest>();

            var response = InstantiateClassGenerator.Execute<GetBasePathMappingsResponse>();
            response.Position = null;

            _mockClient.Setup(x => x.GetBasePathMappings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetBasePathMappings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        public void GetClientCertificatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetClientCertificatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetClientCertificatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetClientCertificatesResponse>();
            secondResponse.Position = null;

            _mockClient.SetupSequence(x => x.GetClientCertificates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetClientCertificates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetClientCertificatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetClientCertificatesRequest>();

            var response = InstantiateClassGenerator.Execute<GetClientCertificatesResponse>();
            response.Position = null;

            _mockClient.Setup(x => x.GetClientCertificates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetClientCertificates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        public void GetDeploymentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetDeploymentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetDeploymentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetDeploymentsResponse>();
            secondResponse.Position = null;

            _mockClient.SetupSequence(x => x.GetDeployments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetDeployments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetDeploymentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetDeploymentsRequest>();

            var response = InstantiateClassGenerator.Execute<GetDeploymentsResponse>();
            response.Position = null;

            _mockClient.Setup(x => x.GetDeployments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetDeployments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        public void GetDomainNamesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetDomainNamesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetDomainNamesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetDomainNamesResponse>();
            secondResponse.Position = null;

            _mockClient.SetupSequence(x => x.GetDomainNames(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetDomainNames(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetDomainNamesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetDomainNamesRequest>();

            var response = InstantiateClassGenerator.Execute<GetDomainNamesResponse>();
            response.Position = null;

            _mockClient.Setup(x => x.GetDomainNames(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetDomainNames(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        public void GetModelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetModelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetModelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetModelsResponse>();
            secondResponse.Position = null;

            _mockClient.SetupSequence(x => x.GetModels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetModels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetModelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetModelsRequest>();

            var response = InstantiateClassGenerator.Execute<GetModelsResponse>();
            response.Position = null;

            _mockClient.Setup(x => x.GetModels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetModels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        public void GetResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetResourcesResponse>();
            secondResponse.Position = null;

            _mockClient.SetupSequence(x => x.GetResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<GetResourcesResponse>();
            response.Position = null;

            _mockClient.Setup(x => x.GetResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        public void GetRestApisTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetRestApisRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetRestApisResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetRestApisResponse>();
            secondResponse.Position = null;

            _mockClient.SetupSequence(x => x.GetRestApis(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetRestApis(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetRestApisTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetRestApisRequest>();

            var response = InstantiateClassGenerator.Execute<GetRestApisResponse>();
            response.Position = null;

            _mockClient.Setup(x => x.GetRestApis(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetRestApis(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        public void GetUsageTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetUsageRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetUsageResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetUsageResponse>();
            secondResponse.Position = null;

            _mockClient.SetupSequence(x => x.GetUsage(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetUsage(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetUsageTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetUsageRequest>();

            var response = InstantiateClassGenerator.Execute<GetUsageResponse>();
            response.Position = null;

            _mockClient.Setup(x => x.GetUsage(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetUsage(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        public void GetUsagePlanKeysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetUsagePlanKeysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetUsagePlanKeysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetUsagePlanKeysResponse>();
            secondResponse.Position = null;

            _mockClient.SetupSequence(x => x.GetUsagePlanKeys(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetUsagePlanKeys(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetUsagePlanKeysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetUsagePlanKeysRequest>();

            var response = InstantiateClassGenerator.Execute<GetUsagePlanKeysResponse>();
            response.Position = null;

            _mockClient.Setup(x => x.GetUsagePlanKeys(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetUsagePlanKeys(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        public void GetUsagePlansTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetUsagePlansRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetUsagePlansResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetUsagePlansResponse>();
            secondResponse.Position = null;

            _mockClient.SetupSequence(x => x.GetUsagePlans(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetUsagePlans(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetUsagePlansTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetUsagePlansRequest>();

            var response = InstantiateClassGenerator.Execute<GetUsagePlansResponse>();
            response.Position = null;

            _mockClient.Setup(x => x.GetUsagePlans(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetUsagePlans(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        public void GetVpcLinksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetVpcLinksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetVpcLinksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetVpcLinksResponse>();
            secondResponse.Position = null;

            _mockClient.SetupSequence(x => x.GetVpcLinks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetVpcLinks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("APIGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetVpcLinksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetVpcLinksRequest>();

            var response = InstantiateClassGenerator.Execute<GetVpcLinksResponse>();
            response.Position = null;

            _mockClient.Setup(x => x.GetVpcLinks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetVpcLinks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}