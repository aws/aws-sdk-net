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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.Budgets.Model
{
    /// <summary>
    /// Paginators for the Budgets service
    ///</summary>
    public class BudgetsPaginatorFactory : IBudgetsPaginatorFactory
    {
        private readonly IAmazonBudgets client;

        internal BudgetsPaginatorFactory(IAmazonBudgets client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for DescribeBudgetActionHistories operation
        ///</summary>
        public IDescribeBudgetActionHistoriesPaginator DescribeBudgetActionHistories(DescribeBudgetActionHistoriesRequest request) 
        {
            return new DescribeBudgetActionHistoriesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeBudgetActionsForAccount operation
        ///</summary>
        public IDescribeBudgetActionsForAccountPaginator DescribeBudgetActionsForAccount(DescribeBudgetActionsForAccountRequest request) 
        {
            return new DescribeBudgetActionsForAccountPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeBudgetActionsForBudget operation
        ///</summary>
        public IDescribeBudgetActionsForBudgetPaginator DescribeBudgetActionsForBudget(DescribeBudgetActionsForBudgetRequest request) 
        {
            return new DescribeBudgetActionsForBudgetPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeBudgetNotificationsForAccount operation
        ///</summary>
        public IDescribeBudgetNotificationsForAccountPaginator DescribeBudgetNotificationsForAccount(DescribeBudgetNotificationsForAccountRequest request) 
        {
            return new DescribeBudgetNotificationsForAccountPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeBudgetPerformanceHistory operation
        ///</summary>
        public IDescribeBudgetPerformanceHistoryPaginator DescribeBudgetPerformanceHistory(DescribeBudgetPerformanceHistoryRequest request) 
        {
            return new DescribeBudgetPerformanceHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeBudgets operation
        ///</summary>
        public IDescribeBudgetsPaginator DescribeBudgets(DescribeBudgetsRequest request) 
        {
            return new DescribeBudgetsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeNotificationsForBudget operation
        ///</summary>
        public IDescribeNotificationsForBudgetPaginator DescribeNotificationsForBudget(DescribeNotificationsForBudgetRequest request) 
        {
            return new DescribeNotificationsForBudgetPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for DescribeSubscribersForNotification operation
        ///</summary>
        public IDescribeSubscribersForNotificationPaginator DescribeSubscribersForNotification(DescribeSubscribersForNotificationRequest request) 
        {
            return new DescribeSubscribersForNotificationPaginator(this.client, request);
        }
    }
}