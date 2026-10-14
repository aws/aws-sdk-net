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

namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Paginators for the ComputeOptimizerAutomation service
    /// </summary>
    public interface IComputeOptimizerAutomationPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAccounts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAccountsPaginator ListAccounts(ListAccountsRequest request);

        /// <summary>
        /// Paginator for ListAutomationEventSteps operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAutomationEventStepsPaginator ListAutomationEventSteps(ListAutomationEventStepsRequest request);

        /// <summary>
        /// Paginator for ListAutomationEventSummaries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAutomationEventSummariesPaginator ListAutomationEventSummaries(ListAutomationEventSummariesRequest request);

        /// <summary>
        /// Paginator for ListAutomationEvents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAutomationEventsPaginator ListAutomationEvents(ListAutomationEventsRequest request);

        /// <summary>
        /// Paginator for ListAutomationRulePreview operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAutomationRulePreviewPaginator ListAutomationRulePreview(ListAutomationRulePreviewRequest request);

        /// <summary>
        /// Paginator for ListAutomationRulePreviewSummaries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAutomationRulePreviewSummariesPaginator ListAutomationRulePreviewSummaries(ListAutomationRulePreviewSummariesRequest request);

        /// <summary>
        /// Paginator for ListAutomationRules operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAutomationRulesPaginator ListAutomationRules(ListAutomationRulesRequest request);

        /// <summary>
        /// Paginator for ListRecommendedActionSummaries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRecommendedActionSummariesPaginator ListRecommendedActionSummaries(ListRecommendedActionSummariesRequest request);

        /// <summary>
        /// Paginator for ListRecommendedActions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRecommendedActionsPaginator ListRecommendedActions(ListRecommendedActionsRequest request);
    }
}
