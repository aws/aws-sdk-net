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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */

using Amazon.ResourceGroups;
using Amazon.ResourceGroups.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ResourceGroupsPaginatorTests
    {
        private static Mock<AmazonResourceGroupsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonResourceGroupsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResourceGroups")]
        public void ListGroupResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGroupResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGroupResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGroupResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListGroupResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGroupResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResourceGroups")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGroupResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGroupResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListGroupResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListGroupResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGroupResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResourceGroups")]
        public void ListGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResourceGroups")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResourceGroups")]
        public void SearchResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResourceGroups")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<SearchResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}