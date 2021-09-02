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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */

using Amazon.Transfer;
using Amazon.Transfer.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class TransferPaginatorTests
    {
        private static Mock<AmazonTransferClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonTransferClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Transfer")]
        public void ListAccessesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAccessesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAccessesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAccessesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAccesses(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccesses(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Transfer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAccessesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAccessesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAccessesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAccesses(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccesses(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Transfer")]
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
        [TestCategory("Transfer")]
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
        [TestCategory("Transfer")]
        public void ListSecurityPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSecurityPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSecurityPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSecurityPoliciesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSecurityPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSecurityPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Transfer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSecurityPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSecurityPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListSecurityPoliciesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSecurityPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSecurityPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Transfer")]
        public void ListServersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListServers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Transfer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServersRequest>();

            var response = InstantiateClassGenerator.Execute<ListServersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListServers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Transfer")]
        public void ListTagsForResourceTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTagsForResource(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Transfer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTagsForResourceTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var response = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTagsForResource(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Transfer")]
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
        [TestCategory("Transfer")]
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


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Transfer")]
        public void ListWorkflowsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkflowsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWorkflowsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWorkflowsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWorkflows(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWorkflows(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Transfer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWorkflowsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkflowsRequest>();

            var response = InstantiateClassGenerator.Execute<ListWorkflowsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWorkflows(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWorkflows(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}