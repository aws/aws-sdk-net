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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Paginators for the CodeCommit service
    ///</summary>
    public interface ICodeCommitPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeMergeConflicts operation
        ///</summary>
        IDescribeMergeConflictsPaginator DescribeMergeConflicts(DescribeMergeConflictsRequest request);

        /// <summary>
        /// Paginator for DescribePullRequestEvents operation
        ///</summary>
        IDescribePullRequestEventsPaginator DescribePullRequestEvents(DescribePullRequestEventsRequest request);

        /// <summary>
        /// Paginator for GetCommentReactions operation
        ///</summary>
        IGetCommentReactionsPaginator GetCommentReactions(GetCommentReactionsRequest request);

        /// <summary>
        /// Paginator for GetCommentsForComparedCommit operation
        ///</summary>
        IGetCommentsForComparedCommitPaginator GetCommentsForComparedCommit(GetCommentsForComparedCommitRequest request);

        /// <summary>
        /// Paginator for GetCommentsForPullRequest operation
        ///</summary>
        IGetCommentsForPullRequestPaginator GetCommentsForPullRequest(GetCommentsForPullRequestRequest request);

        /// <summary>
        /// Paginator for GetDifferences operation
        ///</summary>
        IGetDifferencesPaginator GetDifferences(GetDifferencesRequest request);

        /// <summary>
        /// Paginator for GetMergeConflicts operation
        ///</summary>
        IGetMergeConflictsPaginator GetMergeConflicts(GetMergeConflictsRequest request);

        /// <summary>
        /// Paginator for ListApprovalRuleTemplates operation
        ///</summary>
        IListApprovalRuleTemplatesPaginator ListApprovalRuleTemplates(ListApprovalRuleTemplatesRequest request);

        /// <summary>
        /// Paginator for ListAssociatedApprovalRuleTemplatesForRepository operation
        ///</summary>
        IListAssociatedApprovalRuleTemplatesForRepositoryPaginator ListAssociatedApprovalRuleTemplatesForRepository(ListAssociatedApprovalRuleTemplatesForRepositoryRequest request);

        /// <summary>
        /// Paginator for ListBranches operation
        ///</summary>
        IListBranchesPaginator ListBranches(ListBranchesRequest request);

        /// <summary>
        /// Paginator for ListPullRequests operation
        ///</summary>
        IListPullRequestsPaginator ListPullRequests(ListPullRequestsRequest request);

        /// <summary>
        /// Paginator for ListRepositories operation
        ///</summary>
        IListRepositoriesPaginator ListRepositories(ListRepositoriesRequest request);

        /// <summary>
        /// Paginator for ListRepositoriesForApprovalRuleTemplate operation
        ///</summary>
        IListRepositoriesForApprovalRuleTemplatePaginator ListRepositoriesForApprovalRuleTemplate(ListRepositoriesForApprovalRuleTemplateRequest request);
    }
}