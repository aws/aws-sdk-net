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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
 */

using Amazon.IoTDeviceAdvisor;
using Amazon.IoTDeviceAdvisor.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class IoTDeviceAdvisorPaginatorTests
    {
        private static Mock<AmazonIoTDeviceAdvisorClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonIoTDeviceAdvisorClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTDeviceAdvisor")]
        public void ListSuiteDefinitionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSuiteDefinitionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSuiteDefinitionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSuiteDefinitionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSuiteDefinitions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSuiteDefinitions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTDeviceAdvisor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSuiteDefinitionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSuiteDefinitionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSuiteDefinitionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSuiteDefinitions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSuiteDefinitions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTDeviceAdvisor")]
        public void ListSuiteRunsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSuiteRunsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSuiteRunsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSuiteRunsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSuiteRuns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSuiteRuns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTDeviceAdvisor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSuiteRunsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSuiteRunsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSuiteRunsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSuiteRuns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSuiteRuns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTDeviceAdvisor")]
        public void ListTestCasesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTestCasesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTestCasesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTestCasesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTestCases(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTestCases(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTDeviceAdvisor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTestCasesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTestCasesRequest>();

            var response = InstantiateClassGenerator.Execute<ListTestCasesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTestCases(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTestCases(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif