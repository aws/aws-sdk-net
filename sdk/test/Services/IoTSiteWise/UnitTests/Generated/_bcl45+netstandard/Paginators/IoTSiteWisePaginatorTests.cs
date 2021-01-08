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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */

using Amazon.IoTSiteWise;
using Amazon.IoTSiteWise.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class IoTSiteWisePaginatorTests
    {
        private static Mock<AmazonIoTSiteWiseClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonIoTSiteWiseClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        public void GetAssetPropertyAggregatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetAssetPropertyAggregatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetAssetPropertyAggregatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetAssetPropertyAggregatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetAssetPropertyAggregates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetAssetPropertyAggregates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetAssetPropertyAggregatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetAssetPropertyAggregatesRequest>();

            var response = InstantiateClassGenerator.Execute<GetAssetPropertyAggregatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetAssetPropertyAggregates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetAssetPropertyAggregates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        public void GetAssetPropertyValueHistoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetAssetPropertyValueHistoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetAssetPropertyValueHistoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetAssetPropertyValueHistoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetAssetPropertyValueHistory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetAssetPropertyValueHistory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetAssetPropertyValueHistoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetAssetPropertyValueHistoryRequest>();

            var response = InstantiateClassGenerator.Execute<GetAssetPropertyValueHistoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetAssetPropertyValueHistory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetAssetPropertyValueHistory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        public void ListAccessPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAccessPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAccessPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAccessPoliciesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAccessPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccessPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAccessPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAccessPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAccessPoliciesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAccessPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccessPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        public void ListAssetModelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssetModelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssetModelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssetModelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssetModels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssetModels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssetModelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssetModelsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssetModelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssetModels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssetModels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        public void ListAssetRelationshipsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssetRelationshipsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssetRelationshipsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssetRelationshipsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssetRelationships(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssetRelationships(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssetRelationshipsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssetRelationshipsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssetRelationshipsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssetRelationships(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssetRelationships(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        public void ListAssetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        public void ListAssociatedAssetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssociatedAssetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssociatedAssetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssociatedAssetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssociatedAssets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssociatedAssets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssociatedAssetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssociatedAssetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssociatedAssetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssociatedAssets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssociatedAssets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        public void ListDashboardsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDashboardsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDashboardsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDashboardsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDashboards(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDashboards(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDashboardsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDashboardsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDashboardsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDashboards(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDashboards(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        public void ListGatewaysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGatewaysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGatewaysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGatewaysResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListGateways(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGateways(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGatewaysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGatewaysRequest>();

            var response = InstantiateClassGenerator.Execute<ListGatewaysResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListGateways(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGateways(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        public void ListPortalsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPortalsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPortalsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPortalsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPortals(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPortals(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPortalsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPortalsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPortalsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPortals(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPortals(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        public void ListProjectAssetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProjectAssetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProjectAssetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProjectAssetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProjectAssets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProjectAssets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProjectAssetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProjectAssetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListProjectAssetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProjectAssets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProjectAssets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        public void ListProjectsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProjectsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProjectsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProjectsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProjects(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProjects(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTSiteWise")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProjectsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProjectsRequest>();

            var response = InstantiateClassGenerator.Execute<ListProjectsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProjects(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProjects(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif