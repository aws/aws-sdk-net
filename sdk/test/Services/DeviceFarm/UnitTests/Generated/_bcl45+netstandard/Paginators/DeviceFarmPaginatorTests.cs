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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */

using Amazon.DeviceFarm;
using Amazon.DeviceFarm.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class DeviceFarmPaginatorTests
    {
        private static Mock<AmazonDeviceFarmClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonDeviceFarmClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        public void GetOfferingStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetOfferingStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetOfferingStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetOfferingStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetOfferingStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetOfferingStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetOfferingStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetOfferingStatusRequest>();

            var response = InstantiateClassGenerator.Execute<GetOfferingStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetOfferingStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetOfferingStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        public void ListArtifactsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListArtifactsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListArtifactsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListArtifactsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListArtifacts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListArtifacts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListArtifactsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListArtifactsRequest>();

            var response = InstantiateClassGenerator.Execute<ListArtifactsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListArtifacts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListArtifacts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        public void ListDevicePoolsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDevicePoolsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDevicePoolsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDevicePoolsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDevicePools(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDevicePools(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDevicePoolsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDevicePoolsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDevicePoolsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDevicePools(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDevicePools(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        public void ListDevicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDevicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDevicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDevicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDevices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDevices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDevicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDevicesRequest>();

            var response = InstantiateClassGenerator.Execute<ListDevicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDevices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDevices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        public void ListJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        public void ListOfferingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOfferingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOfferingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOfferingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListOfferings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOfferings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOfferingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOfferingsRequest>();

            var response = InstantiateClassGenerator.Execute<ListOfferingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListOfferings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOfferings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        public void ListOfferingTransactionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOfferingTransactionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOfferingTransactionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOfferingTransactionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListOfferingTransactions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOfferingTransactions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOfferingTransactionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOfferingTransactionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListOfferingTransactionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListOfferingTransactions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOfferingTransactions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        public void ListProjectsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProjectsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProjectsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProjectsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProjects(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProjects(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProjectsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProjectsRequest>();

            var response = InstantiateClassGenerator.Execute<ListProjectsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProjects(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProjects(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        public void ListRunsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRunsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRunsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRunsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRuns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRuns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRunsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRunsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRunsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRuns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRuns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        public void ListSamplesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSamplesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSamplesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSamplesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSamples(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSamples(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSamplesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSamplesRequest>();

            var response = InstantiateClassGenerator.Execute<ListSamplesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSamples(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSamples(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        public void ListSuitesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSuitesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSuitesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSuitesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSuites(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSuites(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSuitesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSuitesRequest>();

            var response = InstantiateClassGenerator.Execute<ListSuitesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSuites(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSuites(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        public void ListTestGridProjectsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTestGridProjectsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTestGridProjectsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTestGridProjectsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTestGridProjects(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTestGridProjects(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTestGridProjectsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTestGridProjectsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTestGridProjectsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTestGridProjects(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTestGridProjects(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        public void ListTestGridSessionActionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTestGridSessionActionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTestGridSessionActionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTestGridSessionActionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTestGridSessionActions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTestGridSessionActions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTestGridSessionActionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTestGridSessionActionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTestGridSessionActionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTestGridSessionActions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTestGridSessionActions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        public void ListTestGridSessionArtifactsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTestGridSessionArtifactsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTestGridSessionArtifactsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTestGridSessionArtifactsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTestGridSessionArtifacts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTestGridSessionArtifacts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTestGridSessionArtifactsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTestGridSessionArtifactsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTestGridSessionArtifactsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTestGridSessionArtifacts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTestGridSessionArtifacts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        public void ListTestGridSessionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTestGridSessionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTestGridSessionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTestGridSessionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTestGridSessions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTestGridSessions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTestGridSessionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTestGridSessionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTestGridSessionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTestGridSessions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTestGridSessions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        public void ListTestsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTestsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTestsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTestsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTests(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTests(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTestsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTestsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTestsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTests(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTests(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        public void ListUniqueProblemsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUniqueProblemsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUniqueProblemsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUniqueProblemsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListUniqueProblems(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUniqueProblems(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUniqueProblemsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUniqueProblemsRequest>();

            var response = InstantiateClassGenerator.Execute<ListUniqueProblemsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListUniqueProblems(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUniqueProblems(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        public void ListUploadsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUploadsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUploadsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUploadsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListUploads(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUploads(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DeviceFarm")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUploadsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUploadsRequest>();

            var response = InstantiateClassGenerator.Execute<ListUploadsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListUploads(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUploads(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif