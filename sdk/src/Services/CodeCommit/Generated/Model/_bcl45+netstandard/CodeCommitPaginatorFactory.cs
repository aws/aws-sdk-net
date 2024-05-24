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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Paginators for the CodeCommit service
    ///</summary>
    public class CodeCommitPaginatorFactory : ICodeCommitPaginatorFactory
    {
        private readonly IAmazonCodeCommit client;

        internal CodeCommitPaginatorFactory(IAmazonCodeCommit client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeMergeConflicts operation
        ///</summary>
        public IDescribeMergeConflictsPaginator DescribeMergeConflicts(DescribeMergeConflictsRequest request) 
        {
            return new DescribeMergeConflictsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribePullRequestEvents operation
        ///</summary>
        public IDescribePullRequestEventsPaginator DescribePullRequestEvents(DescribePullRequestEventsRequest request) 
        {
            return new DescribePullRequestEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetCommentReactions operation
        ///</summary>
        public IGetCommentReactionsPaginator GetCommentReactions(GetCommentReactionsRequest request) 
        {
            return new GetCommentReactionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetCommentsForComparedCommit operation
        ///</summary>
        public IGetCommentsForComparedCommitPaginator GetCommentsForComparedCommit(GetCommentsForComparedCommitRequest request) 
        {
            return new GetCommentsForComparedCommitPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetCommentsForPullRequest operation
        ///</summary>
        public IGetCommentsForPullRequestPaginator GetCommentsForPullRequest(GetCommentsForPullRequestRequest request) 
        {
            return new GetCommentsForPullRequestPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetDifferences operation
        ///</summary>
        public IGetDifferencesPaginator GetDifferences(GetDifferencesRequest request) 
        {
            return new GetDifferencesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for GetMergeConflicts operation
        ///</summary>
        public IGetMergeConflictsPaginator GetMergeConflicts(GetMergeConflictsRequest request) 
        {
            return new GetMergeConflictsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListApprovalRuleTemplates operation
        ///</summary>
        public IListApprovalRuleTemplatesPaginator ListApprovalRuleTemplates(ListApprovalRuleTemplatesRequest request) 
        {
            return new ListApprovalRuleTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssociatedApprovalRuleTemplatesForRepository operation
        ///</summary>
        public IListAssociatedApprovalRuleTemplatesForRepositoryPaginator ListAssociatedApprovalRuleTemplatesForRepository(ListAssociatedApprovalRuleTemplatesForRepositoryRequest request) 
        {
            return new ListAssociatedApprovalRuleTemplatesForRepositoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBranches operation
        ///</summary>
        public IListBranchesPaginator ListBranches(ListBranchesRequest request) 
        {
            return new ListBranchesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFileCommitHistory operation
        ///</summary>
        public IListFileCommitHistoryPaginator ListFileCommitHistory(ListFileCommitHistoryRequest request) 
        {
            return new ListFileCommitHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPullRequests operation
        ///</summary>
        public IListPullRequestsPaginator ListPullRequests(ListPullRequestsRequest request) 
        {
            return new ListPullRequestsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRepositories operation
        ///</summary>
        public IListRepositoriesPaginator ListRepositories(ListRepositoriesRequest request) 
        {
            return new ListRepositoriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRepositoriesForApprovalRuleTemplate operation
        ///</summary>
        public IListRepositoriesForApprovalRuleTemplatePaginator ListRepositoriesForApprovalRuleTemplate(ListRepositoriesForApprovalRuleTemplateRequest request) 
        {
            return new ListRepositoriesForApprovalRuleTemplatePaginator(this.client, request);
        }
    }
}