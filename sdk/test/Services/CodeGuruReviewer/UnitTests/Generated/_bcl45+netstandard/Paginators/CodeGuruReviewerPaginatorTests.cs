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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */

using Amazon.CodeGuruReviewer;
using Amazon.CodeGuruReviewer.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CodeGuruReviewerPaginatorTests
    {
        private static Mock<AmazonCodeGuruReviewerClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCodeGuruReviewerClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeGuruReviewer")]
        public void ListCodeReviewsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCodeReviewsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCodeReviewsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCodeReviewsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCodeReviews(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCodeReviews(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeGuruReviewer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCodeReviewsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCodeReviewsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCodeReviewsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCodeReviews(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCodeReviews(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeGuruReviewer")]
        public void ListRecommendationFeedbackTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRecommendationFeedbackRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRecommendationFeedbackResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRecommendationFeedbackResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRecommendationFeedback(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRecommendationFeedback(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeGuruReviewer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRecommendationFeedbackTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRecommendationFeedbackRequest>();

            var response = InstantiateClassGenerator.Execute<ListRecommendationFeedbackResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRecommendationFeedback(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRecommendationFeedback(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeGuruReviewer")]
        public void ListRecommendationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRecommendationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRecommendationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRecommendationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRecommendations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRecommendations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeGuruReviewer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRecommendationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRecommendationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRecommendationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRecommendations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRecommendations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeGuruReviewer")]
        public void ListRepositoryAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRepositoryAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRepositoryAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRepositoryAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRepositoryAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRepositoryAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeGuruReviewer")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRepositoryAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRepositoryAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRepositoryAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRepositoryAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRepositoryAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif