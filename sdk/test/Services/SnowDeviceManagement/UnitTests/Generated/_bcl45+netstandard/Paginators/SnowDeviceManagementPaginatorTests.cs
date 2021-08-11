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
 * Do not modify this file. This file is generated from the snow-device-management-2021-08-04.normal.json service model.
 */

using Amazon.SnowDeviceManagement;
using Amazon.SnowDeviceManagement.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SnowDeviceManagementPaginatorTests
    {
        private static Mock<AmazonSnowDeviceManagementClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSnowDeviceManagementClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SnowDeviceManagement")]
        public void ListDeviceResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDeviceResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDeviceResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDeviceResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDeviceResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDeviceResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SnowDeviceManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDeviceResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDeviceResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListDeviceResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDeviceResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDeviceResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SnowDeviceManagement")]
        public void ListDevicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDevicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDevicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDevicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDevices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDevices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SnowDeviceManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDevicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDevicesRequest>();

            var response = InstantiateClassGenerator.Execute<ListDevicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDevices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDevices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SnowDeviceManagement")]
        public void ListExecutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListExecutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListExecutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListExecutionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListExecutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListExecutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SnowDeviceManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListExecutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListExecutionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListExecutionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListExecutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListExecutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SnowDeviceManagement")]
        public void ListTasksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTasksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTasksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTasksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTasks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTasks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SnowDeviceManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTasksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTasksRequest>();

            var response = InstantiateClassGenerator.Execute<ListTasksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTasks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTasks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}