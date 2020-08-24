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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */

using Amazon.StepFunctions;
using Amazon.StepFunctions.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class StepFunctionsPaginatorTests
    {
        private static Mock<AmazonStepFunctionsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonStepFunctionsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StepFunctions")]
        public void GetExecutionHistoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetExecutionHistoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetExecutionHistoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetExecutionHistoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetExecutionHistory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetExecutionHistory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StepFunctions")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetExecutionHistoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetExecutionHistoryRequest>();

            var response = InstantiateClassGenerator.Execute<GetExecutionHistoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetExecutionHistory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetExecutionHistory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StepFunctions")]
        public void ListActivitiesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListActivitiesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListActivitiesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListActivitiesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListActivities(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListActivities(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StepFunctions")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListActivitiesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListActivitiesRequest>();

            var response = InstantiateClassGenerator.Execute<ListActivitiesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListActivities(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListActivities(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StepFunctions")]
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
        [TestCategory("StepFunctions")]
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
        [TestCategory("StepFunctions")]
        public void ListStateMachinesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStateMachinesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStateMachinesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStateMachinesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStateMachines(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStateMachines(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("StepFunctions")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStateMachinesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStateMachinesRequest>();

            var response = InstantiateClassGenerator.Execute<ListStateMachinesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStateMachines(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStateMachines(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif