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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.Billing.Model
{
    /// <summary>
    /// Paginators for the Billing service
    /// </summary>
    public interface IBillingPaginatorFactory
    {
        /// <summary>
        /// Paginator for GetCreditAllocationHistory operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IGetCreditAllocationHistoryPaginator GetCreditAllocationHistory(GetCreditAllocationHistoryRequest request);

        /// <summary>
        /// Paginator for ListBillingViewSegments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBillingViewSegmentsPaginator ListBillingViewSegments(ListBillingViewSegmentsRequest request);

        /// <summary>
        /// Paginator for ListBillingViews operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBillingViewsPaginator ListBillingViews(ListBillingViewsRequest request);

        /// <summary>
        /// Paginator for ListBusinessSupportAccountCharges operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBusinessSupportAccountChargesPaginator ListBusinessSupportAccountCharges(ListBusinessSupportAccountChargesRequest request);

        /// <summary>
        /// Paginator for ListBusinessSupportSubscriptionHistory operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListBusinessSupportSubscriptionHistoryPaginator ListBusinessSupportSubscriptionHistory(ListBusinessSupportSubscriptionHistoryRequest request);

        /// <summary>
        /// Paginator for ListContracts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListContractsPaginator ListContracts(ListContractsRequest request);

        /// <summary>
        /// Paginator for ListContractualInvestmentAttestations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListContractualInvestmentAttestationsPaginator ListContractualInvestmentAttestations(ListContractualInvestmentAttestationsRequest request);

        /// <summary>
        /// Paginator for ListContractualInvestmentSummaries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListContractualInvestmentSummariesPaginator ListContractualInvestmentSummaries(ListContractualInvestmentSummariesRequest request);

        /// <summary>
        /// Paginator for ListContractualInvestments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListContractualInvestmentsPaginator ListContractualInvestments(ListContractualInvestmentsRequest request);

        /// <summary>
        /// Paginator for ListEnterpriseSupportLinkedAccountCharges operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListEnterpriseSupportLinkedAccountChargesPaginator ListEnterpriseSupportLinkedAccountCharges(ListEnterpriseSupportLinkedAccountChargesRequest request);

        /// <summary>
        /// Paginator for ListSourceViewsForBillingView operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSourceViewsForBillingViewPaginator ListSourceViewsForBillingView(ListSourceViewsForBillingViewRequest request);
    }
}
