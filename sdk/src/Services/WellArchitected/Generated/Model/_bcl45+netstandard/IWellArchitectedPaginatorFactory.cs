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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Paginators for the WellArchitected service
    ///</summary>
    public interface IWellArchitectedPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetConsolidatedReport operation
        ///</summary>
        IGetConsolidatedReportPaginator GetConsolidatedReport(GetConsolidatedReportRequest request);

        /// <summary>
        /// Paginator for ListAnswers operation
        ///</summary>
        IListAnswersPaginator ListAnswers(ListAnswersRequest request);

        /// <summary>
        /// Paginator for ListCheckDetails operation
        ///</summary>
        IListCheckDetailsPaginator ListCheckDetails(ListCheckDetailsRequest request);

        /// <summary>
        /// Paginator for ListCheckSummaries operation
        ///</summary>
        IListCheckSummariesPaginator ListCheckSummaries(ListCheckSummariesRequest request);

        /// <summary>
        /// Paginator for ListLenses operation
        ///</summary>
        IListLensesPaginator ListLenses(ListLensesRequest request);

        /// <summary>
        /// Paginator for ListLensReviewImprovements operation
        ///</summary>
        IListLensReviewImprovementsPaginator ListLensReviewImprovements(ListLensReviewImprovementsRequest request);

        /// <summary>
        /// Paginator for ListLensReviews operation
        ///</summary>
        IListLensReviewsPaginator ListLensReviews(ListLensReviewsRequest request);

        /// <summary>
        /// Paginator for ListLensShares operation
        ///</summary>
        IListLensSharesPaginator ListLensShares(ListLensSharesRequest request);

        /// <summary>
        /// Paginator for ListMilestones operation
        ///</summary>
        IListMilestonesPaginator ListMilestones(ListMilestonesRequest request);

        /// <summary>
        /// Paginator for ListNotifications operation
        ///</summary>
        IListNotificationsPaginator ListNotifications(ListNotificationsRequest request);

        /// <summary>
        /// Paginator for ListShareInvitations operation
        ///</summary>
        IListShareInvitationsPaginator ListShareInvitations(ListShareInvitationsRequest request);

        /// <summary>
        /// Paginator for ListWorkloads operation
        ///</summary>
        IListWorkloadsPaginator ListWorkloads(ListWorkloadsRequest request);

        /// <summary>
        /// Paginator for ListWorkloadShares operation
        ///</summary>
        IListWorkloadSharesPaginator ListWorkloadShares(ListWorkloadSharesRequest request);
    }
}