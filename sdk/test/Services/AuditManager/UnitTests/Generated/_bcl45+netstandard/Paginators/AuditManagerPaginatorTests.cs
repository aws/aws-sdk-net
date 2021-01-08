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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */

using Amazon.AuditManager;
using Amazon.AuditManager.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class AuditManagerPaginatorTests
    {
        private static Mock<AmazonAuditManagerClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonAuditManagerClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        public void GetChangeLogsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetChangeLogsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetChangeLogsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetChangeLogsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetChangeLogs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetChangeLogs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetChangeLogsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetChangeLogsRequest>();

            var response = InstantiateClassGenerator.Execute<GetChangeLogsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetChangeLogs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetChangeLogs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        public void GetDelegationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetDelegationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetDelegationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetDelegationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetDelegations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetDelegations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetDelegationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetDelegationsRequest>();

            var response = InstantiateClassGenerator.Execute<GetDelegationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetDelegations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetDelegations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        public void GetEvidenceByEvidenceFolderTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetEvidenceByEvidenceFolderRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetEvidenceByEvidenceFolderResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetEvidenceByEvidenceFolderResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetEvidenceByEvidenceFolder(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetEvidenceByEvidenceFolder(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetEvidenceByEvidenceFolderTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetEvidenceByEvidenceFolderRequest>();

            var response = InstantiateClassGenerator.Execute<GetEvidenceByEvidenceFolderResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetEvidenceByEvidenceFolder(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetEvidenceByEvidenceFolder(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        public void GetEvidenceFoldersByAssessmentTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetEvidenceFoldersByAssessmentRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetEvidenceFoldersByAssessmentResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetEvidenceFoldersByAssessmentResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetEvidenceFoldersByAssessment(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetEvidenceFoldersByAssessment(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetEvidenceFoldersByAssessmentTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetEvidenceFoldersByAssessmentRequest>();

            var response = InstantiateClassGenerator.Execute<GetEvidenceFoldersByAssessmentResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetEvidenceFoldersByAssessment(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetEvidenceFoldersByAssessment(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        public void GetEvidenceFoldersByAssessmentControlTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetEvidenceFoldersByAssessmentControlRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetEvidenceFoldersByAssessmentControlResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetEvidenceFoldersByAssessmentControlResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetEvidenceFoldersByAssessmentControl(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetEvidenceFoldersByAssessmentControl(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetEvidenceFoldersByAssessmentControlTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetEvidenceFoldersByAssessmentControlRequest>();

            var response = InstantiateClassGenerator.Execute<GetEvidenceFoldersByAssessmentControlResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetEvidenceFoldersByAssessmentControl(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetEvidenceFoldersByAssessmentControl(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        public void ListAssessmentFrameworksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssessmentFrameworksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssessmentFrameworksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssessmentFrameworksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssessmentFrameworks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssessmentFrameworks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssessmentFrameworksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssessmentFrameworksRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssessmentFrameworksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssessmentFrameworks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssessmentFrameworks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        public void ListAssessmentReportsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssessmentReportsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssessmentReportsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssessmentReportsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssessmentReports(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssessmentReports(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssessmentReportsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssessmentReportsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssessmentReportsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssessmentReports(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssessmentReports(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        public void ListAssessmentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssessmentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssessmentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssessmentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssessments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssessments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssessmentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssessmentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssessmentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssessments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssessments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        public void ListControlsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListControlsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListControlsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListControlsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListControls(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListControls(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListControlsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListControlsRequest>();

            var response = InstantiateClassGenerator.Execute<ListControlsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListControls(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListControls(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        public void ListKeywordsForDataSourceTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListKeywordsForDataSourceRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListKeywordsForDataSourceResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListKeywordsForDataSourceResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListKeywordsForDataSource(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListKeywordsForDataSource(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListKeywordsForDataSourceTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListKeywordsForDataSourceRequest>();

            var response = InstantiateClassGenerator.Execute<ListKeywordsForDataSourceResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListKeywordsForDataSource(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListKeywordsForDataSource(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        public void ListNotificationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListNotificationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListNotificationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListNotificationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListNotifications(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListNotifications(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AuditManager")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListNotificationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListNotificationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListNotificationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListNotifications(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListNotifications(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif