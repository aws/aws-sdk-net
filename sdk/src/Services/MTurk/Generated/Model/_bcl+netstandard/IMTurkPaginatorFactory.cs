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

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Paginators for the MTurk service
    ///</summary>
    public interface IMTurkPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAssignmentsForHIT operation
        ///</summary>
        IListAssignmentsForHITPaginator ListAssignmentsForHIT(ListAssignmentsForHITRequest request);

        /// <summary>
        /// Paginator for ListBonusPayments operation
        ///</summary>
        IListBonusPaymentsPaginator ListBonusPayments(ListBonusPaymentsRequest request);

        /// <summary>
        /// Paginator for ListHITs operation
        ///</summary>
        IListHITsPaginator ListHITs(ListHITsRequest request);

        /// <summary>
        /// Paginator for ListHITsForQualificationType operation
        ///</summary>
        IListHITsForQualificationTypePaginator ListHITsForQualificationType(ListHITsForQualificationTypeRequest request);

        /// <summary>
        /// Paginator for ListQualificationRequests operation
        ///</summary>
        IListQualificationRequestsPaginator ListQualificationRequests(ListQualificationRequestsRequest request);

        /// <summary>
        /// Paginator for ListQualificationTypes operation
        ///</summary>
        IListQualificationTypesPaginator ListQualificationTypes(ListQualificationTypesRequest request);

        /// <summary>
        /// Paginator for ListReviewableHITs operation
        ///</summary>
        IListReviewableHITsPaginator ListReviewableHITs(ListReviewableHITsRequest request);

        /// <summary>
        /// Paginator for ListReviewPolicyResultsForHIT operation
        ///</summary>
        IListReviewPolicyResultsForHITPaginator ListReviewPolicyResultsForHIT(ListReviewPolicyResultsForHITRequest request);

        /// <summary>
        /// Paginator for ListWorkerBlocks operation
        ///</summary>
        IListWorkerBlocksPaginator ListWorkerBlocks(ListWorkerBlocksRequest request);

        /// <summary>
        /// Paginator for ListWorkersWithQualificationType operation
        ///</summary>
        IListWorkersWithQualificationTypePaginator ListWorkersWithQualificationType(ListWorkersWithQualificationTypeRequest request);
    }
}