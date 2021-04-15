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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */

using Amazon.DatabaseMigrationService;
using Amazon.DatabaseMigrationService.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class DatabaseMigrationServicePaginatorTests
    {
        private static Mock<AmazonDatabaseMigrationServiceClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonDatabaseMigrationServiceClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribeApplicableIndividualAssessmentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeApplicableIndividualAssessmentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeApplicableIndividualAssessmentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeApplicableIndividualAssessmentsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeApplicableIndividualAssessments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeApplicableIndividualAssessments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeApplicableIndividualAssessmentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeApplicableIndividualAssessmentsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeApplicableIndividualAssessmentsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeApplicableIndividualAssessments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeApplicableIndividualAssessments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribeCertificatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCertificatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeCertificatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeCertificatesResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeCertificates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeCertificates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeCertificatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCertificatesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeCertificatesResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeCertificates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeCertificates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribeConnectionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConnectionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeConnectionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeConnectionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeConnections(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeConnections(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeConnectionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeConnectionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeConnectionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeConnections(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeConnections(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribeEndpointsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEndpointsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEndpointsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEndpointsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeEndpoints(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEndpoints(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEndpointsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEndpointsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEndpointsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeEndpoints(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEndpoints(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribeEndpointSettingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEndpointSettingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEndpointSettingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEndpointSettingsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeEndpointSettings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEndpointSettings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEndpointSettingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEndpointSettingsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEndpointSettingsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeEndpointSettings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEndpointSettings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribeEndpointTypesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEndpointTypesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEndpointTypesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEndpointTypesResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeEndpointTypes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEndpointTypes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEndpointTypesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEndpointTypesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEndpointTypesResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeEndpointTypes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEndpointTypes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribeEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEventsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEventsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribeEventSubscriptionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeEventSubscriptions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEventSubscriptions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEventSubscriptionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEventSubscriptionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeEventSubscriptions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEventSubscriptions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribeOrderableReplicationInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOrderableReplicationInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeOrderableReplicationInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeOrderableReplicationInstancesResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeOrderableReplicationInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeOrderableReplicationInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeOrderableReplicationInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeOrderableReplicationInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeOrderableReplicationInstancesResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeOrderableReplicationInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeOrderableReplicationInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribePendingMaintenanceActionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribePendingMaintenanceActionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribePendingMaintenanceActionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribePendingMaintenanceActionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribePendingMaintenanceActions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribePendingMaintenanceActions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribePendingMaintenanceActionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribePendingMaintenanceActionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribePendingMaintenanceActionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribePendingMaintenanceActions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribePendingMaintenanceActions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribeReplicationInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReplicationInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReplicationInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReplicationInstancesResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeReplicationInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReplicationInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReplicationInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReplicationInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReplicationInstancesResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeReplicationInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReplicationInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribeReplicationInstanceTaskLogsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReplicationInstanceTaskLogsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReplicationInstanceTaskLogsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReplicationInstanceTaskLogsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeReplicationInstanceTaskLogs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReplicationInstanceTaskLogs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReplicationInstanceTaskLogsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReplicationInstanceTaskLogsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReplicationInstanceTaskLogsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeReplicationInstanceTaskLogs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReplicationInstanceTaskLogs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribeReplicationSubnetGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReplicationSubnetGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReplicationSubnetGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReplicationSubnetGroupsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeReplicationSubnetGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReplicationSubnetGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReplicationSubnetGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReplicationSubnetGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReplicationSubnetGroupsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeReplicationSubnetGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReplicationSubnetGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribeReplicationTaskAssessmentResultsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReplicationTaskAssessmentResultsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReplicationTaskAssessmentResultsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReplicationTaskAssessmentResultsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeReplicationTaskAssessmentResults(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReplicationTaskAssessmentResults(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReplicationTaskAssessmentResultsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReplicationTaskAssessmentResultsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReplicationTaskAssessmentResultsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeReplicationTaskAssessmentResults(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReplicationTaskAssessmentResults(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribeReplicationTaskAssessmentRunsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReplicationTaskAssessmentRunsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReplicationTaskAssessmentRunsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReplicationTaskAssessmentRunsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeReplicationTaskAssessmentRuns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReplicationTaskAssessmentRuns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReplicationTaskAssessmentRunsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReplicationTaskAssessmentRunsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReplicationTaskAssessmentRunsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeReplicationTaskAssessmentRuns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReplicationTaskAssessmentRuns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribeReplicationTaskIndividualAssessmentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReplicationTaskIndividualAssessmentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReplicationTaskIndividualAssessmentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReplicationTaskIndividualAssessmentsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeReplicationTaskIndividualAssessments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReplicationTaskIndividualAssessments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReplicationTaskIndividualAssessmentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReplicationTaskIndividualAssessmentsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReplicationTaskIndividualAssessmentsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeReplicationTaskIndividualAssessments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReplicationTaskIndividualAssessments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribeReplicationTasksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReplicationTasksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReplicationTasksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReplicationTasksResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeReplicationTasks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReplicationTasks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReplicationTasksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReplicationTasksRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReplicationTasksResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeReplicationTasks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReplicationTasks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribeSchemasTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSchemasRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeSchemasResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeSchemasResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeSchemas(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeSchemas(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeSchemasTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSchemasRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeSchemasResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeSchemas(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeSchemas(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        public void DescribeTableStatisticsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTableStatisticsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTableStatisticsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTableStatisticsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeTableStatistics(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTableStatistics(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DatabaseMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTableStatisticsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTableStatisticsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTableStatisticsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeTableStatistics(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTableStatistics(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}