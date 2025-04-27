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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Paginators for the BCMPricingCalculator service
    ///</summary>
    public interface IBCMPricingCalculatorPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListBillEstimateCommitments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBillEstimateCommitmentsPaginator ListBillEstimateCommitments(ListBillEstimateCommitmentsRequest request);

        /// <summary>
        /// Paginator for ListBillEstimateInputCommitmentModifications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBillEstimateInputCommitmentModificationsPaginator ListBillEstimateInputCommitmentModifications(ListBillEstimateInputCommitmentModificationsRequest request);

        /// <summary>
        /// Paginator for ListBillEstimateInputUsageModifications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBillEstimateInputUsageModificationsPaginator ListBillEstimateInputUsageModifications(ListBillEstimateInputUsageModificationsRequest request);

        /// <summary>
        /// Paginator for ListBillEstimateLineItems operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBillEstimateLineItemsPaginator ListBillEstimateLineItems(ListBillEstimateLineItemsRequest request);

        /// <summary>
        /// Paginator for ListBillEstimates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBillEstimatesPaginator ListBillEstimates(ListBillEstimatesRequest request);

        /// <summary>
        /// Paginator for ListBillScenarioCommitmentModifications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBillScenarioCommitmentModificationsPaginator ListBillScenarioCommitmentModifications(ListBillScenarioCommitmentModificationsRequest request);

        /// <summary>
        /// Paginator for ListBillScenarios operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBillScenariosPaginator ListBillScenarios(ListBillScenariosRequest request);

        /// <summary>
        /// Paginator for ListBillScenarioUsageModifications operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListBillScenarioUsageModificationsPaginator ListBillScenarioUsageModifications(ListBillScenarioUsageModificationsRequest request);

        /// <summary>
        /// Paginator for ListWorkloadEstimates operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkloadEstimatesPaginator ListWorkloadEstimates(ListWorkloadEstimatesRequest request);

        /// <summary>
        /// Paginator for ListWorkloadEstimateUsage operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListWorkloadEstimateUsagePaginator ListWorkloadEstimateUsage(ListWorkloadEstimateUsageRequest request);
    }
}