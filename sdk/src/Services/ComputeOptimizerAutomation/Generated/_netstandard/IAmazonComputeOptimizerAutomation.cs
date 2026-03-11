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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ComputeOptimizerAutomation.Model;

#pragma warning disable CS1570
namespace Amazon.ComputeOptimizerAutomation
{
    /// <summary>
    /// <para>Interface for accessing ComputeOptimizerAutomation</para>
    ///
    /// Automation is a feature within Amazon Web Services Compute Optimizer that enables
    /// you to apply optimization recommendations to your Amazon Web Services resources, reducing
    /// costs and improving performance. You can apply recommended actions directly or create
    /// automation rules that implement recommendations on a recurring schedule when they
    /// match your specified criteria. With automation rules, set criteria such as Amazon
    /// Web Services Region and Resource Tags to target specific geographies and workloads.
    /// Configure rules to run daily, weekly, or monthly, and Compute Optimizer continuously
    /// evaluates new recommendations against your criteria. Track automation events over
    /// time, examine detailed step history, estimate savings achieved, and reverse actions
    /// directly from Compute Optimizer when needed.
    /// </summary>
    public partial interface IAmazonComputeOptimizerAutomation : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IComputeOptimizerAutomationPaginatorFactory Paginators { get; }
#endif
                
        #region  AssociateAccounts



        /// <summary>
        /// Associates one or more member accounts with your organization's management account,
        /// enabling centralized implementation of optimization actions across those accounts.
        /// Once associated, the management account (or a delegated administrator) can apply recommended
        /// actions to the member account. When you associate a member account, its organization
        /// rule mode is automatically set to "Any allowed," which permits the management account
        /// to create Automation rules that automatically apply actions to that account. If the
        /// member account has not previously enabled the Automation feature, the association
        /// process automatically enables it.
        /// 
        ///  <note> 
        /// <para>
        /// Only the management account or a delegated administrator can perform this action.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAccounts service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.NotManagementAccountException">
        /// The operation can only be performed by a management account.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/AssociateAccounts">REST API Reference for AssociateAccounts Operation</seealso>
        Task<AssociateAccountsResponse> AssociateAccountsAsync(AssociateAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAutomationRule



        /// <summary>
        /// Creates a new automation rule to apply recommended actions to resources based on
        /// specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomationRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAutomationRule service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceQuotaExceededException">
        /// The request would exceed service quotas.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/CreateAutomationRule">REST API Reference for CreateAutomationRule Operation</seealso>
        Task<CreateAutomationRuleResponse> CreateAutomationRuleAsync(CreateAutomationRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAutomationRule



        /// <summary>
        /// Deletes an existing automation rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomationRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAutomationRule service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/DeleteAutomationRule">REST API Reference for DeleteAutomationRule Operation</seealso>
        Task<DeleteAutomationRuleResponse> DeleteAutomationRuleAsync(DeleteAutomationRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateAccounts



        /// <summary>
        /// Disassociates member accounts from your organization's management account, removing
        /// centralized automation capabilities. Once disassociated, organization rules no longer
        /// apply to the member account, and the management account (or delegated administrator)
        /// cannot create Automation rules for that account. 
        /// 
        ///  <note> 
        /// <para>
        /// Only the management account or a delegated administrator can perform this action.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateAccounts service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.NotManagementAccountException">
        /// The operation can only be performed by a management account.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/DisassociateAccounts">REST API Reference for DisassociateAccounts Operation</seealso>
        Task<DisassociateAccountsResponse> DisassociateAccountsAsync(DisassociateAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAutomationEvent



        /// <summary>
        /// Retrieves details about a specific automation event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutomationEvent service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/GetAutomationEvent">REST API Reference for GetAutomationEvent Operation</seealso>
        Task<GetAutomationEventResponse> GetAutomationEventAsync(GetAutomationEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAutomationRule



        /// <summary>
        /// Retrieves details about a specific automation rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutomationRule service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/GetAutomationRule">REST API Reference for GetAutomationRule Operation</seealso>
        Task<GetAutomationRuleResponse> GetAutomationRuleAsync(GetAutomationRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEnrollmentConfiguration



        /// <summary>
        /// Retrieves the current enrollment configuration for Compute Optimizer Automation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnrollmentConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnrollmentConfiguration service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/GetEnrollmentConfiguration">REST API Reference for GetEnrollmentConfiguration Operation</seealso>
        Task<GetEnrollmentConfigurationResponse> GetEnrollmentConfigurationAsync(GetEnrollmentConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccounts



        /// <summary>
        /// Lists the accounts in your organization that are enrolled in Compute Optimizer and
        /// whether they have enabled Automation. 
        /// 
        ///  <note> 
        /// <para>
        /// Only the management account or a delegated administrator can perform this action.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccounts service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.NotManagementAccountException">
        /// The operation can only be performed by a management account.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        Task<ListAccountsResponse> ListAccountsAsync(ListAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAutomationEvents



        /// <summary>
        /// Lists automation events based on specified filters. You can retrieve events that were
        /// created within the past year.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomationEvents service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationEvents">REST API Reference for ListAutomationEvents Operation</seealso>
        Task<ListAutomationEventsResponse> ListAutomationEventsAsync(ListAutomationEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAutomationEventSteps



        /// <summary>
        /// Lists the steps for a specific automation event. You can only list steps for events
        /// created within the past year.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationEventSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomationEventSteps service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationEventSteps">REST API Reference for ListAutomationEventSteps Operation</seealso>
        Task<ListAutomationEventStepsResponse> ListAutomationEventStepsAsync(ListAutomationEventStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAutomationEventSummaries



        /// <summary>
        /// Provides a summary of automation events based on specified filters. Only events created
        /// within the past year will be included in the summary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationEventSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomationEventSummaries service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationEventSummaries">REST API Reference for ListAutomationEventSummaries Operation</seealso>
        Task<ListAutomationEventSummariesResponse> ListAutomationEventSummariesAsync(ListAutomationEventSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAutomationRulePreview



        /// <summary>
        /// Returns a preview of the recommended actions that match your Automation rule's configuration
        /// and criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRulePreview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomationRulePreview service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationRulePreview">REST API Reference for ListAutomationRulePreview Operation</seealso>
        Task<ListAutomationRulePreviewResponse> ListAutomationRulePreviewAsync(ListAutomationRulePreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAutomationRulePreviewSummaries



        /// <summary>
        /// Returns a summary of the recommended actions that match your rule preview configuration
        /// and criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRulePreviewSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomationRulePreviewSummaries service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationRulePreviewSummaries">REST API Reference for ListAutomationRulePreviewSummaries Operation</seealso>
        Task<ListAutomationRulePreviewSummariesResponse> ListAutomationRulePreviewSummariesAsync(ListAutomationRulePreviewSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAutomationRules



        /// <summary>
        /// Lists the automation rules that match specified filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutomationRules service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationRules">REST API Reference for ListAutomationRules Operation</seealso>
        Task<ListAutomationRulesResponse> ListAutomationRulesAsync(ListAutomationRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRecommendedActions



        /// <summary>
        /// Lists the recommended actions based that match specified filters. 
        /// 
        ///  <note> 
        /// <para>
        /// Management accounts and delegated administrators can retrieve recommended actions
        /// that include associated member accounts. You can associate a member account using
        /// <c>AssociateAccounts</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendedActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendedActions service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListRecommendedActions">REST API Reference for ListRecommendedActions Operation</seealso>
        Task<ListRecommendedActionsResponse> ListRecommendedActionsAsync(ListRecommendedActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRecommendedActionSummaries



        /// <summary>
        /// Provides a summary of recommended actions based on specified filters. 
        /// 
        ///  <note> 
        /// <para>
        /// Management accounts and delegated administrators can retrieve recommended actions
        /// that include associated member accounts. You can associate a member account using
        /// <c>AssociateAccounts</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendedActionSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendedActionSummaries service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListRecommendedActionSummaries">REST API Reference for ListRecommendedActionSummaries Operation</seealso>
        Task<ListRecommendedActionSummariesResponse> ListRecommendedActionSummariesAsync(ListRecommendedActionSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RollbackAutomationEvent



        /// <summary>
        /// Initiates a rollback for a completed automation event. 
        /// 
        ///  <note> 
        /// <para>
        /// Management accounts and delegated administrators can only initiate a rollback for
        /// events belonging to associated member accounts. You can associate a member account
        /// using <c>AssociateAccounts</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RollbackAutomationEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RollbackAutomationEvent service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/RollbackAutomationEvent">REST API Reference for RollbackAutomationEvent Operation</seealso>
        Task<RollbackAutomationEventResponse> RollbackAutomationEventAsync(RollbackAutomationEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartAutomationEvent



        /// <summary>
        /// Initiates a one-time, on-demand automation for the specified recommended action.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// Management accounts and delegated administrators can only initiate recommended actions
        /// for associated member accounts. You can associate a member account using <c>AssociateAccounts</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAutomationEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAutomationEvent service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceQuotaExceededException">
        /// The request would exceed service quotas.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/StartAutomationEvent">REST API Reference for StartAutomationEvent Operation</seealso>
        Task<StartAutomationEventResponse> StartAutomationEventAsync(StartAutomationEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAutomationRule



        /// <summary>
        /// Updates an existing automation rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomationRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAutomationRule service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/UpdateAutomationRule">REST API Reference for UpdateAutomationRule Operation</seealso>
        Task<UpdateAutomationRuleResponse> UpdateAutomationRuleAsync(UpdateAutomationRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEnrollmentConfiguration



        /// <summary>
        /// Updates your account’s Compute Optimizer Automation enrollment configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnrollmentConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnrollmentConfiguration service method, as returned by ComputeOptimizerAutomation.</returns>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ForbiddenException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotencyTokenInUseException">
        /// The specified client token is already in use.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.IdempotentParameterMismatchException">
        /// Exception thrown when the same client token is used with different parameters, indicating
        /// a mismatch in idempotent request parameters.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InternalServerException">
        /// An internal error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.NotManagementAccountException">
        /// The operation can only be performed by a management account.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.OptInRequiredException">
        /// The account must be opted in to Compute Optimizer Automation before performing this
        /// action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizerAutomation.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/UpdateEnrollmentConfiguration">REST API Reference for UpdateEnrollmentConfiguration Operation</seealso>
        Task<UpdateEnrollmentConfigurationResponse> UpdateEnrollmentConfigurationAsync(UpdateEnrollmentConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonComputeOptimizerAutomationConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonComputeOptimizerAutomationConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonComputeOptimizerAutomationConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonComputeOptimizerAutomationConfig to create AmazonComputeOptimizerAutomationClient");
            }

            return awsCredentials == null ? 
                    new AmazonComputeOptimizerAutomationClient(serviceClientConfig) :
                    new AmazonComputeOptimizerAutomationClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}