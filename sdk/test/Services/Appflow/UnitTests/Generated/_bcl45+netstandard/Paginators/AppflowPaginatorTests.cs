#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */

using Amazon.Appflow;
using Amazon.Appflow.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class AppflowPaginatorTests
    {
        private static Mock<AmazonAppflowClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonAppflowClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Appflow")]
        public void DescribeConnectorProfilesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConnectorProfilesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeConnectorProfilesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeConnectorProfilesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeConnectorProfiles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeConnectorProfiles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Appflow")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeConnectorProfilesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConnectorProfilesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeConnectorProfilesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeConnectorProfiles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeConnectorProfiles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Appflow")]
        public void DescribeConnectorsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConnectorsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeConnectorsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeConnectorsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeConnectors(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeConnectors(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Appflow")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeConnectorsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConnectorsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeConnectorsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeConnectors(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeConnectors(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Appflow")]
        public void DescribeFlowExecutionRecordsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFlowExecutionRecordsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeFlowExecutionRecordsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeFlowExecutionRecordsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeFlowExecutionRecords(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeFlowExecutionRecords(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Appflow")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeFlowExecutionRecordsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFlowExecutionRecordsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeFlowExecutionRecordsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeFlowExecutionRecords(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeFlowExecutionRecords(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Appflow")]
        public void ListFlowsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFlowsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFlowsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFlowsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFlows(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFlows(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Appflow")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFlowsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFlowsRequest>();

            var response = InstantiateClassGenerator.Execute<ListFlowsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFlows(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFlows(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif