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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */

using Amazon.AppRunner;
using Amazon.AppRunner.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class AppRunnerPaginatorTests
    {
        private static Mock<AmazonAppRunnerClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonAppRunnerClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppRunner")]
        public void DescribeCustomDomainsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCustomDomainsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeCustomDomainsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeCustomDomainsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeCustomDomains(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeCustomDomains(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppRunner")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeCustomDomainsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCustomDomainsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeCustomDomainsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeCustomDomains(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeCustomDomains(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppRunner")]
        public void ListAutoScalingConfigurationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAutoScalingConfigurationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAutoScalingConfigurationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAutoScalingConfigurationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAutoScalingConfigurations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAutoScalingConfigurations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppRunner")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAutoScalingConfigurationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAutoScalingConfigurationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAutoScalingConfigurationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAutoScalingConfigurations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAutoScalingConfigurations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppRunner")]
        public void ListConnectionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListConnectionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListConnectionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListConnectionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListConnections(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListConnections(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppRunner")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListConnectionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListConnectionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListConnectionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListConnections(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListConnections(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppRunner")]
        public void ListOperationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOperationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOperationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOperationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListOperations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOperations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppRunner")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOperationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOperationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListOperationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListOperations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOperations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppRunner")]
        public void ListServicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListServices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AppRunner")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServicesRequest>();

            var response = InstantiateClassGenerator.Execute<ListServicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListServices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}