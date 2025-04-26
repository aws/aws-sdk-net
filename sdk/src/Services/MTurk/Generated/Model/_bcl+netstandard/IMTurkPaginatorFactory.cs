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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListAssignmentsForHITPaginator ListAssignmentsForHIT(ListAssignmentsForHITRequest request);

        /// <summary>
        /// Paginator for ListBonusPayments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBonusPaymentsPaginator ListBonusPayments(ListBonusPaymentsRequest request);

        /// <summary>
        /// Paginator for ListHITs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListHITsPaginator ListHITs(ListHITsRequest request);

        /// <summary>
        /// Paginator for ListHITsForQualificationType operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListHITsForQualificationTypePaginator ListHITsForQualificationType(ListHITsForQualificationTypeRequest request);

        /// <summary>
        /// Paginator for ListQualificationRequests operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListQualificationRequestsPaginator ListQualificationRequests(ListQualificationRequestsRequest request);

        /// <summary>
        /// Paginator for ListQualificationTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListQualificationTypesPaginator ListQualificationTypes(ListQualificationTypesRequest request);

        /// <summary>
        /// Paginator for ListReviewableHITs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReviewableHITsPaginator ListReviewableHITs(ListReviewableHITsRequest request);

        /// <summary>
        /// Paginator for ListReviewPolicyResultsForHIT operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListReviewPolicyResultsForHITPaginator ListReviewPolicyResultsForHIT(ListReviewPolicyResultsForHITRequest request);

        /// <summary>
        /// Paginator for ListWorkerBlocks operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkerBlocksPaginator ListWorkerBlocks(ListWorkerBlocksRequest request);

        /// <summary>
        /// Paginator for ListWorkersWithQualificationType operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkersWithQualificationTypePaginator ListWorkersWithQualificationType(ListWorkersWithQualificationTypeRequest request);
    }
}