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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */

using Amazon.ConfigService;
using Amazon.ConfigService.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ConfigServicePaginatorTests
    {
        private static Mock<AmazonConfigServiceClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonConfigServiceClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeRemediationExceptionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRemediationExceptionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeRemediationExceptionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeRemediationExceptionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeRemediationExceptions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeRemediationExceptions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeRemediationExceptionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRemediationExceptionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeRemediationExceptionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeRemediationExceptions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeRemediationExceptions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void DescribeRemediationExecutionStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRemediationExecutionStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeRemediationExecutionStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeRemediationExecutionStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeRemediationExecutionStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeRemediationExecutionStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeRemediationExecutionStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRemediationExecutionStatusRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeRemediationExecutionStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeRemediationExecutionStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeRemediationExecutionStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void GetResourceConfigHistoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetResourceConfigHistoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetResourceConfigHistoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetResourceConfigHistoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetResourceConfigHistory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetResourceConfigHistory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetResourceConfigHistoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetResourceConfigHistoryRequest>();

            var response = InstantiateClassGenerator.Execute<GetResourceConfigHistoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetResourceConfigHistory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetResourceConfigHistory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void ListStoredQueriesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStoredQueriesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStoredQueriesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStoredQueriesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStoredQueries(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStoredQueries(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStoredQueriesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStoredQueriesRequest>();

            var response = InstantiateClassGenerator.Execute<ListStoredQueriesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStoredQueries(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStoredQueries(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        public void SelectAggregateResourceConfigTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SelectAggregateResourceConfigRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SelectAggregateResourceConfigResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SelectAggregateResourceConfigResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SelectAggregateResourceConfig(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SelectAggregateResourceConfig(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConfigService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SelectAggregateResourceConfigTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SelectAggregateResourceConfigRequest>();

            var response = InstantiateClassGenerator.Execute<SelectAggregateResourceConfigResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SelectAggregateResourceConfig(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SelectAggregateResourceConfig(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif