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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */

using Amazon.MTurk;
using Amazon.MTurk.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class MTurkPaginatorTests
    {
        private static Mock<AmazonMTurkClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonMTurkClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        public void ListAssignmentsForHITTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssignmentsForHITRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssignmentsForHITResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssignmentsForHITResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssignmentsForHIT(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssignmentsForHIT(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssignmentsForHITTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssignmentsForHITRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssignmentsForHITResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssignmentsForHIT(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssignmentsForHIT(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        public void ListBonusPaymentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBonusPaymentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBonusPaymentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBonusPaymentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBonusPayments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBonusPayments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBonusPaymentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBonusPaymentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListBonusPaymentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBonusPayments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBonusPayments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        public void ListHITsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListHITsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListHITsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListHITsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListHITs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListHITs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListHITsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListHITsRequest>();

            var response = InstantiateClassGenerator.Execute<ListHITsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListHITs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListHITs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        public void ListHITsForQualificationTypeTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListHITsForQualificationTypeRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListHITsForQualificationTypeResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListHITsForQualificationTypeResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListHITsForQualificationType(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListHITsForQualificationType(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListHITsForQualificationTypeTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListHITsForQualificationTypeRequest>();

            var response = InstantiateClassGenerator.Execute<ListHITsForQualificationTypeResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListHITsForQualificationType(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListHITsForQualificationType(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        public void ListQualificationRequestsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListQualificationRequestsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListQualificationRequestsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListQualificationRequestsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListQualificationRequests(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListQualificationRequests(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListQualificationRequestsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListQualificationRequestsRequest>();

            var response = InstantiateClassGenerator.Execute<ListQualificationRequestsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListQualificationRequests(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListQualificationRequests(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        public void ListQualificationTypesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListQualificationTypesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListQualificationTypesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListQualificationTypesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListQualificationTypes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListQualificationTypes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListQualificationTypesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListQualificationTypesRequest>();

            var response = InstantiateClassGenerator.Execute<ListQualificationTypesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListQualificationTypes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListQualificationTypes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        public void ListReviewableHITsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListReviewableHITsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListReviewableHITsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListReviewableHITsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListReviewableHITs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListReviewableHITs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListReviewableHITsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListReviewableHITsRequest>();

            var response = InstantiateClassGenerator.Execute<ListReviewableHITsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListReviewableHITs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListReviewableHITs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        public void ListReviewPolicyResultsForHITTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListReviewPolicyResultsForHITRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListReviewPolicyResultsForHITResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListReviewPolicyResultsForHITResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListReviewPolicyResultsForHIT(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListReviewPolicyResultsForHIT(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListReviewPolicyResultsForHITTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListReviewPolicyResultsForHITRequest>();

            var response = InstantiateClassGenerator.Execute<ListReviewPolicyResultsForHITResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListReviewPolicyResultsForHIT(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListReviewPolicyResultsForHIT(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        public void ListWorkerBlocksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkerBlocksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWorkerBlocksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWorkerBlocksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWorkerBlocks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWorkerBlocks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWorkerBlocksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkerBlocksRequest>();

            var response = InstantiateClassGenerator.Execute<ListWorkerBlocksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWorkerBlocks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWorkerBlocks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        public void ListWorkersWithQualificationTypeTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkersWithQualificationTypeRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWorkersWithQualificationTypeResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWorkersWithQualificationTypeResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWorkersWithQualificationType(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWorkersWithQualificationType(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MTurk")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWorkersWithQualificationTypeTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkersWithQualificationTypeRequest>();

            var response = InstantiateClassGenerator.Execute<ListWorkersWithQualificationTypeResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWorkersWithQualificationType(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWorkersWithQualificationType(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}