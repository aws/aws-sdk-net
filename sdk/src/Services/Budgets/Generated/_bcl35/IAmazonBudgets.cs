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
        /// <param name="request">Container for the necessary parameters to execute the CreateBudget operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBudget
        ///         operation.</returns>
        IAsyncResult BeginCreateBudget(CreateBudgetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBudget.</param>
        /// 
        /// <returns>Returns a  CreateBudgetResult from Budgets.</returns>
        CreateBudgetResponse EndCreateBudget(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the CreateNotification operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNotification
        ///         operation.</returns>
        IAsyncResult BeginCreateNotification(CreateNotificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNotification.</param>
        /// 
        /// <returns>Returns a  CreateNotificationResult from Budgets.</returns>
        CreateNotificationResponse EndCreateNotification(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriber operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubscriber
        ///         operation.</returns>
        IAsyncResult BeginCreateSubscriber(CreateSubscriberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscriber.</param>
        /// 
        /// <returns>Returns a  CreateSubscriberResult from Budgets.</returns>
        CreateSubscriberResponse EndCreateSubscriber(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudget operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBudget
        ///         operation.</returns>
        IAsyncResult BeginDeleteBudget(DeleteBudgetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBudget.</param>
        /// 
        /// <returns>Returns a  DeleteBudgetResult from Budgets.</returns>
        DeleteBudgetResponse EndDeleteBudget(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotification operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNotification
        ///         operation.</returns>
        IAsyncResult BeginDeleteNotification(DeleteNotificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotification.</param>
        /// 
        /// <returns>Returns a  DeleteNotificationResult from Budgets.</returns>
        DeleteNotificationResponse EndDeleteNotification(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriber operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSubscriber
        ///         operation.</returns>
        IAsyncResult BeginDeleteSubscriber(DeleteSubscriberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubscriber.</param>
        /// 
        /// <returns>Returns a  DeleteSubscriberResult from Budgets.</returns>
        DeleteSubscriberResponse EndDeleteSubscriber(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudget operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBudget
        ///         operation.</returns>
        IAsyncResult BeginDescribeBudget(DescribeBudgetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudget.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetResult from Budgets.</returns>
        DescribeBudgetResponse EndDescribeBudget(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgets operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBudgets
        ///         operation.</returns>
        IAsyncResult BeginDescribeBudgets(DescribeBudgetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudgets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudgets.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetsResult from Budgets.</returns>
        DescribeBudgetsResponse EndDescribeBudgets(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationsForBudget operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNotificationsForBudget
        ///         operation.</returns>
        IAsyncResult BeginDescribeNotificationsForBudget(DescribeNotificationsForBudgetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNotificationsForBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotificationsForBudget.</param>
        /// 
        /// <returns>Returns a  DescribeNotificationsForBudgetResult from Budgets.</returns>
        DescribeNotificationsForBudgetResponse EndDescribeNotificationsForBudget(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribersForNotification operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSubscribersForNotification
        ///         operation.</returns>
        IAsyncResult BeginDescribeSubscribersForNotification(DescribeSubscribersForNotificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSubscribersForNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSubscribersForNotification.</param>
        /// 
        /// <returns>Returns a  DescribeSubscribersForNotificationResult from Budgets.</returns>
        DescribeSubscribersForNotificationResponse EndDescribeSubscribersForNotification(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudget operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBudget
        ///         operation.</returns>
        IAsyncResult BeginUpdateBudget(UpdateBudgetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBudget.</param>
        /// 
        /// <returns>Returns a  UpdateBudgetResult from Budgets.</returns>
        UpdateBudgetResponse EndUpdateBudget(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotification operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNotification
        ///         operation.</returns>
        IAsyncResult BeginUpdateNotification(UpdateNotificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotification.</param>
        /// 
        /// <returns>Returns a  UpdateNotificationResult from Budgets.</returns>
        UpdateNotificationResponse EndUpdateNotification(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSubscriber
        ///         operation.</returns>
        IAsyncResult BeginUpdateSubscriber(UpdateSubscriberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubscriber.</param>
        /// 
        /// <returns>Returns a  UpdateSubscriberResult from Budgets.</returns>
        UpdateSubscriberResponse EndUpdateSubscriber(IAsyncResult asyncResult);

        #endregion
        
    }
}