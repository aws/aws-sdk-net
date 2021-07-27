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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
 */

using Amazon.Route53RecoveryReadiness;
using Amazon.Route53RecoveryReadiness.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class Route53RecoveryReadinessPaginatorTests
    {
        private static Mock<AmazonRoute53RecoveryReadinessClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonRoute53RecoveryReadinessClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        public void GetCellReadinessSummaryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetCellReadinessSummaryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetCellReadinessSummaryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetCellReadinessSummaryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetCellReadinessSummary(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetCellReadinessSummary(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetCellReadinessSummaryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetCellReadinessSummaryRequest>();

            var response = InstantiateClassGenerator.Execute<GetCellReadinessSummaryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetCellReadinessSummary(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetCellReadinessSummary(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        public void GetReadinessCheckResourceStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetReadinessCheckResourceStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetReadinessCheckResourceStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetReadinessCheckResourceStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetReadinessCheckResourceStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetReadinessCheckResourceStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetReadinessCheckResourceStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetReadinessCheckResourceStatusRequest>();

            var response = InstantiateClassGenerator.Execute<GetReadinessCheckResourceStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetReadinessCheckResourceStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetReadinessCheckResourceStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        public void GetReadinessCheckStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetReadinessCheckStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetReadinessCheckStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetReadinessCheckStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetReadinessCheckStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetReadinessCheckStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetReadinessCheckStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetReadinessCheckStatusRequest>();

            var response = InstantiateClassGenerator.Execute<GetReadinessCheckStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetReadinessCheckStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetReadinessCheckStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        public void GetRecoveryGroupReadinessSummaryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetRecoveryGroupReadinessSummaryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetRecoveryGroupReadinessSummaryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetRecoveryGroupReadinessSummaryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetRecoveryGroupReadinessSummary(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetRecoveryGroupReadinessSummary(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetRecoveryGroupReadinessSummaryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetRecoveryGroupReadinessSummaryRequest>();

            var response = InstantiateClassGenerator.Execute<GetRecoveryGroupReadinessSummaryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetRecoveryGroupReadinessSummary(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetRecoveryGroupReadinessSummary(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        public void ListCellsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCellsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCellsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCellsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCells(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCells(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCellsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCellsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCellsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCells(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCells(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        public void ListCrossAccountAuthorizationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCrossAccountAuthorizationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCrossAccountAuthorizationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCrossAccountAuthorizationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCrossAccountAuthorizations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCrossAccountAuthorizations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCrossAccountAuthorizationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCrossAccountAuthorizationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCrossAccountAuthorizationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCrossAccountAuthorizations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCrossAccountAuthorizations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        public void ListReadinessChecksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListReadinessChecksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListReadinessChecksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListReadinessChecksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListReadinessChecks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListReadinessChecks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListReadinessChecksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListReadinessChecksRequest>();

            var response = InstantiateClassGenerator.Execute<ListReadinessChecksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListReadinessChecks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListReadinessChecks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        public void ListRecoveryGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRecoveryGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRecoveryGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRecoveryGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRecoveryGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRecoveryGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRecoveryGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRecoveryGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRecoveryGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRecoveryGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRecoveryGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        public void ListResourceSetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResourceSetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResourceSetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResourceSetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResourceSets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResourceSets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResourceSetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResourceSetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListResourceSetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResourceSets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResourceSets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        public void ListRulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRulesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryReadiness")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRulesRequest>();

            var response = InstantiateClassGenerator.Execute<ListRulesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}