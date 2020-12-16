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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */

using Amazon.WellArchitected;
using Amazon.WellArchitected.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class WellArchitectedPaginatorTests
    {
        private static Mock<AmazonWellArchitectedClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonWellArchitectedClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WellArchitected")]
        public void ListAnswersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAnswersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAnswersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAnswersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAnswers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAnswers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WellArchitected")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAnswersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAnswersRequest>();

            var response = InstantiateClassGenerator.Execute<ListAnswersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAnswers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAnswers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WellArchitected")]
        public void ListLensesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLensesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLensesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLensesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListLenses(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLenses(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WellArchitected")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLensesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLensesRequest>();

            var response = InstantiateClassGenerator.Execute<ListLensesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListLenses(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLenses(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WellArchitected")]
        public void ListLensReviewImprovementsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLensReviewImprovementsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLensReviewImprovementsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLensReviewImprovementsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListLensReviewImprovements(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLensReviewImprovements(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WellArchitected")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLensReviewImprovementsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLensReviewImprovementsRequest>();

            var response = InstantiateClassGenerator.Execute<ListLensReviewImprovementsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListLensReviewImprovements(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLensReviewImprovements(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WellArchitected")]
        public void ListLensReviewsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLensReviewsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLensReviewsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLensReviewsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListLensReviews(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLensReviews(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WellArchitected")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLensReviewsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLensReviewsRequest>();

            var response = InstantiateClassGenerator.Execute<ListLensReviewsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListLensReviews(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLensReviews(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WellArchitected")]
        public void ListMilestonesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMilestonesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMilestonesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMilestonesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMilestones(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMilestones(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WellArchitected")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMilestonesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMilestonesRequest>();

            var response = InstantiateClassGenerator.Execute<ListMilestonesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMilestones(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMilestones(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WellArchitected")]
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
        [TestCategory("WellArchitected")]
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


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WellArchitected")]
        public void ListShareInvitationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListShareInvitationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListShareInvitationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListShareInvitationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListShareInvitations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListShareInvitations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WellArchitected")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListShareInvitationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListShareInvitationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListShareInvitationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListShareInvitations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListShareInvitations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WellArchitected")]
        public void ListWorkloadsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkloadsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWorkloadsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWorkloadsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWorkloads(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWorkloads(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WellArchitected")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWorkloadsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkloadsRequest>();

            var response = InstantiateClassGenerator.Execute<ListWorkloadsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWorkloads(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWorkloads(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WellArchitected")]
        public void ListWorkloadSharesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkloadSharesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWorkloadSharesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWorkloadSharesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWorkloadShares(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWorkloadShares(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WellArchitected")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWorkloadSharesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkloadSharesRequest>();

            var response = InstantiateClassGenerator.Execute<ListWorkloadSharesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWorkloadShares(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWorkloadShares(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif