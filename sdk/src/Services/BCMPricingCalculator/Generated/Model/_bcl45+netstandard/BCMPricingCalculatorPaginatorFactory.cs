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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Paginators for the BCMPricingCalculator service
    ///</summary>
    public class BCMPricingCalculatorPaginatorFactory : IBCMPricingCalculatorPaginatorFactory
    {
        private readonly IAmazonBCMPricingCalculator client;

        internal BCMPricingCalculatorPaginatorFactory(IAmazonBCMPricingCalculator client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListBillEstimateCommitments operation
        ///</summary>
        public IListBillEstimateCommitmentsPaginator ListBillEstimateCommitments(ListBillEstimateCommitmentsRequest request) 
        {
            return new ListBillEstimateCommitmentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBillEstimateInputCommitmentModifications operation
        ///</summary>
        public IListBillEstimateInputCommitmentModificationsPaginator ListBillEstimateInputCommitmentModifications(ListBillEstimateInputCommitmentModificationsRequest request) 
        {
            return new ListBillEstimateInputCommitmentModificationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBillEstimateInputUsageModifications operation
        ///</summary>
        public IListBillEstimateInputUsageModificationsPaginator ListBillEstimateInputUsageModifications(ListBillEstimateInputUsageModificationsRequest request) 
        {
            return new ListBillEstimateInputUsageModificationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBillEstimateLineItems operation
        ///</summary>
        public IListBillEstimateLineItemsPaginator ListBillEstimateLineItems(ListBillEstimateLineItemsRequest request) 
        {
            return new ListBillEstimateLineItemsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBillEstimates operation
        ///</summary>
        public IListBillEstimatesPaginator ListBillEstimates(ListBillEstimatesRequest request) 
        {
            return new ListBillEstimatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBillScenarioCommitmentModifications operation
        ///</summary>
        public IListBillScenarioCommitmentModificationsPaginator ListBillScenarioCommitmentModifications(ListBillScenarioCommitmentModificationsRequest request) 
        {
            return new ListBillScenarioCommitmentModificationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBillScenarios operation
        ///</summary>
        public IListBillScenariosPaginator ListBillScenarios(ListBillScenariosRequest request) 
        {
            return new ListBillScenariosPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListBillScenarioUsageModifications operation
        ///</summary>
        public IListBillScenarioUsageModificationsPaginator ListBillScenarioUsageModifications(ListBillScenarioUsageModificationsRequest request) 
        {
            return new ListBillScenarioUsageModificationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkloadEstimates operation
        ///</summary>
        public IListWorkloadEstimatesPaginator ListWorkloadEstimates(ListWorkloadEstimatesRequest request) 
        {
            return new ListWorkloadEstimatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkloadEstimateUsage operation
        ///</summary>
        public IListWorkloadEstimateUsagePaginator ListWorkloadEstimateUsage(ListWorkloadEstimateUsageRequest request) 
        {
            return new ListWorkloadEstimateUsagePaginator(this.client, request);
        }
    }
}