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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        AssociateAccountsResponse AssociateAccounts(AssociateAccountsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAccounts operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/AssociateAccounts">REST API Reference for AssociateAccounts Operation</seealso>
        IAsyncResult BeginAssociateAccounts(AssociateAccountsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAccounts.</param>
        /// 
        /// <returns>Returns a  AssociateAccountsResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/AssociateAccounts">REST API Reference for AssociateAccounts Operation</seealso>
        AssociateAccountsResponse EndAssociateAccounts(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAutomationRule


        /// <summary>
        /// Creates a new automation rule to apply recommended actions to resources based on
        /// specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomationRule service method.</param>
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
        CreateAutomationRuleResponse CreateAutomationRule(CreateAutomationRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAutomationRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomationRule operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAutomationRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/CreateAutomationRule">REST API Reference for CreateAutomationRule Operation</seealso>
        IAsyncResult BeginCreateAutomationRule(CreateAutomationRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAutomationRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAutomationRule.</param>
        /// 
        /// <returns>Returns a  CreateAutomationRuleResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/CreateAutomationRule">REST API Reference for CreateAutomationRule Operation</seealso>
        CreateAutomationRuleResponse EndCreateAutomationRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAutomationRule


        /// <summary>
        /// Deletes an existing automation rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomationRule service method.</param>
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
        DeleteAutomationRuleResponse DeleteAutomationRule(DeleteAutomationRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAutomationRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomationRule operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAutomationRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/DeleteAutomationRule">REST API Reference for DeleteAutomationRule Operation</seealso>
        IAsyncResult BeginDeleteAutomationRule(DeleteAutomationRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAutomationRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAutomationRule.</param>
        /// 
        /// <returns>Returns a  DeleteAutomationRuleResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/DeleteAutomationRule">REST API Reference for DeleteAutomationRule Operation</seealso>
        DeleteAutomationRuleResponse EndDeleteAutomationRule(IAsyncResult asyncResult);

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
        DisassociateAccountsResponse DisassociateAccounts(DisassociateAccountsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAccounts operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/DisassociateAccounts">REST API Reference for DisassociateAccounts Operation</seealso>
        IAsyncResult BeginDisassociateAccounts(DisassociateAccountsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAccounts.</param>
        /// 
        /// <returns>Returns a  DisassociateAccountsResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/DisassociateAccounts">REST API Reference for DisassociateAccounts Operation</seealso>
        DisassociateAccountsResponse EndDisassociateAccounts(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAutomationEvent


        /// <summary>
        /// Retrieves details about a specific automation event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationEvent service method.</param>
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
        GetAutomationEventResponse GetAutomationEvent(GetAutomationEventRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAutomationEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationEvent operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutomationEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/GetAutomationEvent">REST API Reference for GetAutomationEvent Operation</seealso>
        IAsyncResult BeginGetAutomationEvent(GetAutomationEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutomationEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutomationEvent.</param>
        /// 
        /// <returns>Returns a  GetAutomationEventResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/GetAutomationEvent">REST API Reference for GetAutomationEvent Operation</seealso>
        GetAutomationEventResponse EndGetAutomationEvent(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAutomationRule


        /// <summary>
        /// Retrieves details about a specific automation rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationRule service method.</param>
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
        GetAutomationRuleResponse GetAutomationRule(GetAutomationRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAutomationRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutomationRule operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutomationRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/GetAutomationRule">REST API Reference for GetAutomationRule Operation</seealso>
        IAsyncResult BeginGetAutomationRule(GetAutomationRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutomationRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutomationRule.</param>
        /// 
        /// <returns>Returns a  GetAutomationRuleResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/GetAutomationRule">REST API Reference for GetAutomationRule Operation</seealso>
        GetAutomationRuleResponse EndGetAutomationRule(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEnrollmentConfiguration


        /// <summary>
        /// Retrieves the current enrollment configuration for Compute Optimizer Automation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnrollmentConfiguration service method.</param>
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
        GetEnrollmentConfigurationResponse GetEnrollmentConfiguration(GetEnrollmentConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnrollmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnrollmentConfiguration operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnrollmentConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/GetEnrollmentConfiguration">REST API Reference for GetEnrollmentConfiguration Operation</seealso>
        IAsyncResult BeginGetEnrollmentConfiguration(GetEnrollmentConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnrollmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnrollmentConfiguration.</param>
        /// 
        /// <returns>Returns a  GetEnrollmentConfigurationResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/GetEnrollmentConfiguration">REST API Reference for GetEnrollmentConfiguration Operation</seealso>
        GetEnrollmentConfigurationResponse EndGetEnrollmentConfiguration(IAsyncResult asyncResult);

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
        ListAccountsResponse ListAccounts(ListAccountsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        IAsyncResult BeginListAccounts(ListAccountsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccounts.</param>
        /// 
        /// <returns>Returns a  ListAccountsResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        ListAccountsResponse EndListAccounts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAutomationEvents


        /// <summary>
        /// Lists automation events based on specified filters. You can retrieve events that were
        /// created within the past year.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationEvents service method.</param>
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
        ListAutomationEventsResponse ListAutomationEvents(ListAutomationEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAutomationEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationEvents operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAutomationEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationEvents">REST API Reference for ListAutomationEvents Operation</seealso>
        IAsyncResult BeginListAutomationEvents(ListAutomationEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAutomationEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAutomationEvents.</param>
        /// 
        /// <returns>Returns a  ListAutomationEventsResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationEvents">REST API Reference for ListAutomationEvents Operation</seealso>
        ListAutomationEventsResponse EndListAutomationEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAutomationEventSteps


        /// <summary>
        /// Lists the steps for a specific automation event. You can only list steps for events
        /// created within the past year.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationEventSteps service method.</param>
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
        ListAutomationEventStepsResponse ListAutomationEventSteps(ListAutomationEventStepsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAutomationEventSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationEventSteps operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAutomationEventSteps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationEventSteps">REST API Reference for ListAutomationEventSteps Operation</seealso>
        IAsyncResult BeginListAutomationEventSteps(ListAutomationEventStepsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAutomationEventSteps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAutomationEventSteps.</param>
        /// 
        /// <returns>Returns a  ListAutomationEventStepsResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationEventSteps">REST API Reference for ListAutomationEventSteps Operation</seealso>
        ListAutomationEventStepsResponse EndListAutomationEventSteps(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAutomationEventSummaries


        /// <summary>
        /// Provides a summary of automation events based on specified filters. Only events created
        /// within the past year will be included in the summary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationEventSummaries service method.</param>
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
        ListAutomationEventSummariesResponse ListAutomationEventSummaries(ListAutomationEventSummariesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAutomationEventSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationEventSummaries operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAutomationEventSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationEventSummaries">REST API Reference for ListAutomationEventSummaries Operation</seealso>
        IAsyncResult BeginListAutomationEventSummaries(ListAutomationEventSummariesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAutomationEventSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAutomationEventSummaries.</param>
        /// 
        /// <returns>Returns a  ListAutomationEventSummariesResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationEventSummaries">REST API Reference for ListAutomationEventSummaries Operation</seealso>
        ListAutomationEventSummariesResponse EndListAutomationEventSummaries(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAutomationRulePreview


        /// <summary>
        /// Returns a preview of the recommended actions that match your Automation rule's configuration
        /// and criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRulePreview service method.</param>
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
        ListAutomationRulePreviewResponse ListAutomationRulePreview(ListAutomationRulePreviewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAutomationRulePreview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRulePreview operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAutomationRulePreview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationRulePreview">REST API Reference for ListAutomationRulePreview Operation</seealso>
        IAsyncResult BeginListAutomationRulePreview(ListAutomationRulePreviewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAutomationRulePreview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAutomationRulePreview.</param>
        /// 
        /// <returns>Returns a  ListAutomationRulePreviewResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationRulePreview">REST API Reference for ListAutomationRulePreview Operation</seealso>
        ListAutomationRulePreviewResponse EndListAutomationRulePreview(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAutomationRulePreviewSummaries


        /// <summary>
        /// Returns a summary of the recommended actions that match your rule preview configuration
        /// and criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRulePreviewSummaries service method.</param>
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
        ListAutomationRulePreviewSummariesResponse ListAutomationRulePreviewSummaries(ListAutomationRulePreviewSummariesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAutomationRulePreviewSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRulePreviewSummaries operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAutomationRulePreviewSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationRulePreviewSummaries">REST API Reference for ListAutomationRulePreviewSummaries Operation</seealso>
        IAsyncResult BeginListAutomationRulePreviewSummaries(ListAutomationRulePreviewSummariesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAutomationRulePreviewSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAutomationRulePreviewSummaries.</param>
        /// 
        /// <returns>Returns a  ListAutomationRulePreviewSummariesResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationRulePreviewSummaries">REST API Reference for ListAutomationRulePreviewSummaries Operation</seealso>
        ListAutomationRulePreviewSummariesResponse EndListAutomationRulePreviewSummaries(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAutomationRules


        /// <summary>
        /// Lists the automation rules that match specified filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRules service method.</param>
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
        ListAutomationRulesResponse ListAutomationRules(ListAutomationRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAutomationRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAutomationRules operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAutomationRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationRules">REST API Reference for ListAutomationRules Operation</seealso>
        IAsyncResult BeginListAutomationRules(ListAutomationRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAutomationRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAutomationRules.</param>
        /// 
        /// <returns>Returns a  ListAutomationRulesResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListAutomationRules">REST API Reference for ListAutomationRules Operation</seealso>
        ListAutomationRulesResponse EndListAutomationRules(IAsyncResult asyncResult);

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
        ListRecommendedActionsResponse ListRecommendedActions(ListRecommendedActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecommendedActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendedActions operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecommendedActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListRecommendedActions">REST API Reference for ListRecommendedActions Operation</seealso>
        IAsyncResult BeginListRecommendedActions(ListRecommendedActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecommendedActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecommendedActions.</param>
        /// 
        /// <returns>Returns a  ListRecommendedActionsResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListRecommendedActions">REST API Reference for ListRecommendedActions Operation</seealso>
        ListRecommendedActionsResponse EndListRecommendedActions(IAsyncResult asyncResult);

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
        ListRecommendedActionSummariesResponse ListRecommendedActionSummaries(ListRecommendedActionSummariesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecommendedActionSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendedActionSummaries operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecommendedActionSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListRecommendedActionSummaries">REST API Reference for ListRecommendedActionSummaries Operation</seealso>
        IAsyncResult BeginListRecommendedActionSummaries(ListRecommendedActionSummariesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecommendedActionSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecommendedActionSummaries.</param>
        /// 
        /// <returns>Returns a  ListRecommendedActionSummariesResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListRecommendedActionSummaries">REST API Reference for ListRecommendedActionSummaries Operation</seealso>
        ListRecommendedActionSummariesResponse EndListRecommendedActionSummaries(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        RollbackAutomationEventResponse RollbackAutomationEvent(RollbackAutomationEventRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RollbackAutomationEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RollbackAutomationEvent operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRollbackAutomationEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/RollbackAutomationEvent">REST API Reference for RollbackAutomationEvent Operation</seealso>
        IAsyncResult BeginRollbackAutomationEvent(RollbackAutomationEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RollbackAutomationEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRollbackAutomationEvent.</param>
        /// 
        /// <returns>Returns a  RollbackAutomationEventResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/RollbackAutomationEvent">REST API Reference for RollbackAutomationEvent Operation</seealso>
        RollbackAutomationEventResponse EndRollbackAutomationEvent(IAsyncResult asyncResult);

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
        StartAutomationEventResponse StartAutomationEvent(StartAutomationEventRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartAutomationEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAutomationEvent operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAutomationEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/StartAutomationEvent">REST API Reference for StartAutomationEvent Operation</seealso>
        IAsyncResult BeginStartAutomationEvent(StartAutomationEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartAutomationEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAutomationEvent.</param>
        /// 
        /// <returns>Returns a  StartAutomationEventResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/StartAutomationEvent">REST API Reference for StartAutomationEvent Operation</seealso>
        StartAutomationEventResponse EndStartAutomationEvent(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAutomationRule


        /// <summary>
        /// Updates an existing automation rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomationRule service method.</param>
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
        UpdateAutomationRuleResponse UpdateAutomationRule(UpdateAutomationRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAutomationRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomationRule operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAutomationRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/UpdateAutomationRule">REST API Reference for UpdateAutomationRule Operation</seealso>
        IAsyncResult BeginUpdateAutomationRule(UpdateAutomationRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAutomationRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAutomationRule.</param>
        /// 
        /// <returns>Returns a  UpdateAutomationRuleResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/UpdateAutomationRule">REST API Reference for UpdateAutomationRule Operation</seealso>
        UpdateAutomationRuleResponse EndUpdateAutomationRule(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEnrollmentConfiguration


        /// <summary>
        /// Updates your account’s Compute Optimizer Automation enrollment configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnrollmentConfiguration service method.</param>
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
        UpdateEnrollmentConfigurationResponse UpdateEnrollmentConfiguration(UpdateEnrollmentConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnrollmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnrollmentConfiguration operation on AmazonComputeOptimizerAutomationClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnrollmentConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/UpdateEnrollmentConfiguration">REST API Reference for UpdateEnrollmentConfiguration Operation</seealso>
        IAsyncResult BeginUpdateEnrollmentConfiguration(UpdateEnrollmentConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnrollmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnrollmentConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateEnrollmentConfigurationResult from ComputeOptimizerAutomation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-automation-2025-09-22/UpdateEnrollmentConfiguration">REST API Reference for UpdateEnrollmentConfiguration Operation</seealso>
        UpdateEnrollmentConfigurationResponse EndUpdateEnrollmentConfiguration(IAsyncResult asyncResult);

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