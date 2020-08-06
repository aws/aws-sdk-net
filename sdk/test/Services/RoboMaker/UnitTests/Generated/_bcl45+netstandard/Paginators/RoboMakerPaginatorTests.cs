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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */

using Amazon.RoboMaker;
using Amazon.RoboMaker.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class RoboMakerPaginatorTests
    {
        private static Mock<AmazonRoboMakerClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonRoboMakerClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        public void ListDeploymentJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDeploymentJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDeploymentJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDeploymentJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDeploymentJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDeploymentJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDeploymentJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDeploymentJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDeploymentJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDeploymentJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDeploymentJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        public void ListFleetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFleetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFleetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFleetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFleets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFleets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFleetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFleetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListFleetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFleets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFleets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        public void ListRobotApplicationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRobotApplicationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRobotApplicationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRobotApplicationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRobotApplications(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRobotApplications(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRobotApplicationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRobotApplicationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRobotApplicationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRobotApplications(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRobotApplications(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        public void ListRobotsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRobotsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRobotsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRobotsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRobots(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRobots(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRobotsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRobotsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRobotsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRobots(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRobots(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        public void ListSimulationApplicationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSimulationApplicationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSimulationApplicationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSimulationApplicationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSimulationApplications(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSimulationApplications(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSimulationApplicationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSimulationApplicationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSimulationApplicationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSimulationApplications(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSimulationApplications(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        public void ListSimulationJobBatchesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSimulationJobBatchesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSimulationJobBatchesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSimulationJobBatchesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSimulationJobBatches(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSimulationJobBatches(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSimulationJobBatchesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSimulationJobBatchesRequest>();

            var response = InstantiateClassGenerator.Execute<ListSimulationJobBatchesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSimulationJobBatches(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSimulationJobBatches(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        public void ListSimulationJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSimulationJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSimulationJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSimulationJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSimulationJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSimulationJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSimulationJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSimulationJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSimulationJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSimulationJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSimulationJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        public void ListWorldExportJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWorldExportJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWorldExportJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWorldExportJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWorldExportJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWorldExportJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWorldExportJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWorldExportJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListWorldExportJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWorldExportJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWorldExportJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        public void ListWorldGenerationJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWorldGenerationJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWorldGenerationJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWorldGenerationJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWorldGenerationJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWorldGenerationJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWorldGenerationJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWorldGenerationJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListWorldGenerationJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWorldGenerationJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWorldGenerationJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        public void ListWorldsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWorldsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWorldsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWorldsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWorlds(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWorlds(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWorldsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWorldsRequest>();

            var response = InstantiateClassGenerator.Execute<ListWorldsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWorlds(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWorlds(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        public void ListWorldTemplatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWorldTemplatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWorldTemplatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWorldTemplatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWorldTemplates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWorldTemplates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("RoboMaker")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWorldTemplatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWorldTemplatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListWorldTemplatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWorldTemplates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWorldTemplates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif