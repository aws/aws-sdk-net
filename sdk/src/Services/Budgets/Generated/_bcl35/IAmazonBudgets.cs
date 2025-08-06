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

using Amazon.Runtime;
using Amazon.Budgets.Model;

#pragma warning disable CS1570
namespace Amazon.Budgets
{
    /// <summary>
    /// <para>Interface for accessing Budgets</para>
    ///
    /// Use the Amazon Web Services Budgets API to plan your service usage, service costs,
    /// and instance reservations. This API reference provides descriptions, syntax, and usage
    /// examples for each of the actions and data types for the Amazon Web Services Budgets
    /// feature. 
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
    /// Your current estimated charges from Amazon Web Services, and how much your predicted
    /// usage will accrue in charges by the end of the month
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// How much of your budget has been used
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Amazon Web Services updates your budget status several times a day. Budgets track
    /// your unblended costs, subscriptions, refunds, and RIs. You can create the following
    /// types of budgets:
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
    /// The Amazon Web Services Budgets API provides the following endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// https://budgets.amazonaws.com
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about costs that are associated with the Amazon Web Services Budgets
    /// API, see <a href="https://aws.amazon.com/aws-cost-management/pricing/">Amazon Web
    /// Services Cost Management Pricing</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonBudgets : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBudgetsPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateBudget


        /// <summary>
        /// Creates a budget and, if included, notifications and subscribers. 
        /// 
        ///  <important> 
        /// <para>
        /// Only one of <c>BudgetLimit</c> or <c>PlannedBudgetLimits</c> can be present in the
        /// syntax at one time. Use the syntax that matches your use case. The Request Syntax
        /// section shows the <c>BudgetLimit</c> syntax. For <c>PlannedBudgetLimits</c>, see the
        /// <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_budgets_CreateBudget.html#API_CreateBudget_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// Similarly, only one set of filter and metric selections can be present in the syntax
        /// at one time. Either <c>FilterExpression</c> and <c>Metrics</c> or <c>CostFilters</c>
        /// and <c>CostTypes</c>, not both or a different combination. We recommend using <c>FilterExpression</c>
        /// and <c>Metrics</c> as they provide more flexible and powerful filtering capabilities.
        /// The Request Syntax section shows the <c>FilterExpression</c>/<c>Metrics</c> syntax.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBudget service method.</param>
        /// 
        /// <returns>The response from the CreateBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.CreationLimitExceededException">
        /// You've exceeded the notification or subscriber limit.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.DuplicateRecordException">
        /// The budget name already exists. Budget names must be unique within an account.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ServiceQuotaExceededException">
        /// You've reached the limit on the number of tags you can associate with a resource.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateBudget">REST API Reference for CreateBudget Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateBudget">REST API Reference for CreateBudget Operation</seealso>
        IAsyncResult BeginCreateBudget(CreateBudgetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBudget.</param>
        /// 
        /// <returns>Returns a  CreateBudgetResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateBudget">REST API Reference for CreateBudget Operation</seealso>
        CreateBudgetResponse EndCreateBudget(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBudgetAction


        /// <summary>
        /// Creates a budget action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBudgetAction service method.</param>
        /// 
        /// <returns>The response from the CreateBudgetAction service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.CreationLimitExceededException">
        /// You've exceeded the notification or subscriber limit.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.DuplicateRecordException">
        /// The budget name already exists. Budget names must be unique within an account.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ServiceQuotaExceededException">
        /// You've reached the limit on the number of tags you can associate with a resource.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateBudgetAction">REST API Reference for CreateBudgetAction Operation</seealso>
        CreateBudgetActionResponse CreateBudgetAction(CreateBudgetActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBudgetAction operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBudgetAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateBudgetAction">REST API Reference for CreateBudgetAction Operation</seealso>
        IAsyncResult BeginCreateBudgetAction(CreateBudgetActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBudgetAction.</param>
        /// 
        /// <returns>Returns a  CreateBudgetActionResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateBudgetAction">REST API Reference for CreateBudgetAction Operation</seealso>
        CreateBudgetActionResponse EndCreateBudgetAction(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNotification


        /// <summary>
        /// Creates a notification. You must create the budget before you create the associated
        /// notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotification service method.</param>
        /// 
        /// <returns>The response from the CreateNotification service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.CreationLimitExceededException">
        /// You've exceeded the notification or subscriber limit.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.DuplicateRecordException">
        /// The budget name already exists. Budget names must be unique within an account.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateNotification">REST API Reference for CreateNotification Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateNotification">REST API Reference for CreateNotification Operation</seealso>
        IAsyncResult BeginCreateNotification(CreateNotificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNotification.</param>
        /// 
        /// <returns>Returns a  CreateNotificationResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateNotification">REST API Reference for CreateNotification Operation</seealso>
        CreateNotificationResponse EndCreateNotification(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSubscriber


        /// <summary>
        /// Creates a subscriber. You must create the associated budget and notification before
        /// you create the subscriber.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriber service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriber service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.CreationLimitExceededException">
        /// You've exceeded the notification or subscriber limit.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.DuplicateRecordException">
        /// The budget name already exists. Budget names must be unique within an account.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateSubscriber">REST API Reference for CreateSubscriber Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateSubscriber">REST API Reference for CreateSubscriber Operation</seealso>
        IAsyncResult BeginCreateSubscriber(CreateSubscriberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscriber.</param>
        /// 
        /// <returns>Returns a  CreateSubscriberResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/CreateSubscriber">REST API Reference for CreateSubscriber Operation</seealso>
        CreateSubscriberResponse EndCreateSubscriber(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBudget


        /// <summary>
        /// Deletes a budget. You can delete your budget at any time.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a budget also deletes the notifications and subscribers that are associated
        /// with that budget.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudget service method.</param>
        /// 
        /// <returns>The response from the DeleteBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteBudget">REST API Reference for DeleteBudget Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteBudget">REST API Reference for DeleteBudget Operation</seealso>
        IAsyncResult BeginDeleteBudget(DeleteBudgetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBudget.</param>
        /// 
        /// <returns>Returns a  DeleteBudgetResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteBudget">REST API Reference for DeleteBudget Operation</seealso>
        DeleteBudgetResponse EndDeleteBudget(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBudgetAction


        /// <summary>
        /// Deletes a budget action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudgetAction service method.</param>
        /// 
        /// <returns>The response from the DeleteBudgetAction service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ResourceLockedException">
        /// The request was received and recognized by the server, but the server rejected that
        /// particular method for the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteBudgetAction">REST API Reference for DeleteBudgetAction Operation</seealso>
        DeleteBudgetActionResponse DeleteBudgetAction(DeleteBudgetActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudgetAction operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBudgetAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteBudgetAction">REST API Reference for DeleteBudgetAction Operation</seealso>
        IAsyncResult BeginDeleteBudgetAction(DeleteBudgetActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBudgetAction.</param>
        /// 
        /// <returns>Returns a  DeleteBudgetActionResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteBudgetAction">REST API Reference for DeleteBudgetAction Operation</seealso>
        DeleteBudgetActionResponse EndDeleteBudgetAction(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNotification


        /// <summary>
        /// Deletes a notification.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a notification also deletes the subscribers that are associated with the
        /// notification.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotification service method.</param>
        /// 
        /// <returns>The response from the DeleteNotification service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteNotification">REST API Reference for DeleteNotification Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteNotification">REST API Reference for DeleteNotification Operation</seealso>
        IAsyncResult BeginDeleteNotification(DeleteNotificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotification.</param>
        /// 
        /// <returns>Returns a  DeleteNotificationResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteNotification">REST API Reference for DeleteNotification Operation</seealso>
        DeleteNotificationResponse EndDeleteNotification(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSubscriber


        /// <summary>
        /// Deletes a subscriber.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting the last subscriber to a notification also deletes the notification.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriber service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriber service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteSubscriber">REST API Reference for DeleteSubscriber Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteSubscriber">REST API Reference for DeleteSubscriber Operation</seealso>
        IAsyncResult BeginDeleteSubscriber(DeleteSubscriberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubscriber.</param>
        /// 
        /// <returns>Returns a  DeleteSubscriberResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DeleteSubscriber">REST API Reference for DeleteSubscriber Operation</seealso>
        DeleteSubscriberResponse EndDeleteSubscriber(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBudget


        /// <summary>
        /// Describes a budget.
        /// 
        ///  <important> 
        /// <para>
        /// The Request Syntax section shows the <c>BudgetLimit</c> syntax. For <c>PlannedBudgetLimits</c>,
        /// see the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_budgets_DescribeBudget.html#API_DescribeBudget_Examples">Examples</a>
        /// section.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudget service method.</param>
        /// 
        /// <returns>The response from the DescribeBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudget">REST API Reference for DescribeBudget Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudget">REST API Reference for DescribeBudget Operation</seealso>
        IAsyncResult BeginDescribeBudget(DescribeBudgetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudget.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudget">REST API Reference for DescribeBudget Operation</seealso>
        DescribeBudgetResponse EndDescribeBudget(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBudgetAction


        /// <summary>
        /// Describes a budget action detail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetAction service method.</param>
        /// 
        /// <returns>The response from the DescribeBudgetAction service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetAction">REST API Reference for DescribeBudgetAction Operation</seealso>
        DescribeBudgetActionResponse DescribeBudgetAction(DescribeBudgetActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetAction operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBudgetAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetAction">REST API Reference for DescribeBudgetAction Operation</seealso>
        IAsyncResult BeginDescribeBudgetAction(DescribeBudgetActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudgetAction.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetActionResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetAction">REST API Reference for DescribeBudgetAction Operation</seealso>
        DescribeBudgetActionResponse EndDescribeBudgetAction(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBudgetActionHistories


        /// <summary>
        /// Describes a budget action history detail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetActionHistories service method.</param>
        /// 
        /// <returns>The response from the DescribeBudgetActionHistories service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidNextTokenException">
        /// The pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetActionHistories">REST API Reference for DescribeBudgetActionHistories Operation</seealso>
        DescribeBudgetActionHistoriesResponse DescribeBudgetActionHistories(DescribeBudgetActionHistoriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudgetActionHistories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetActionHistories operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBudgetActionHistories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetActionHistories">REST API Reference for DescribeBudgetActionHistories Operation</seealso>
        IAsyncResult BeginDescribeBudgetActionHistories(DescribeBudgetActionHistoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudgetActionHistories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudgetActionHistories.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetActionHistoriesResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetActionHistories">REST API Reference for DescribeBudgetActionHistories Operation</seealso>
        DescribeBudgetActionHistoriesResponse EndDescribeBudgetActionHistories(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBudgetActionsForAccount


        /// <summary>
        /// Describes all of the budget actions for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetActionsForAccount service method.</param>
        /// 
        /// <returns>The response from the DescribeBudgetActionsForAccount service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidNextTokenException">
        /// The pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetActionsForAccount">REST API Reference for DescribeBudgetActionsForAccount Operation</seealso>
        DescribeBudgetActionsForAccountResponse DescribeBudgetActionsForAccount(DescribeBudgetActionsForAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudgetActionsForAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetActionsForAccount operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBudgetActionsForAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetActionsForAccount">REST API Reference for DescribeBudgetActionsForAccount Operation</seealso>
        IAsyncResult BeginDescribeBudgetActionsForAccount(DescribeBudgetActionsForAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudgetActionsForAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudgetActionsForAccount.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetActionsForAccountResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetActionsForAccount">REST API Reference for DescribeBudgetActionsForAccount Operation</seealso>
        DescribeBudgetActionsForAccountResponse EndDescribeBudgetActionsForAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBudgetActionsForBudget


        /// <summary>
        /// Describes all of the budget actions for a budget.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetActionsForBudget service method.</param>
        /// 
        /// <returns>The response from the DescribeBudgetActionsForBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidNextTokenException">
        /// The pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetActionsForBudget">REST API Reference for DescribeBudgetActionsForBudget Operation</seealso>
        DescribeBudgetActionsForBudgetResponse DescribeBudgetActionsForBudget(DescribeBudgetActionsForBudgetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudgetActionsForBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetActionsForBudget operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBudgetActionsForBudget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetActionsForBudget">REST API Reference for DescribeBudgetActionsForBudget Operation</seealso>
        IAsyncResult BeginDescribeBudgetActionsForBudget(DescribeBudgetActionsForBudgetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudgetActionsForBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudgetActionsForBudget.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetActionsForBudgetResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetActionsForBudget">REST API Reference for DescribeBudgetActionsForBudget Operation</seealso>
        DescribeBudgetActionsForBudgetResponse EndDescribeBudgetActionsForBudget(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBudgetNotificationsForAccount


        /// <summary>
        /// Lists the budget names and notifications that are associated with an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetNotificationsForAccount service method.</param>
        /// 
        /// <returns>The response from the DescribeBudgetNotificationsForAccount service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ExpiredNextTokenException">
        /// The pagination token expired.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidNextTokenException">
        /// The pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetNotificationsForAccount">REST API Reference for DescribeBudgetNotificationsForAccount Operation</seealso>
        DescribeBudgetNotificationsForAccountResponse DescribeBudgetNotificationsForAccount(DescribeBudgetNotificationsForAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudgetNotificationsForAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetNotificationsForAccount operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBudgetNotificationsForAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetNotificationsForAccount">REST API Reference for DescribeBudgetNotificationsForAccount Operation</seealso>
        IAsyncResult BeginDescribeBudgetNotificationsForAccount(DescribeBudgetNotificationsForAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudgetNotificationsForAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudgetNotificationsForAccount.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetNotificationsForAccountResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetNotificationsForAccount">REST API Reference for DescribeBudgetNotificationsForAccount Operation</seealso>
        DescribeBudgetNotificationsForAccountResponse EndDescribeBudgetNotificationsForAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBudgetPerformanceHistory


        /// <summary>
        /// Describes the history for <c>DAILY</c>, <c>MONTHLY</c>, and <c>QUARTERLY</c> budgets.
        /// Budget history isn't available for <c>ANNUAL</c> budgets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetPerformanceHistory service method.</param>
        /// 
        /// <returns>The response from the DescribeBudgetPerformanceHistory service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ExpiredNextTokenException">
        /// The pagination token expired.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidNextTokenException">
        /// The pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetPerformanceHistory">REST API Reference for DescribeBudgetPerformanceHistory Operation</seealso>
        DescribeBudgetPerformanceHistoryResponse DescribeBudgetPerformanceHistory(DescribeBudgetPerformanceHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBudgetPerformanceHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetPerformanceHistory operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBudgetPerformanceHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetPerformanceHistory">REST API Reference for DescribeBudgetPerformanceHistory Operation</seealso>
        IAsyncResult BeginDescribeBudgetPerformanceHistory(DescribeBudgetPerformanceHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudgetPerformanceHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudgetPerformanceHistory.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetPerformanceHistoryResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgetPerformanceHistory">REST API Reference for DescribeBudgetPerformanceHistory Operation</seealso>
        DescribeBudgetPerformanceHistoryResponse EndDescribeBudgetPerformanceHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBudgets


        /// <summary>
        /// Lists the budgets that are associated with an account.
        /// 
        ///  <important> 
        /// <para>
        /// The Request Syntax section shows the <c>BudgetLimit</c> syntax. For <c>PlannedBudgetLimits</c>,
        /// see the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_budgets_DescribeBudgets.html#API_DescribeBudgets_Examples">Examples</a>
        /// section.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgets service method.</param>
        /// 
        /// <returns>The response from the DescribeBudgets service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ExpiredNextTokenException">
        /// The pagination token expired.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidNextTokenException">
        /// The pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgets">REST API Reference for DescribeBudgets Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgets">REST API Reference for DescribeBudgets Operation</seealso>
        IAsyncResult BeginDescribeBudgets(DescribeBudgetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBudgets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBudgets.</param>
        /// 
        /// <returns>Returns a  DescribeBudgetsResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeBudgets">REST API Reference for DescribeBudgets Operation</seealso>
        DescribeBudgetsResponse EndDescribeBudgets(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeNotificationsForBudget


        /// <summary>
        /// Lists the notifications that are associated with a budget.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationsForBudget service method.</param>
        /// 
        /// <returns>The response from the DescribeNotificationsForBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ExpiredNextTokenException">
        /// The pagination token expired.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidNextTokenException">
        /// The pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeNotificationsForBudget">REST API Reference for DescribeNotificationsForBudget Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeNotificationsForBudget">REST API Reference for DescribeNotificationsForBudget Operation</seealso>
        IAsyncResult BeginDescribeNotificationsForBudget(DescribeNotificationsForBudgetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNotificationsForBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotificationsForBudget.</param>
        /// 
        /// <returns>Returns a  DescribeNotificationsForBudgetResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeNotificationsForBudget">REST API Reference for DescribeNotificationsForBudget Operation</seealso>
        DescribeNotificationsForBudgetResponse EndDescribeNotificationsForBudget(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSubscribersForNotification


        /// <summary>
        /// Lists the subscribers that are associated with a notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribersForNotification service method.</param>
        /// 
        /// <returns>The response from the DescribeSubscribersForNotification service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ExpiredNextTokenException">
        /// The pagination token expired.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidNextTokenException">
        /// The pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeSubscribersForNotification">REST API Reference for DescribeSubscribersForNotification Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeSubscribersForNotification">REST API Reference for DescribeSubscribersForNotification Operation</seealso>
        IAsyncResult BeginDescribeSubscribersForNotification(DescribeSubscribersForNotificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSubscribersForNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSubscribersForNotification.</param>
        /// 
        /// <returns>Returns a  DescribeSubscribersForNotificationResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/DescribeSubscribersForNotification">REST API Reference for DescribeSubscribersForNotification Operation</seealso>
        DescribeSubscribersForNotificationResponse EndDescribeSubscribersForNotification(IAsyncResult asyncResult);

        #endregion
        
        #region  ExecuteBudgetAction


        /// <summary>
        /// Executes a budget action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteBudgetAction service method.</param>
        /// 
        /// <returns>The response from the ExecuteBudgetAction service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ResourceLockedException">
        /// The request was received and recognized by the server, but the server rejected that
        /// particular method for the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/ExecuteBudgetAction">REST API Reference for ExecuteBudgetAction Operation</seealso>
        ExecuteBudgetActionResponse ExecuteBudgetAction(ExecuteBudgetActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteBudgetAction operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteBudgetAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/ExecuteBudgetAction">REST API Reference for ExecuteBudgetAction Operation</seealso>
        IAsyncResult BeginExecuteBudgetAction(ExecuteBudgetActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteBudgetAction.</param>
        /// 
        /// <returns>Returns a  ExecuteBudgetActionResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/ExecuteBudgetAction">REST API Reference for ExecuteBudgetAction Operation</seealso>
        ExecuteBudgetActionResponse EndExecuteBudgetAction(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags associated with a budget or budget action resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Creates tags for a budget or budget action resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ServiceQuotaExceededException">
        /// You've reached the limit on the number of tags you can associate with a resource.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes tags associated with a budget or budget action resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBudget


        /// <summary>
        /// Updates a budget. You can change every part of a budget except for the <c>budgetName</c>
        /// and the <c>calculatedSpend</c>. When you modify a budget, the <c>calculatedSpend</c>
        /// drops to zero until Amazon Web Services has new usage data to use for forecasting.
        /// 
        ///  <important> 
        /// <para>
        /// Only one of <c>BudgetLimit</c> or <c>PlannedBudgetLimits</c> can be present in the
        /// syntax at one time. Use the syntax that matches your case. The Request Syntax section
        /// shows the <c>BudgetLimit</c> syntax. For <c>PlannedBudgetLimits</c>, see the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_budgets_UpdateBudget.html#API_UpdateBudget_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// Similarly, only one set of filter and metric selections can be present in the syntax
        /// at one time. Either <c>FilterExpression</c> and <c>Metrics</c> or <c>CostFilters</c>
        /// and <c>CostTypes</c>, not both or a different combination. We recommend using <c>FilterExpression</c>
        /// and <c>Metrics</c> as they provide more flexible and powerful filtering capabilities.
        /// The Request Syntax section shows the <c>FilterExpression</c>/<c>Metrics</c> syntax.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudget service method.</param>
        /// 
        /// <returns>The response from the UpdateBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateBudget">REST API Reference for UpdateBudget Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateBudget">REST API Reference for UpdateBudget Operation</seealso>
        IAsyncResult BeginUpdateBudget(UpdateBudgetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBudget.</param>
        /// 
        /// <returns>Returns a  UpdateBudgetResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateBudget">REST API Reference for UpdateBudget Operation</seealso>
        UpdateBudgetResponse EndUpdateBudget(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBudgetAction


        /// <summary>
        /// Updates a budget action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudgetAction service method.</param>
        /// 
        /// <returns>The response from the UpdateBudgetAction service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ResourceLockedException">
        /// The request was received and recognized by the server, but the server rejected that
        /// particular method for the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateBudgetAction">REST API Reference for UpdateBudgetAction Operation</seealso>
        UpdateBudgetActionResponse UpdateBudgetAction(UpdateBudgetActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudgetAction operation on AmazonBudgetsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBudgetAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateBudgetAction">REST API Reference for UpdateBudgetAction Operation</seealso>
        IAsyncResult BeginUpdateBudgetAction(UpdateBudgetActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBudgetAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBudgetAction.</param>
        /// 
        /// <returns>Returns a  UpdateBudgetActionResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateBudgetAction">REST API Reference for UpdateBudgetAction Operation</seealso>
        UpdateBudgetActionResponse EndUpdateBudgetAction(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateNotification


        /// <summary>
        /// Updates a notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotification service method.</param>
        /// 
        /// <returns>The response from the UpdateNotification service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.DuplicateRecordException">
        /// The budget name already exists. Budget names must be unique within an account.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateNotification">REST API Reference for UpdateNotification Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateNotification">REST API Reference for UpdateNotification Operation</seealso>
        IAsyncResult BeginUpdateNotification(UpdateNotificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotification.</param>
        /// 
        /// <returns>Returns a  UpdateNotificationResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateNotification">REST API Reference for UpdateNotification Operation</seealso>
        UpdateNotificationResponse EndUpdateNotification(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSubscriber


        /// <summary>
        /// Updates a subscriber.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriber service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.DuplicateRecordException">
        /// The budget name already exists. Budget names must be unique within an account.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.InvalidParameterException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.NotFoundException">
        /// We can’t locate the resource that you specified.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.ThrottlingException">
        /// The number of API requests has exceeded the maximum allowed API request throttling
        /// limit for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateSubscriber">REST API Reference for UpdateSubscriber Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateSubscriber">REST API Reference for UpdateSubscriber Operation</seealso>
        IAsyncResult BeginUpdateSubscriber(UpdateSubscriberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubscriber.</param>
        /// 
        /// <returns>Returns a  UpdateSubscriberResult from Budgets.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/budgets-2016-10-20/UpdateSubscriber">REST API Reference for UpdateSubscriber Operation</seealso>
        UpdateSubscriberResponse EndUpdateSubscriber(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}