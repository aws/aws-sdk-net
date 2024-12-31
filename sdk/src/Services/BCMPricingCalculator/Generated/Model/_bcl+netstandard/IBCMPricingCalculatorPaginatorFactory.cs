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
        IListBillEstimateCommitmentsPaginator ListBillEstimateCommitments(ListBillEstimateCommitmentsRequest request);

        /// <summary>
        /// Paginator for ListBillEstimateInputCommitmentModifications operation
        ///</summary>
        IListBillEstimateInputCommitmentModificationsPaginator ListBillEstimateInputCommitmentModifications(ListBillEstimateInputCommitmentModificationsRequest request);

        /// <summary>
        /// Paginator for ListBillEstimateInputUsageModifications operation
        ///</summary>
        IListBillEstimateInputUsageModificationsPaginator ListBillEstimateInputUsageModifications(ListBillEstimateInputUsageModificationsRequest request);

        /// <summary>
        /// Paginator for ListBillEstimateLineItems operation
        ///</summary>
        IListBillEstimateLineItemsPaginator ListBillEstimateLineItems(ListBillEstimateLineItemsRequest request);

        /// <summary>
        /// Paginator for ListBillEstimates operation
        ///</summary>
        IListBillEstimatesPaginator ListBillEstimates(ListBillEstimatesRequest request);

        /// <summary>
        /// Paginator for ListBillScenarioCommitmentModifications operation
        ///</summary>
        IListBillScenarioCommitmentModificationsPaginator ListBillScenarioCommitmentModifications(ListBillScenarioCommitmentModificationsRequest request);

        /// <summary>
        /// Paginator for ListBillScenarios operation
        ///</summary>
        IListBillScenariosPaginator ListBillScenarios(ListBillScenariosRequest request);

        /// <summary>
        /// Paginator for ListBillScenarioUsageModifications operation
        ///</summary>
        IListBillScenarioUsageModificationsPaginator ListBillScenarioUsageModifications(ListBillScenarioUsageModificationsRequest request);

        /// <summary>
        /// Paginator for ListWorkloadEstimates operation
        ///</summary>
        IListWorkloadEstimatesPaginator ListWorkloadEstimates(ListWorkloadEstimatesRequest request);

        /// <summary>
        /// Paginator for ListWorkloadEstimateUsage operation
        ///</summary>
        IListWorkloadEstimateUsagePaginator ListWorkloadEstimateUsage(ListWorkloadEstimateUsageRequest request);
    }
}