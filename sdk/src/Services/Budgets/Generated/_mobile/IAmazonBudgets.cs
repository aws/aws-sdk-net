/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Budgets.Model;

namespace Amazon.Budgets
{
    /// <summary>
    /// Interface for accessing Budgets
    ///
    /// The AWS Budgets API enables you to use AWS Budgets to plan your service usage, service
    /// costs, and instance reservations. The API reference provides descriptions, syntax,
    /// and usage examples for each of the actions and data types for AWS Budgets. 
    /// 
    ///  
    /// <para>
    /// Budgets provide you with a way to see the following information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// How close your plan is to your budgeted amount or to the free tier limits
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your usage-to-date, including how much you've used of your Reserved Instances (RIs)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your current estimated charges from AWS, and how much your predicted usage will accrue
    /// in charges by the end of the month
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// How much of your budget has been used
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// AWS updates your budget status several times a day. Budgets track your unblended costs,
    /// subscriptions, refunds, and RIs. You can create the following types of budgets:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Cost budgets</b> - Plan how much you want to spend on a service.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Usage budgets</b> - Plan how much you want to use one or more services.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>RI utilization budgets</b> - Define a utilization threshold, and receive alerts
    /// when your RI usage falls below that threshold. This lets you see if your RIs are unused
    /// or under-utilized.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>RI coverage budgets</b> - Define a coverage threshold, and receive alerts when
    /// the number of your instance hours that are covered by RIs fall below that threshold.
    /// This lets you see how much of your instance usage is covered by a reservation.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Service Endpoint
    /// </para>
    ///  
    /// <para>
    /// The AWS Budgets API provides the following endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// https://budgets.amazonaws.com
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about costs that are associated with the AWS Budgets API, see <a href="https://aws.amazon.com/aws-cost-management/pricing/">AWS
    /// Cost Management Pricing</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonBudgets : IAmazonService, IDisposable
    {
                
        #region  CreateBudget


        /// <summary>
        /// Initiates the asynchronous execution of the CreateBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBudget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateBudgetResponse> CreateBudgetAsync(CreateBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNotification


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateNotificationResponse> CreateNotificationAsync(CreateNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSubscriber


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriber operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateSubscriberResponse> CreateSubscriberAsync(CreateSubscriberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBudget


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteBudgetResponse> DeleteBudgetAsync(DeleteBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNotification


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteNotificationResponse> DeleteNotificationAsync(DeleteNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSubscriber


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubscriber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriber operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteSubscriberResponse> DeleteSubscriberAsync(DeleteSubscriberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBudget


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeBudgetResponse> DescribeBudgetAsync(DescribeBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBudgetPerformanceHistory


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudgetPerformanceHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetPerformanceHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeBudgetPerformanceHistoryResponse> DescribeBudgetPerformanceHistoryAsync(DescribeBudgetPerformanceHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBudgets


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudgets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeBudgetsResponse> DescribeBudgetsAsync(DescribeBudgetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNotificationsForBudget


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotificationsForBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationsForBudget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeNotificationsForBudgetResponse> DescribeNotificationsForBudgetAsync(DescribeNotificationsForBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSubscribersForNotification


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubscribersForNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribersForNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeSubscribersForNotificationResponse> DescribeSubscribersForNotificationAsync(DescribeSubscribersForNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateBudget


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateBudgetResponse> UpdateBudgetAsync(UpdateBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateNotification


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateNotificationResponse> UpdateNotificationAsync(UpdateNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSubscriber


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateSubscriberResponse> UpdateSubscriberAsync(UpdateSubscriberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}