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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Paginators for the WellArchitected service
    ///</summary>
    public class WellArchitectedPaginatorFactory : IWellArchitectedPaginatorFactory
    {
        private readonly IAmazonWellArchitected client;

        internal WellArchitectedPaginatorFactory(IAmazonWellArchitected client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetConsolidatedReport operation
        ///</summary>
        public IGetConsolidatedReportPaginator GetConsolidatedReport(GetConsolidatedReportRequest request) 
        {
            return new GetConsolidatedReportPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAnswers operation
        ///</summary>
        public IListAnswersPaginator ListAnswers(ListAnswersRequest request) 
        {
            return new ListAnswersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCheckDetails operation
        ///</summary>
        public IListCheckDetailsPaginator ListCheckDetails(ListCheckDetailsRequest request) 
        {
            return new ListCheckDetailsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListCheckSummaries operation
        ///</summary>
        public IListCheckSummariesPaginator ListCheckSummaries(ListCheckSummariesRequest request) 
        {
            return new ListCheckSummariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLenses operation
        ///</summary>
        public IListLensesPaginator ListLenses(ListLensesRequest request) 
        {
            return new ListLensesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLensReviewImprovements operation
        ///</summary>
        public IListLensReviewImprovementsPaginator ListLensReviewImprovements(ListLensReviewImprovementsRequest request) 
        {
            return new ListLensReviewImprovementsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLensReviews operation
        ///</summary>
        public IListLensReviewsPaginator ListLensReviews(ListLensReviewsRequest request) 
        {
            return new ListLensReviewsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListLensShares operation
        ///</summary>
        public IListLensSharesPaginator ListLensShares(ListLensSharesRequest request) 
        {
            return new ListLensSharesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMilestones operation
        ///</summary>
        public IListMilestonesPaginator ListMilestones(ListMilestonesRequest request) 
        {
            return new ListMilestonesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListNotifications operation
        ///</summary>
        public IListNotificationsPaginator ListNotifications(ListNotificationsRequest request) 
        {
            return new ListNotificationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProfileNotifications operation
        ///</summary>
        public IListProfileNotificationsPaginator ListProfileNotifications(ListProfileNotificationsRequest request) 
        {
            return new ListProfileNotificationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProfiles operation
        ///</summary>
        public IListProfilesPaginator ListProfiles(ListProfilesRequest request) 
        {
            return new ListProfilesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListProfileShares operation
        ///</summary>
        public IListProfileSharesPaginator ListProfileShares(ListProfileSharesRequest request) 
        {
            return new ListProfileSharesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReviewTemplateAnswers operation
        ///</summary>
        public IListReviewTemplateAnswersPaginator ListReviewTemplateAnswers(ListReviewTemplateAnswersRequest request) 
        {
            return new ListReviewTemplateAnswersPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReviewTemplates operation
        ///</summary>
        public IListReviewTemplatesPaginator ListReviewTemplates(ListReviewTemplatesRequest request) 
        {
            return new ListReviewTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListShareInvitations operation
        ///</summary>
        public IListShareInvitationsPaginator ListShareInvitations(ListShareInvitationsRequest request) 
        {
            return new ListShareInvitationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListTemplateShares operation
        ///</summary>
        public IListTemplateSharesPaginator ListTemplateShares(ListTemplateSharesRequest request) 
        {
            return new ListTemplateSharesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkloads operation
        ///</summary>
        public IListWorkloadsPaginator ListWorkloads(ListWorkloadsRequest request) 
        {
            return new ListWorkloadsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkloadShares operation
        ///</summary>
        public IListWorkloadSharesPaginator ListWorkloadShares(ListWorkloadSharesRequest request) 
        {
            return new ListWorkloadSharesPaginator(this.client, request);
        }
    }
}