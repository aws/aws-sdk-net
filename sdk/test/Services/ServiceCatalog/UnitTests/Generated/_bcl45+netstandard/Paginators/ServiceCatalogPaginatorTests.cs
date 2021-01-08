#if !NETSTANDARD13
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

using Amazon.ServiceCatalog;
using Amazon.ServiceCatalog.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ServiceCatalogPaginatorTests
    {
        private static Mock<AmazonServiceCatalogClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonServiceCatalogClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void DescribePortfolioSharesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribePortfolioSharesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribePortfolioSharesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribePortfolioSharesResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.DescribePortfolioShares(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribePortfolioShares(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribePortfolioSharesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribePortfolioSharesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribePortfolioSharesResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.DescribePortfolioShares(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribePortfolioShares(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void GetProvisionedProductOutputsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetProvisionedProductOutputsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetProvisionedProductOutputsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetProvisionedProductOutputsResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.GetProvisionedProductOutputs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetProvisionedProductOutputs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetProvisionedProductOutputsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetProvisionedProductOutputsRequest>();

            var response = InstantiateClassGenerator.Execute<GetProvisionedProductOutputsResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.GetProvisionedProductOutputs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetProvisionedProductOutputs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void ListAcceptedPortfolioSharesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAcceptedPortfolioSharesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAcceptedPortfolioSharesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAcceptedPortfolioSharesResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListAcceptedPortfolioShares(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAcceptedPortfolioShares(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAcceptedPortfolioSharesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAcceptedPortfolioSharesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAcceptedPortfolioSharesResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.ListAcceptedPortfolioShares(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAcceptedPortfolioShares(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void ListBudgetsForResourceTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBudgetsForResourceRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBudgetsForResourceResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBudgetsForResourceResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListBudgetsForResource(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBudgetsForResource(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBudgetsForResourceTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBudgetsForResourceRequest>();

            var response = InstantiateClassGenerator.Execute<ListBudgetsForResourceResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.ListBudgetsForResource(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBudgetsForResource(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void ListConstraintsForPortfolioTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListConstraintsForPortfolioRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListConstraintsForPortfolioResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListConstraintsForPortfolioResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListConstraintsForPortfolio(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListConstraintsForPortfolio(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListConstraintsForPortfolioTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListConstraintsForPortfolioRequest>();

            var response = InstantiateClassGenerator.Execute<ListConstraintsForPortfolioResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.ListConstraintsForPortfolio(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListConstraintsForPortfolio(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void ListLaunchPathsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLaunchPathsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLaunchPathsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLaunchPathsResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListLaunchPaths(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLaunchPaths(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLaunchPathsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLaunchPathsRequest>();

            var response = InstantiateClassGenerator.Execute<ListLaunchPathsResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.ListLaunchPaths(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLaunchPaths(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void ListOrganizationPortfolioAccessTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOrganizationPortfolioAccessRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOrganizationPortfolioAccessResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOrganizationPortfolioAccessResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListOrganizationPortfolioAccess(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOrganizationPortfolioAccess(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOrganizationPortfolioAccessTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOrganizationPortfolioAccessRequest>();

            var response = InstantiateClassGenerator.Execute<ListOrganizationPortfolioAccessResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.ListOrganizationPortfolioAccess(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOrganizationPortfolioAccess(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void ListPortfolioAccessTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPortfolioAccessRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPortfolioAccessResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPortfolioAccessResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListPortfolioAccess(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPortfolioAccess(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPortfolioAccessTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPortfolioAccessRequest>();

            var response = InstantiateClassGenerator.Execute<ListPortfolioAccessResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.ListPortfolioAccess(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPortfolioAccess(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void ListPortfoliosTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPortfoliosRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPortfoliosResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPortfoliosResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListPortfolios(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPortfolios(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPortfoliosTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPortfoliosRequest>();

            var response = InstantiateClassGenerator.Execute<ListPortfoliosResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.ListPortfolios(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPortfolios(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void ListPortfoliosForProductTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPortfoliosForProductRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPortfoliosForProductResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPortfoliosForProductResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListPortfoliosForProduct(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPortfoliosForProduct(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPortfoliosForProductTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPortfoliosForProductRequest>();

            var response = InstantiateClassGenerator.Execute<ListPortfoliosForProductResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.ListPortfoliosForProduct(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPortfoliosForProduct(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void ListPrincipalsForPortfolioTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPrincipalsForPortfolioRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPrincipalsForPortfolioResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPrincipalsForPortfolioResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListPrincipalsForPortfolio(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPrincipalsForPortfolio(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPrincipalsForPortfolioTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPrincipalsForPortfolioRequest>();

            var response = InstantiateClassGenerator.Execute<ListPrincipalsForPortfolioResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.ListPrincipalsForPortfolio(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPrincipalsForPortfolio(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void ListProvisioningArtifactsForServiceActionTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProvisioningArtifactsForServiceActionRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProvisioningArtifactsForServiceActionResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProvisioningArtifactsForServiceActionResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListProvisioningArtifactsForServiceAction(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProvisioningArtifactsForServiceAction(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProvisioningArtifactsForServiceActionTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProvisioningArtifactsForServiceActionRequest>();

            var response = InstantiateClassGenerator.Execute<ListProvisioningArtifactsForServiceActionResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.ListProvisioningArtifactsForServiceAction(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProvisioningArtifactsForServiceAction(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void ListResourcesForTagOptionTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResourcesForTagOptionRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResourcesForTagOptionResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResourcesForTagOptionResponse>();
            secondResponse.PageToken = null;

            _mockClient.SetupSequence(x => x.ListResourcesForTagOption(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResourcesForTagOption(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResourcesForTagOptionTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResourcesForTagOptionRequest>();

            var response = InstantiateClassGenerator.Execute<ListResourcesForTagOptionResponse>();
            response.PageToken = null;

            _mockClient.Setup(x => x.ListResourcesForTagOption(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResourcesForTagOption(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void ListServiceActionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceActionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServiceActionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServiceActionsResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListServiceActions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServiceActions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServiceActionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceActionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListServiceActionsResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.ListServiceActions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServiceActions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void ListServiceActionsForProvisioningArtifactTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceActionsForProvisioningArtifactRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServiceActionsForProvisioningArtifactResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServiceActionsForProvisioningArtifactResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListServiceActionsForProvisioningArtifact(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServiceActionsForProvisioningArtifact(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServiceActionsForProvisioningArtifactTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceActionsForProvisioningArtifactRequest>();

            var response = InstantiateClassGenerator.Execute<ListServiceActionsForProvisioningArtifactResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.ListServiceActionsForProvisioningArtifact(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServiceActionsForProvisioningArtifact(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void ListTagOptionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTagOptionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTagOptionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTagOptionsResponse>();
            secondResponse.PageToken = null;

            _mockClient.SetupSequence(x => x.ListTagOptions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTagOptions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTagOptionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTagOptionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTagOptionsResponse>();
            response.PageToken = null;

            _mockClient.Setup(x => x.ListTagOptions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTagOptions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void SearchProductsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchProductsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchProductsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchProductsResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.SearchProducts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchProducts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchProductsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchProductsRequest>();

            var response = InstantiateClassGenerator.Execute<SearchProductsResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.SearchProducts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchProducts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void SearchProductsAsAdminTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchProductsAsAdminRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchProductsAsAdminResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchProductsAsAdminResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.SearchProductsAsAdmin(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchProductsAsAdmin(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchProductsAsAdminTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchProductsAsAdminRequest>();

            var response = InstantiateClassGenerator.Execute<SearchProductsAsAdminResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.SearchProductsAsAdmin(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchProductsAsAdmin(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        public void SearchProvisionedProductsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchProvisionedProductsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchProvisionedProductsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchProvisionedProductsResponse>();
            secondResponse.NextPageToken = null;

            _mockClient.SetupSequence(x => x.SearchProvisionedProducts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchProvisionedProducts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServiceCatalog")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchProvisionedProductsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchProvisionedProductsRequest>();

            var response = InstantiateClassGenerator.Execute<SearchProvisionedProductsResponse>();
            response.NextPageToken = null;

            _mockClient.Setup(x => x.SearchProvisionedProducts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchProvisionedProducts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif