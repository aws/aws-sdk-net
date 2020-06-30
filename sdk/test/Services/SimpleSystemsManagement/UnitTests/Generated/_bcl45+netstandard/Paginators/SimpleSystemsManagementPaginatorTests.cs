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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */

using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SimpleSystemsManagementPaginatorTests
    {
        private static Mock<AmazonSimpleSystemsManagementClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSimpleSystemsManagementClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeActivationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeActivationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeActivationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeActivationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeActivations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeActivations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeActivationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeActivationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeActivationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeActivations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeActivations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeInstanceInformationTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstanceInformationRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeInstanceInformationResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeInstanceInformationResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeInstanceInformation(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeInstanceInformation(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeInstanceInformationTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstanceInformationRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeInstanceInformationResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeInstanceInformation(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeInstanceInformation(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void DescribeParametersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeParametersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeParametersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeParametersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeParameters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeParameters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeParametersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeParametersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeParametersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeParameters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeParameters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void GetParameterHistoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetParameterHistoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetParameterHistoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetParameterHistoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetParameterHistory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetParameterHistory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetParameterHistoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetParameterHistoryRequest>();

            var response = InstantiateClassGenerator.Execute<GetParameterHistoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetParameterHistory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetParameterHistory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void GetParametersByPathTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetParametersByPathRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetParametersByPathResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetParametersByPathResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetParametersByPath(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetParametersByPath(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetParametersByPathTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetParametersByPathRequest>();

            var response = InstantiateClassGenerator.Execute<GetParametersByPathResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetParametersByPath(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetParametersByPath(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void ListAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void ListCommandInvocationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCommandInvocationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCommandInvocationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCommandInvocationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCommandInvocations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCommandInvocations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCommandInvocationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCommandInvocationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCommandInvocationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCommandInvocations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCommandInvocations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void ListCommandsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCommandsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCommandsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCommandsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCommands(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCommands(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCommandsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCommandsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCommandsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCommands(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCommands(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        public void ListDocumentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDocumentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDocumentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDocumentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDocuments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDocuments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleSystemsManagement")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDocumentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDocumentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDocumentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDocuments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDocuments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif