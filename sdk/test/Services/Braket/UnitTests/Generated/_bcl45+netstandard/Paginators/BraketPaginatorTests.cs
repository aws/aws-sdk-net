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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
 */

using Amazon.Braket;
using Amazon.Braket.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class BraketPaginatorTests
    {
        private static Mock<AmazonBraketClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonBraketClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Braket")]
        public void SearchDevicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchDevicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchDevicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchDevicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchDevices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchDevices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Braket")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchDevicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchDevicesRequest>();

            var response = InstantiateClassGenerator.Execute<SearchDevicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchDevices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchDevices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Braket")]
        public void SearchQuantumTasksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchQuantumTasksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchQuantumTasksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchQuantumTasksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchQuantumTasks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchQuantumTasks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Braket")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchQuantumTasksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchQuantumTasksRequest>();

            var response = InstantiateClassGenerator.Execute<SearchQuantumTasksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchQuantumTasks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchQuantumTasks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}