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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Paginators for the MTurk service
    ///</summary>
    public class MTurkPaginatorFactory : IMTurkPaginatorFactory
    {
        private readonly IAmazonMTurk client;

        internal MTurkPaginatorFactory(IAmazonMTurk client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAssignmentsForHIT operation
        ///</summary>
        public IListAssignmentsForHITPaginator ListAssignmentsForHIT(ListAssignmentsForHITRequest request) 
        {
            return new ListAssignmentsForHITPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBonusPayments operation
        ///</summary>
        public IListBonusPaymentsPaginator ListBonusPayments(ListBonusPaymentsRequest request) 
        {
            return new ListBonusPaymentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListHITs operation
        ///</summary>
        public IListHITsPaginator ListHITs(ListHITsRequest request) 
        {
            return new ListHITsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListHITsForQualificationType operation
        ///</summary>
        public IListHITsForQualificationTypePaginator ListHITsForQualificationType(ListHITsForQualificationTypeRequest request) 
        {
            return new ListHITsForQualificationTypePaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQualificationRequests operation
        ///</summary>
        public IListQualificationRequestsPaginator ListQualificationRequests(ListQualificationRequestsRequest request) 
        {
            return new ListQualificationRequestsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQualificationTypes operation
        ///</summary>
        public IListQualificationTypesPaginator ListQualificationTypes(ListQualificationTypesRequest request) 
        {
            return new ListQualificationTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReviewableHITs operation
        ///</summary>
        public IListReviewableHITsPaginator ListReviewableHITs(ListReviewableHITsRequest request) 
        {
            return new ListReviewableHITsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListReviewPolicyResultsForHIT operation
        ///</summary>
        public IListReviewPolicyResultsForHITPaginator ListReviewPolicyResultsForHIT(ListReviewPolicyResultsForHITRequest request) 
        {
            return new ListReviewPolicyResultsForHITPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkerBlocks operation
        ///</summary>
        public IListWorkerBlocksPaginator ListWorkerBlocks(ListWorkerBlocksRequest request) 
        {
            return new ListWorkerBlocksPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkersWithQualificationType operation
        ///</summary>
        public IListWorkersWithQualificationTypePaginator ListWorkersWithQualificationType(ListWorkersWithQualificationTypeRequest request) 
        {
            return new ListWorkersWithQualificationTypePaginator(this.client, request);
        }
    }
}