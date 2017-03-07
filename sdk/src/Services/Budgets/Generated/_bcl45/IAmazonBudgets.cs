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
    /// All public APIs for AWS Budgets
    /// </summary>
    public partial interface IAmazonBudgets : IAmazonService, IDisposable
    {

        
        #region  CreateBudget


        /// <summary>
        /// Create a new budget
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBudget service method.</param>
        /// 
        /// <returns>The response from the CreateBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.CreationLimitExceededException">
        /// The exception is thrown when customer tries to create a record (e.g. budget), but
        /// the number this record already exceeds the limitation.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.DuplicateRecordException">
        /// The exception is thrown when customer tries to create a record (e.g. budget) that
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        CreateBudgetResponse CreateBudget(CreateBudgetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBudget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateBudgetResponse> CreateBudgetAsync(CreateBudgetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateNotification


        /// <summary>
        /// Create a new Notification with subscribers for a budget
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotification service method.</param>
        /// 
        /// <returns>The response from the CreateNotification service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.CreationLimitExceededException">
        /// The exception is thrown when customer tries to create a record (e.g. budget), but
        /// the number this record already exceeds the limitation.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.DuplicateRecordException">
        /// The exception is thrown when customer tries to create a record (e.g. budget) that
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        CreateNotificationResponse CreateNotification(CreateNotificationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateNotificationResponse> CreateNotificationAsync(CreateNotificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSubscriber


        /// <summary>
        /// Create a new Subscriber for a notification
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriber service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriber service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.CreationLimitExceededException">
        /// The exception is thrown when customer tries to create a record (e.g. budget), but
        /// the number this record already exceeds the limitation.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.DuplicateRecordException">
        /// The exception is thrown when customer tries to create a record (e.g. budget) that
        /// already exists.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        CreateSubscriberResponse CreateSubscriber(CreateSubscriberRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriber operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateSubscriberResponse> CreateSubscriberAsync(CreateSubscriberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBudget


        /// <summary>
        /// Delete a budget and related notifications
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudget service method.</param>
        /// 
        /// <returns>The response from the DeleteBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        DeleteBudgetResponse DeleteBudget(DeleteBudgetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteBudgetResponse> DeleteBudgetAsync(DeleteBudgetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteNotification


        /// <summary>
        /// Delete a notification and related subscribers
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotification service method.</param>
        /// 
        /// <returns>The response from the DeleteNotification service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        DeleteNotificationResponse DeleteNotification(DeleteNotificationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteNotificationResponse> DeleteNotificationAsync(DeleteNotificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSubscriber


        /// <summary>
        /// Delete a Subscriber for a notification
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriber service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriber service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        DeleteSubscriberResponse DeleteSubscriber(DeleteSubscriberRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubscriber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriber operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteSubscriberResponse> DeleteSubscriberAsync(DeleteSubscriberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeBudget


        /// <summary>
        /// Get a single budget
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudget service method.</param>
        /// 
        /// <returns>The response from the DescribeBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        DescribeBudgetResponse DescribeBudget(DescribeBudgetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeBudgetResponse> DescribeBudgetAsync(DescribeBudgetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeBudgets


        /// <summary>
        /// Get all budgets for an account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgets service method.</param>
        /// 
        /// <returns>The response from the DescribeBudgets service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.ExpiredNextTokenException">
        /// This exception is thrown if the paging token is expired - past its TTL
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidNextTokenException">
        /// This exception is thrown if paging token signature didn't match the token, or the
        /// paging token isn't for this request
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        DescribeBudgetsResponse DescribeBudgets(DescribeBudgetsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudgets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeBudgetsResponse> DescribeBudgetsAsync(DescribeBudgetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeNotificationsForBudget


        /// <summary>
        /// Get notifications of a budget
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationsForBudget service method.</param>
        /// 
        /// <returns>The response from the DescribeNotificationsForBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.ExpiredNextTokenException">
        /// This exception is thrown if the paging token is expired - past its TTL
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidNextTokenException">
        /// This exception is thrown if paging token signature didn't match the token, or the
        /// paging token isn't for this request
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        DescribeNotificationsForBudgetResponse DescribeNotificationsForBudget(DescribeNotificationsForBudgetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotificationsForBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationsForBudget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeNotificationsForBudgetResponse> DescribeNotificationsForBudgetAsync(DescribeNotificationsForBudgetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSubscribersForNotification


        /// <summary>
        /// Get subscribers of a notification
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribersForNotification service method.</param>
        /// 
        /// <returns>The response from the DescribeSubscribersForNotification service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.ExpiredNextTokenException">
        /// This exception is thrown if the paging token is expired - past its TTL
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidNextTokenException">
        /// This exception is thrown if paging token signature didn't match the token, or the
        /// paging token isn't for this request
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        DescribeSubscribersForNotificationResponse DescribeSubscribersForNotification(DescribeSubscribersForNotificationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubscribersForNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribersForNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeSubscribersForNotificationResponse> DescribeSubscribersForNotificationAsync(DescribeSubscribersForNotificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateBudget


        /// <summary>
        /// Update the information of a budget already created
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudget service method.</param>
        /// 
        /// <returns>The response from the UpdateBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        UpdateBudgetResponse UpdateBudget(UpdateBudgetRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateBudgetResponse> UpdateBudgetAsync(UpdateBudgetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateNotification


        /// <summary>
        /// Update the information about a notification already created
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotification service method.</param>
        /// 
        /// <returns>The response from the UpdateNotification service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        UpdateNotificationResponse UpdateNotification(UpdateNotificationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateNotificationResponse> UpdateNotificationAsync(UpdateNotificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSubscriber


        /// <summary>
        /// Update a subscriber
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriber service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// This exception is thrown on an unknown internal failure.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// This exception is thrown if any request is given an invalid parameter. E.g., if a
        /// required Date field is null.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// This exception is thrown if a requested entity is not found. E.g., if a budget id
        /// doesn't exist for an account ID.
        /// </exception>
        UpdateSubscriberResponse UpdateSubscriber(UpdateSubscriberRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateSubscriberResponse> UpdateSubscriberAsync(UpdateSubscriberRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}