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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */

using Amazon.IoT;
using Amazon.IoT.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class IoTPaginatorTests
    {
        private static Mock<AmazonIoTClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonIoTClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void GetBehaviorModelTrainingSummariesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetBehaviorModelTrainingSummariesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetBehaviorModelTrainingSummariesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetBehaviorModelTrainingSummariesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetBehaviorModelTrainingSummaries(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetBehaviorModelTrainingSummaries(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetBehaviorModelTrainingSummariesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetBehaviorModelTrainingSummariesRequest>();

            var response = InstantiateClassGenerator.Execute<GetBehaviorModelTrainingSummariesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetBehaviorModelTrainingSummaries(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetBehaviorModelTrainingSummaries(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListActiveViolationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListActiveViolationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListActiveViolationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListActiveViolationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListActiveViolations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListActiveViolations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListActiveViolationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListActiveViolationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListActiveViolationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListActiveViolations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListActiveViolations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListAttachedPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAttachedPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAttachedPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAttachedPoliciesResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListAttachedPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAttachedPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAttachedPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAttachedPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAttachedPoliciesResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListAttachedPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAttachedPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListAuditFindingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAuditFindingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAuditFindingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAuditFindingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAuditFindings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAuditFindings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAuditFindingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAuditFindingsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAuditFindingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAuditFindings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAuditFindings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListAuditMitigationActionsExecutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAuditMitigationActionsExecutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAuditMitigationActionsExecutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAuditMitigationActionsExecutionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAuditMitigationActionsExecutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAuditMitigationActionsExecutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAuditMitigationActionsExecutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAuditMitigationActionsExecutionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAuditMitigationActionsExecutionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAuditMitigationActionsExecutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAuditMitigationActionsExecutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListAuditMitigationActionsTasksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAuditMitigationActionsTasksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAuditMitigationActionsTasksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAuditMitigationActionsTasksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAuditMitigationActionsTasks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAuditMitigationActionsTasks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAuditMitigationActionsTasksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAuditMitigationActionsTasksRequest>();

            var response = InstantiateClassGenerator.Execute<ListAuditMitigationActionsTasksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAuditMitigationActionsTasks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAuditMitigationActionsTasks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListAuditSuppressionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAuditSuppressionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAuditSuppressionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAuditSuppressionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAuditSuppressions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAuditSuppressions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAuditSuppressionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAuditSuppressionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAuditSuppressionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAuditSuppressions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAuditSuppressions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListAuditTasksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAuditTasksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAuditTasksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAuditTasksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAuditTasks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAuditTasks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAuditTasksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAuditTasksRequest>();

            var response = InstantiateClassGenerator.Execute<ListAuditTasksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAuditTasks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAuditTasks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListAuthorizersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAuthorizersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAuthorizersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAuthorizersResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListAuthorizers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAuthorizers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAuthorizersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAuthorizersRequest>();

            var response = InstantiateClassGenerator.Execute<ListAuthorizersResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListAuthorizers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAuthorizers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListBillingGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBillingGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBillingGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBillingGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBillingGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBillingGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBillingGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBillingGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListBillingGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBillingGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBillingGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListCACertificatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCACertificatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCACertificatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCACertificatesResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListCACertificates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCACertificates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCACertificatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCACertificatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListCACertificatesResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListCACertificates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCACertificates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListCertificatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCertificatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCertificatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCertificatesResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListCertificates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCertificates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCertificatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCertificatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListCertificatesResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListCertificates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCertificates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListCertificatesByCATest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCertificatesByCARequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCertificatesByCAResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCertificatesByCAResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListCertificatesByCA(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCertificatesByCA(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCertificatesByCATest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCertificatesByCARequest>();

            var response = InstantiateClassGenerator.Execute<ListCertificatesByCAResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListCertificatesByCA(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCertificatesByCA(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListCustomMetricsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomMetricsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCustomMetricsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCustomMetricsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCustomMetrics(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCustomMetrics(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCustomMetricsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomMetricsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCustomMetricsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCustomMetrics(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCustomMetrics(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListDetectMitigationActionsExecutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDetectMitigationActionsExecutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDetectMitigationActionsExecutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDetectMitigationActionsExecutionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDetectMitigationActionsExecutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDetectMitigationActionsExecutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDetectMitigationActionsExecutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDetectMitigationActionsExecutionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDetectMitigationActionsExecutionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDetectMitigationActionsExecutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDetectMitigationActionsExecutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListDetectMitigationActionsTasksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDetectMitigationActionsTasksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDetectMitigationActionsTasksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDetectMitigationActionsTasksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDetectMitigationActionsTasks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDetectMitigationActionsTasks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDetectMitigationActionsTasksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDetectMitigationActionsTasksRequest>();

            var response = InstantiateClassGenerator.Execute<ListDetectMitigationActionsTasksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDetectMitigationActionsTasks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDetectMitigationActionsTasks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListDimensionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDimensionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDimensionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDimensionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDimensions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDimensions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDimensionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDimensionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDimensionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDimensions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDimensions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListDomainConfigurationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDomainConfigurationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDomainConfigurationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDomainConfigurationsResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListDomainConfigurations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDomainConfigurations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDomainConfigurationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDomainConfigurationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDomainConfigurationsResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListDomainConfigurations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDomainConfigurations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListIndicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListIndicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListIndicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListIndicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListIndices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListIndices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListIndicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListIndicesRequest>();

            var response = InstantiateClassGenerator.Execute<ListIndicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListIndices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListIndices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListJobExecutionsForJobTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListJobExecutionsForJobRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListJobExecutionsForJobResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListJobExecutionsForJobResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListJobExecutionsForJob(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListJobExecutionsForJob(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListJobExecutionsForJobTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListJobExecutionsForJobRequest>();

            var response = InstantiateClassGenerator.Execute<ListJobExecutionsForJobResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListJobExecutionsForJob(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListJobExecutionsForJob(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListJobExecutionsForThingTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListJobExecutionsForThingRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListJobExecutionsForThingResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListJobExecutionsForThingResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListJobExecutionsForThing(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListJobExecutionsForThing(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListJobExecutionsForThingTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListJobExecutionsForThingRequest>();

            var response = InstantiateClassGenerator.Execute<ListJobExecutionsForThingResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListJobExecutionsForThing(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListJobExecutionsForThing(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
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
        [TestCategory("IoT")]
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
        [TestCategory("IoT")]
        public void ListMitigationActionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMitigationActionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMitigationActionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMitigationActionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMitigationActions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMitigationActions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMitigationActionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMitigationActionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListMitigationActionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMitigationActions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMitigationActions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListOTAUpdatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOTAUpdatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOTAUpdatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOTAUpdatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListOTAUpdates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOTAUpdates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOTAUpdatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOTAUpdatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListOTAUpdatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListOTAUpdates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOTAUpdates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListOutgoingCertificatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOutgoingCertificatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOutgoingCertificatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOutgoingCertificatesResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListOutgoingCertificates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOutgoingCertificates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOutgoingCertificatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOutgoingCertificatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListOutgoingCertificatesResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListOutgoingCertificates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOutgoingCertificates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPoliciesResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListPoliciesResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListPolicyPrincipalsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPolicyPrincipalsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPolicyPrincipalsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPolicyPrincipalsResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListPolicyPrincipals(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPolicyPrincipals(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPolicyPrincipalsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPolicyPrincipalsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPolicyPrincipalsResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListPolicyPrincipals(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPolicyPrincipals(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListPrincipalPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPrincipalPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPrincipalPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPrincipalPoliciesResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListPrincipalPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPrincipalPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPrincipalPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPrincipalPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListPrincipalPoliciesResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListPrincipalPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPrincipalPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListProvisioningTemplatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProvisioningTemplatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProvisioningTemplatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProvisioningTemplatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProvisioningTemplates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProvisioningTemplates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProvisioningTemplatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProvisioningTemplatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListProvisioningTemplatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProvisioningTemplates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProvisioningTemplates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListProvisioningTemplateVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProvisioningTemplateVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProvisioningTemplateVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProvisioningTemplateVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProvisioningTemplateVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProvisioningTemplateVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProvisioningTemplateVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProvisioningTemplateVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListProvisioningTemplateVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProvisioningTemplateVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProvisioningTemplateVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListRoleAliasesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRoleAliasesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRoleAliasesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRoleAliasesResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListRoleAliases(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRoleAliases(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRoleAliasesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRoleAliasesRequest>();

            var response = InstantiateClassGenerator.Execute<ListRoleAliasesResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListRoleAliases(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRoleAliases(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListScheduledAuditsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListScheduledAuditsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListScheduledAuditsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListScheduledAuditsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListScheduledAudits(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListScheduledAudits(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListScheduledAuditsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListScheduledAuditsRequest>();

            var response = InstantiateClassGenerator.Execute<ListScheduledAuditsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListScheduledAudits(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListScheduledAudits(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListSecurityProfilesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSecurityProfilesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSecurityProfilesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSecurityProfilesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSecurityProfiles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSecurityProfiles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSecurityProfilesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSecurityProfilesRequest>();

            var response = InstantiateClassGenerator.Execute<ListSecurityProfilesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSecurityProfiles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSecurityProfiles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListSecurityProfilesForTargetTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSecurityProfilesForTargetRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSecurityProfilesForTargetResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSecurityProfilesForTargetResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSecurityProfilesForTarget(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSecurityProfilesForTarget(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSecurityProfilesForTargetTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSecurityProfilesForTargetRequest>();

            var response = InstantiateClassGenerator.Execute<ListSecurityProfilesForTargetResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSecurityProfilesForTarget(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSecurityProfilesForTarget(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListStreamsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStreamsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStreamsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStreamsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStreams(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStreams(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStreamsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStreamsRequest>();

            var response = InstantiateClassGenerator.Execute<ListStreamsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStreams(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStreams(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
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
        [TestCategory("IoT")]
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
        [TestCategory("IoT")]
        public void ListTargetsForPolicyTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTargetsForPolicyRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTargetsForPolicyResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTargetsForPolicyResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.ListTargetsForPolicy(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTargetsForPolicy(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTargetsForPolicyTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTargetsForPolicyRequest>();

            var response = InstantiateClassGenerator.Execute<ListTargetsForPolicyResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.ListTargetsForPolicy(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTargetsForPolicy(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListTargetsForSecurityProfileTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTargetsForSecurityProfileRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTargetsForSecurityProfileResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTargetsForSecurityProfileResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTargetsForSecurityProfile(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTargetsForSecurityProfile(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTargetsForSecurityProfileTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTargetsForSecurityProfileRequest>();

            var response = InstantiateClassGenerator.Execute<ListTargetsForSecurityProfileResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTargetsForSecurityProfile(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTargetsForSecurityProfile(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListThingGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListThingGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListThingGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListThingGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListThingGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListThingGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListThingGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListThingGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListThingGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListThingGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListThingGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListThingGroupsForThingTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListThingGroupsForThingRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListThingGroupsForThingResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListThingGroupsForThingResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListThingGroupsForThing(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListThingGroupsForThing(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListThingGroupsForThingTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListThingGroupsForThingRequest>();

            var response = InstantiateClassGenerator.Execute<ListThingGroupsForThingResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListThingGroupsForThing(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListThingGroupsForThing(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListThingPrincipalsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListThingPrincipalsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListThingPrincipalsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListThingPrincipalsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListThingPrincipals(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListThingPrincipals(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListThingPrincipalsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListThingPrincipalsRequest>();

            var response = InstantiateClassGenerator.Execute<ListThingPrincipalsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListThingPrincipals(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListThingPrincipals(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListThingRegistrationTaskReportsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListThingRegistrationTaskReportsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListThingRegistrationTaskReportsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListThingRegistrationTaskReportsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListThingRegistrationTaskReports(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListThingRegistrationTaskReports(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListThingRegistrationTaskReportsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListThingRegistrationTaskReportsRequest>();

            var response = InstantiateClassGenerator.Execute<ListThingRegistrationTaskReportsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListThingRegistrationTaskReports(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListThingRegistrationTaskReports(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListThingRegistrationTasksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListThingRegistrationTasksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListThingRegistrationTasksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListThingRegistrationTasksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListThingRegistrationTasks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListThingRegistrationTasks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListThingRegistrationTasksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListThingRegistrationTasksRequest>();

            var response = InstantiateClassGenerator.Execute<ListThingRegistrationTasksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListThingRegistrationTasks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListThingRegistrationTasks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListThingsInBillingGroupTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListThingsInBillingGroupRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListThingsInBillingGroupResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListThingsInBillingGroupResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListThingsInBillingGroup(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListThingsInBillingGroup(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListThingsInBillingGroupTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListThingsInBillingGroupRequest>();

            var response = InstantiateClassGenerator.Execute<ListThingsInBillingGroupResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListThingsInBillingGroup(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListThingsInBillingGroup(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListThingsInThingGroupTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListThingsInThingGroupRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListThingsInThingGroupResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListThingsInThingGroupResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListThingsInThingGroup(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListThingsInThingGroup(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListThingsInThingGroupTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListThingsInThingGroupRequest>();

            var response = InstantiateClassGenerator.Execute<ListThingsInThingGroupResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListThingsInThingGroup(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListThingsInThingGroup(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListThingTypesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListThingTypesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListThingTypesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListThingTypesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListThingTypes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListThingTypes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListThingTypesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListThingTypesRequest>();

            var response = InstantiateClassGenerator.Execute<ListThingTypesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListThingTypes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListThingTypes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListTopicRuleDestinationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTopicRuleDestinationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTopicRuleDestinationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTopicRuleDestinationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTopicRuleDestinations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTopicRuleDestinations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTopicRuleDestinationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTopicRuleDestinationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTopicRuleDestinationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTopicRuleDestinations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTopicRuleDestinations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListV2LoggingLevelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListV2LoggingLevelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListV2LoggingLevelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListV2LoggingLevelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListV2LoggingLevels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListV2LoggingLevels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListV2LoggingLevelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListV2LoggingLevelsRequest>();

            var response = InstantiateClassGenerator.Execute<ListV2LoggingLevelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListV2LoggingLevels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListV2LoggingLevels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        public void ListViolationEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListViolationEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListViolationEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListViolationEventsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListViolationEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListViolationEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoT")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListViolationEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListViolationEventsRequest>();

            var response = InstantiateClassGenerator.Execute<ListViolationEventsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListViolationEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListViolationEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif