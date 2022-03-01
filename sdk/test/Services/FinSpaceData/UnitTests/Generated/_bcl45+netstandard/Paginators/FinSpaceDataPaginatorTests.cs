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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */

using Amazon.FinSpaceData;
using Amazon.FinSpaceData.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class FinSpaceDataPaginatorTests
    {
        private static Mock<AmazonFinSpaceDataClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonFinSpaceDataClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FinSpaceData")]
        public void ListChangesetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListChangesetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListChangesetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListChangesetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListChangesets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListChangesets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FinSpaceData")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListChangesetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListChangesetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListChangesetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListChangesets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListChangesets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FinSpaceData")]
        public void ListDatasetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDatasetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDatasetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDatasetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDatasets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDatasets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FinSpaceData")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDatasetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDatasetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDatasetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDatasets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDatasets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FinSpaceData")]
        public void ListDataViewsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDataViewsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDataViewsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDataViewsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDataViews(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDataViews(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FinSpaceData")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDataViewsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDataViewsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDataViewsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDataViews(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDataViews(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FinSpaceData")]
        public void ListPermissionGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPermissionGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPermissionGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPermissionGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPermissionGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPermissionGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FinSpaceData")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPermissionGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPermissionGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPermissionGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPermissionGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPermissionGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FinSpaceData")]
        public void ListUsersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUsersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUsersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUsersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListUsers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUsers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FinSpaceData")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUsersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUsersRequest>();

            var response = InstantiateClassGenerator.Execute<ListUsersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListUsers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUsers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}