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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Paginators for the ComputeOptimizerAutomation service
    ///</summary>
    public class ComputeOptimizerAutomationPaginatorFactory : IComputeOptimizerAutomationPaginatorFactory
    {
        private readonly IAmazonComputeOptimizerAutomation client;

        internal ComputeOptimizerAutomationPaginatorFactory(IAmazonComputeOptimizerAutomation client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAccounts operation
        ///</summary>
        public IListAccountsPaginator ListAccounts(ListAccountsRequest request) 
        {
            return new ListAccountsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAutomationEvents operation
        ///</summary>
        public IListAutomationEventsPaginator ListAutomationEvents(ListAutomationEventsRequest request) 
        {
            return new ListAutomationEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAutomationEventSteps operation
        ///</summary>
        public IListAutomationEventStepsPaginator ListAutomationEventSteps(ListAutomationEventStepsRequest request) 
        {
            return new ListAutomationEventStepsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAutomationEventSummaries operation
        ///</summary>
        public IListAutomationEventSummariesPaginator ListAutomationEventSummaries(ListAutomationEventSummariesRequest request) 
        {
            return new ListAutomationEventSummariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAutomationRulePreview operation
        ///</summary>
        public IListAutomationRulePreviewPaginator ListAutomationRulePreview(ListAutomationRulePreviewRequest request) 
        {
            return new ListAutomationRulePreviewPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAutomationRulePreviewSummaries operation
        ///</summary>
        public IListAutomationRulePreviewSummariesPaginator ListAutomationRulePreviewSummaries(ListAutomationRulePreviewSummariesRequest request) 
        {
            return new ListAutomationRulePreviewSummariesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAutomationRules operation
        ///</summary>
        public IListAutomationRulesPaginator ListAutomationRules(ListAutomationRulesRequest request) 
        {
            return new ListAutomationRulesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecommendedActions operation
        ///</summary>
        public IListRecommendedActionsPaginator ListRecommendedActions(ListRecommendedActionsRequest request) 
        {
            return new ListRecommendedActionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListRecommendedActionSummaries operation
        ///</summary>
        public IListRecommendedActionSummariesPaginator ListRecommendedActionSummaries(ListRecommendedActionSummariesRequest request) 
        {
            return new ListRecommendedActionSummariesPaginator(this.client, request);
        }
    }
}