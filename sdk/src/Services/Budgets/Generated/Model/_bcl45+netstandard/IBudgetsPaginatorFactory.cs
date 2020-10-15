#if !NETSTANDARD13
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
        IDescribeBudgetActionHistoriesPaginator DescribeBudgetActionHistories(DescribeBudgetActionHistoriesRequest request);

        /// <summary>
        /// Paginator for DescribeBudgetActionsForAccount operation
        ///</summary>
        IDescribeBudgetActionsForAccountPaginator DescribeBudgetActionsForAccount(DescribeBudgetActionsForAccountRequest request);

        /// <summary>
        /// Paginator for DescribeBudgetActionsForBudget operation
        ///</summary>
        IDescribeBudgetActionsForBudgetPaginator DescribeBudgetActionsForBudget(DescribeBudgetActionsForBudgetRequest request);

        /// <summary>
        /// Paginator for DescribeBudgetPerformanceHistory operation
        ///</summary>
        IDescribeBudgetPerformanceHistoryPaginator DescribeBudgetPerformanceHistory(DescribeBudgetPerformanceHistoryRequest request);

        /// <summary>
        /// Paginator for DescribeBudgets operation
        ///</summary>
        IDescribeBudgetsPaginator DescribeBudgets(DescribeBudgetsRequest request);

        /// <summary>
        /// Paginator for DescribeNotificationsForBudget operation
        ///</summary>
        IDescribeNotificationsForBudgetPaginator DescribeNotificationsForBudget(DescribeNotificationsForBudgetRequest request);

        /// <summary>
        /// Paginator for DescribeSubscribersForNotification operation
        ///</summary>
        IDescribeSubscribersForNotificationPaginator DescribeSubscribersForNotification(DescribeSubscribersForNotificationRequest request);
    }
}
#endif