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
using System.Threading;
using System.Threading.Tasks;
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
#if AWS_ASYNC_ENUMERABLES_API
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.BillingViewHealthStatusException">
        /// The billing view status must be HEALTHY to perform this action. Try again when the
        /// status is HEALTHY.
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
        Task<CreateBudgetResponse> CreateBudgetAsync(CreateBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateBudgetAction



        /// <summary>
        /// Creates a budget action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBudgetAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateBudgetActionResponse> CreateBudgetActionAsync(CreateBudgetActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNotification



        /// <summary>
        /// Creates a notification. You must create the budget before you create the associated
        /// notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateNotificationResponse> CreateNotificationAsync(CreateNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSubscriber



        /// <summary>
        /// Creates a subscriber. You must create the associated budget and notification before
        /// you create the subscriber.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateSubscriberResponse> CreateSubscriberAsync(CreateSubscriberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteBudgetResponse> DeleteBudgetAsync(DeleteBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBudgetAction



        /// <summary>
        /// Deletes a budget action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudgetAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteBudgetActionResponse> DeleteBudgetActionAsync(DeleteBudgetActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteNotificationResponse> DeleteNotificationAsync(DeleteNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteSubscriberResponse> DeleteSubscriberAsync(DeleteSubscriberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeBudgetResponse> DescribeBudgetAsync(DescribeBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBudgetAction



        /// <summary>
        /// Describes a budget action detail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeBudgetActionResponse> DescribeBudgetActionAsync(DescribeBudgetActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBudgetActionHistories



        /// <summary>
        /// Describes a budget action history detail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetActionHistories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeBudgetActionHistoriesResponse> DescribeBudgetActionHistoriesAsync(DescribeBudgetActionHistoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBudgetActionsForAccount



        /// <summary>
        /// Describes all of the budget actions for an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetActionsForAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeBudgetActionsForAccountResponse> DescribeBudgetActionsForAccountAsync(DescribeBudgetActionsForAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBudgetActionsForBudget



        /// <summary>
        /// Describes all of the budget actions for a budget.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetActionsForBudget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeBudgetActionsForBudgetResponse> DescribeBudgetActionsForBudgetAsync(DescribeBudgetActionsForBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBudgetNotificationsForAccount



        /// <summary>
        /// Lists the budget names and notifications that are associated with an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetNotificationsForAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeBudgetNotificationsForAccountResponse> DescribeBudgetNotificationsForAccountAsync(DescribeBudgetNotificationsForAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBudgetPerformanceHistory



        /// <summary>
        /// Describes the history for <c>DAILY</c>, <c>MONTHLY</c>, and <c>QUARTERLY</c> budgets.
        /// Budget history isn't available for <c>ANNUAL</c> budgets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBudgetPerformanceHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeBudgetPerformanceHistoryResponse> DescribeBudgetPerformanceHistoryAsync(DescribeBudgetPerformanceHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeBudgetsResponse> DescribeBudgetsAsync(DescribeBudgetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNotificationsForBudget



        /// <summary>
        /// Lists the notifications that are associated with a budget.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationsForBudget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeNotificationsForBudgetResponse> DescribeNotificationsForBudgetAsync(DescribeNotificationsForBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSubscribersForNotification



        /// <summary>
        /// Lists the subscribers that are associated with a notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribersForNotification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeSubscribersForNotificationResponse> DescribeSubscribersForNotificationAsync(DescribeSubscribersForNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExecuteBudgetAction



        /// <summary>
        /// Executes a budget action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteBudgetAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ExecuteBudgetActionResponse> ExecuteBudgetActionAsync(ExecuteBudgetActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists tags associated with a budget or budget action resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Creates tags for a budget or budget action resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Deletes tags associated with a budget or budget action resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBudget service method, as returned by Budgets.</returns>
        /// <exception cref="Amazon.Budgets.Model.AccessDeniedException">
        /// You are not authorized to use this operation with the given parameters.
        /// </exception>
        /// <exception cref="Amazon.Budgets.Model.BillingViewHealthStatusException">
        /// The billing view status must be HEALTHY to perform this action. Try again when the
        /// status is HEALTHY.
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
        Task<UpdateBudgetResponse> UpdateBudgetAsync(UpdateBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateBudgetAction



        /// <summary>
        /// Updates a budget action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudgetAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateBudgetActionResponse> UpdateBudgetActionAsync(UpdateBudgetActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateNotification



        /// <summary>
        /// Updates a notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateNotificationResponse> UpdateNotificationAsync(UpdateNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSubscriber



        /// <summary>
        /// Updates a subscriber.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateSubscriberResponse> UpdateSubscriberAsync(UpdateSubscriberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonBudgetsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonBudgetsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonBudgetsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonBudgetsConfig to create AmazonBudgetsClient");
            }

            return awsCredentials == null ? 
                    new AmazonBudgetsClient(serviceClientConfig) :
                    new AmazonBudgetsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}