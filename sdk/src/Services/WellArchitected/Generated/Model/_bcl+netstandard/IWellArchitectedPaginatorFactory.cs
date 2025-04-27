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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetConsolidatedReportPaginator GetConsolidatedReport(GetConsolidatedReportRequest request);

        /// <summary>
        /// Paginator for ListAnswers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAnswersPaginator ListAnswers(ListAnswersRequest request);

        /// <summary>
        /// Paginator for ListCheckDetails operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCheckDetailsPaginator ListCheckDetails(ListCheckDetailsRequest request);

        /// <summary>
        /// Paginator for ListCheckSummaries operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListCheckSummariesPaginator ListCheckSummaries(ListCheckSummariesRequest request);

        /// <summary>
        /// Paginator for ListLenses operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLensesPaginator ListLenses(ListLensesRequest request);

        /// <summary>
        /// Paginator for ListLensReviewImprovements operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLensReviewImprovementsPaginator ListLensReviewImprovements(ListLensReviewImprovementsRequest request);

        /// <summary>
        /// Paginator for ListLensReviews operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLensReviewsPaginator ListLensReviews(ListLensReviewsRequest request);

        /// <summary>
        /// Paginator for ListLensShares operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListLensSharesPaginator ListLensShares(ListLensSharesRequest request);

        /// <summary>
        /// Paginator for ListMilestones operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMilestonesPaginator ListMilestones(ListMilestonesRequest request);

        /// <summary>
        /// Paginator for ListNotifications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNotificationsPaginator ListNotifications(ListNotificationsRequest request);

        /// <summary>
        /// Paginator for ListProfileNotifications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProfileNotificationsPaginator ListProfileNotifications(ListProfileNotificationsRequest request);

        /// <summary>
        /// Paginator for ListProfiles operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProfilesPaginator ListProfiles(ListProfilesRequest request);

        /// <summary>
        /// Paginator for ListProfileShares operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProfileSharesPaginator ListProfileShares(ListProfileSharesRequest request);

        /// <summary>
        /// Paginator for ListReviewTemplateAnswers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReviewTemplateAnswersPaginator ListReviewTemplateAnswers(ListReviewTemplateAnswersRequest request);

        /// <summary>
        /// Paginator for ListReviewTemplates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReviewTemplatesPaginator ListReviewTemplates(ListReviewTemplatesRequest request);

        /// <summary>
        /// Paginator for ListShareInvitations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListShareInvitationsPaginator ListShareInvitations(ListShareInvitationsRequest request);

        /// <summary>
        /// Paginator for ListTemplateShares operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTemplateSharesPaginator ListTemplateShares(ListTemplateSharesRequest request);

        /// <summary>
        /// Paginator for ListWorkloads operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkloadsPaginator ListWorkloads(ListWorkloadsRequest request);

        /// <summary>
        /// Paginator for ListWorkloadShares operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkloadSharesPaginator ListWorkloadShares(ListWorkloadSharesRequest request);
    }
}