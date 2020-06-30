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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */

using Amazon.CodeCommit;
using Amazon.CodeCommit.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CodeCommitPaginatorTests
    {
        private static Mock<AmazonCodeCommitClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCodeCommitClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        public void DescribeMergeConflictsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMergeConflictsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeMergeConflictsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeMergeConflictsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeMergeConflicts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeMergeConflicts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeMergeConflictsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMergeConflictsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeMergeConflictsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeMergeConflicts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeMergeConflicts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        public void DescribePullRequestEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribePullRequestEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribePullRequestEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribePullRequestEventsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribePullRequestEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribePullRequestEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribePullRequestEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribePullRequestEventsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribePullRequestEventsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribePullRequestEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribePullRequestEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        public void GetCommentReactionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetCommentReactionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetCommentReactionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetCommentReactionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetCommentReactions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetCommentReactions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetCommentReactionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetCommentReactionsRequest>();

            var response = InstantiateClassGenerator.Execute<GetCommentReactionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetCommentReactions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetCommentReactions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        public void GetCommentsForComparedCommitTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetCommentsForComparedCommitRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetCommentsForComparedCommitResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetCommentsForComparedCommitResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetCommentsForComparedCommit(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetCommentsForComparedCommit(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetCommentsForComparedCommitTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetCommentsForComparedCommitRequest>();

            var response = InstantiateClassGenerator.Execute<GetCommentsForComparedCommitResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetCommentsForComparedCommit(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetCommentsForComparedCommit(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        public void GetCommentsForPullRequestTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetCommentsForPullRequestRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetCommentsForPullRequestResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetCommentsForPullRequestResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetCommentsForPullRequest(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetCommentsForPullRequest(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetCommentsForPullRequestTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetCommentsForPullRequestRequest>();

            var response = InstantiateClassGenerator.Execute<GetCommentsForPullRequestResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetCommentsForPullRequest(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetCommentsForPullRequest(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        public void GetDifferencesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetDifferencesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetDifferencesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetDifferencesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetDifferences(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetDifferences(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetDifferencesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetDifferencesRequest>();

            var response = InstantiateClassGenerator.Execute<GetDifferencesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetDifferences(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetDifferences(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        public void GetMergeConflictsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetMergeConflictsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetMergeConflictsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetMergeConflictsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetMergeConflicts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetMergeConflicts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetMergeConflictsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetMergeConflictsRequest>();

            var response = InstantiateClassGenerator.Execute<GetMergeConflictsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetMergeConflicts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetMergeConflicts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        public void ListApprovalRuleTemplatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListApprovalRuleTemplatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListApprovalRuleTemplatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListApprovalRuleTemplatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListApprovalRuleTemplates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListApprovalRuleTemplates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListApprovalRuleTemplatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListApprovalRuleTemplatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListApprovalRuleTemplatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListApprovalRuleTemplates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListApprovalRuleTemplates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        public void ListAssociatedApprovalRuleTemplatesForRepositoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssociatedApprovalRuleTemplatesForRepositoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssociatedApprovalRuleTemplatesForRepositoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssociatedApprovalRuleTemplatesForRepositoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssociatedApprovalRuleTemplatesForRepository(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssociatedApprovalRuleTemplatesForRepository(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssociatedApprovalRuleTemplatesForRepositoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssociatedApprovalRuleTemplatesForRepositoryRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssociatedApprovalRuleTemplatesForRepositoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssociatedApprovalRuleTemplatesForRepository(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssociatedApprovalRuleTemplatesForRepository(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        public void ListBranchesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBranchesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBranchesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBranchesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBranches(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBranches(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBranchesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBranchesRequest>();

            var response = InstantiateClassGenerator.Execute<ListBranchesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBranches(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBranches(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        public void ListPullRequestsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPullRequestsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPullRequestsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPullRequestsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPullRequests(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPullRequests(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPullRequestsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPullRequestsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPullRequestsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPullRequests(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPullRequests(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        public void ListRepositoriesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRepositoriesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRepositoriesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRepositoriesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRepositories(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRepositories(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRepositoriesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRepositoriesRequest>();

            var response = InstantiateClassGenerator.Execute<ListRepositoriesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRepositories(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRepositories(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        public void ListRepositoriesForApprovalRuleTemplateTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRepositoriesForApprovalRuleTemplateRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRepositoriesForApprovalRuleTemplateResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRepositoriesForApprovalRuleTemplateResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRepositoriesForApprovalRuleTemplate(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRepositoriesForApprovalRuleTemplate(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeCommit")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRepositoriesForApprovalRuleTemplateTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRepositoriesForApprovalRuleTemplateRequest>();

            var response = InstantiateClassGenerator.Execute<ListRepositoriesForApprovalRuleTemplateResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRepositoriesForApprovalRuleTemplate(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRepositoriesForApprovalRuleTemplate(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif