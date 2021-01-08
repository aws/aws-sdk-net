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
 * Do not modify this file. This file is generated from the servicecatalog-appregistry-2020-06-24.normal.json service model.
 */

using Amazon.AppRegistry;
using Amazon.AppRegistry.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class AppRegistryPaginatorTests
    {
        private static Mock<AmazonAppRegistryClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonAppRegistryClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppRegistry")]
        public void ListApplicationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListApplicationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListApplicationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListApplications(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListApplications(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppRegistry")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListApplicationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListApplicationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListApplications(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListApplications(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppRegistry")]
        public void ListAssociatedAttributeGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssociatedAttributeGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssociatedAttributeGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssociatedAttributeGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssociatedAttributeGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssociatedAttributeGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppRegistry")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssociatedAttributeGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssociatedAttributeGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssociatedAttributeGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssociatedAttributeGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssociatedAttributeGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppRegistry")]
        public void ListAssociatedResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssociatedResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssociatedResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssociatedResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssociatedResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssociatedResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppRegistry")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssociatedResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssociatedResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssociatedResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssociatedResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssociatedResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppRegistry")]
        public void ListAttributeGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAttributeGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAttributeGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAttributeGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAttributeGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAttributeGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppRegistry")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAttributeGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAttributeGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAttributeGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAttributeGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAttributeGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif