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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */

using Amazon.SimpleWorkflow;
using Amazon.SimpleWorkflow.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SimpleWorkflowPaginatorTests
    {
        private static Mock<AmazonSimpleWorkflowClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSimpleWorkflowClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleWorkflow")]
        public void GetWorkflowExecutionHistoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetWorkflowExecutionHistoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetWorkflowExecutionHistoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetWorkflowExecutionHistoryResponse>();
            secondResponse.History.NextPageToken = null;

            _mockClient.SetupSequence(x => x.GetWorkflowExecutionHistory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetWorkflowExecutionHistory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleWorkflow")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetWorkflowExecutionHistoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetWorkflowExecutionHistoryRequest>();

            var response = InstantiateClassGenerator.Execute<GetWorkflowExecutionHistoryResponse>();
            response.History.NextPageToken = null;

            _mockClient.Setup(x => x.GetWorkflowExecutionHistory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetWorkflowExecutionHistory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleWorkflow")]
        public void ListActivityTypesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListActivityTypesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListActivityTypesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListActivityTypesResponse>();
            secondResponse.ActivityTypeInfos.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListActivityTypes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListActivityTypes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleWorkflow")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListActivityTypesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListActivityTypesRequest>();

            var response = InstantiateClassGenerator.Execute<ListActivityTypesResponse>();
            response.ActivityTypeInfos.NextPageToken = null;

            _mockClient.Setup(x => x.ListActivityTypes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListActivityTypes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleWorkflow")]
        public void ListClosedWorkflowExecutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListClosedWorkflowExecutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListClosedWorkflowExecutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListClosedWorkflowExecutionsResponse>();
            secondResponse.WorkflowExecutionInfos.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListClosedWorkflowExecutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListClosedWorkflowExecutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleWorkflow")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListClosedWorkflowExecutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListClosedWorkflowExecutionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListClosedWorkflowExecutionsResponse>();
            response.WorkflowExecutionInfos.NextPageToken = null;

            _mockClient.Setup(x => x.ListClosedWorkflowExecutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListClosedWorkflowExecutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleWorkflow")]
        public void ListDomainsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDomainsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDomainsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDomainsResponse>();
            secondResponse.DomainInfos.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListDomains(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDomains(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleWorkflow")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDomainsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDomainsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDomainsResponse>();
            response.DomainInfos.NextPageToken = null;

            _mockClient.Setup(x => x.ListDomains(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDomains(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleWorkflow")]
        public void ListOpenWorkflowExecutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOpenWorkflowExecutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOpenWorkflowExecutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOpenWorkflowExecutionsResponse>();
            secondResponse.WorkflowExecutionInfos.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListOpenWorkflowExecutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOpenWorkflowExecutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleWorkflow")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOpenWorkflowExecutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOpenWorkflowExecutionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListOpenWorkflowExecutionsResponse>();
            response.WorkflowExecutionInfos.NextPageToken = null;

            _mockClient.Setup(x => x.ListOpenWorkflowExecutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOpenWorkflowExecutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleWorkflow")]
        public void ListWorkflowTypesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkflowTypesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWorkflowTypesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWorkflowTypesResponse>();
            secondResponse.WorkflowTypeInfos.NextPageToken = null;

            _mockClient.SetupSequence(x => x.ListWorkflowTypes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWorkflowTypes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleWorkflow")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWorkflowTypesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkflowTypesRequest>();

            var response = InstantiateClassGenerator.Execute<ListWorkflowTypesResponse>();
            response.WorkflowTypeInfos.NextPageToken = null;

            _mockClient.Setup(x => x.ListWorkflowTypes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWorkflowTypes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleWorkflow")]
        public void PollForDecisionTaskTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<PollForDecisionTaskRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<PollForDecisionTaskResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<PollForDecisionTaskResponse>();
            secondResponse.DecisionTask.NextPageToken = null;

            _mockClient.SetupSequence(x => x.PollForDecisionTask(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.PollForDecisionTask(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleWorkflow")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void PollForDecisionTaskTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<PollForDecisionTaskRequest>();

            var response = InstantiateClassGenerator.Execute<PollForDecisionTaskResponse>();
            response.DecisionTask.NextPageToken = null;

            _mockClient.Setup(x => x.PollForDecisionTask(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.PollForDecisionTask(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif