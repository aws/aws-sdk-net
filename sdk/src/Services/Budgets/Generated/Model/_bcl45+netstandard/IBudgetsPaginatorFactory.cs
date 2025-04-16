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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.Budgets.Model
{
    /// <summary>
    /// Paginators for the Budgets service
    ///</summary>
    public interface IBudgetsPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeBudgetActionHistories operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeBudgetActionHistoriesPaginator DescribeBudgetActionHistories(DescribeBudgetActionHistoriesRequest request);

        /// <summary>
        /// Paginator for DescribeBudgetActionsForAccount operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeBudgetActionsForAccountPaginator DescribeBudgetActionsForAccount(DescribeBudgetActionsForAccountRequest request);

        /// <summary>
        /// Paginator for DescribeBudgetActionsForBudget operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeBudgetActionsForBudgetPaginator DescribeBudgetActionsForBudget(DescribeBudgetActionsForBudgetRequest request);

        /// <summary>
        /// Paginator for DescribeBudgetNotificationsForAccount operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeBudgetNotificationsForAccountPaginator DescribeBudgetNotificationsForAccount(DescribeBudgetNotificationsForAccountRequest request);

        /// <summary>
        /// Paginator for DescribeBudgetPerformanceHistory operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeBudgetPerformanceHistoryPaginator DescribeBudgetPerformanceHistory(DescribeBudgetPerformanceHistoryRequest request);

        /// <summary>
        /// Paginator for DescribeBudgets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeBudgetsPaginator DescribeBudgets(DescribeBudgetsRequest request);

        /// <summary>
        /// Paginator for DescribeNotificationsForBudget operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeNotificationsForBudgetPaginator DescribeNotificationsForBudget(DescribeNotificationsForBudgetRequest request);

        /// <summary>
        /// Paginator for DescribeSubscribersForNotification operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSubscribersForNotificationPaginator DescribeSubscribersForNotification(DescribeSubscribersForNotificationRequest request);
    }
}