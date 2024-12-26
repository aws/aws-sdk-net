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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BCMPricingCalculator.Model;

#pragma warning disable CS1570
namespace Amazon.BCMPricingCalculator
{
    /// <summary>
    /// <para>Interface for accessing BCMPricingCalculator</para>
    ///
    /// You can use the Pricing Calculator API to programmatically create estimates for your
    /// planned cloud use. You can model usage and commitments such as Savings Plans and Reserved
    /// Instances, and generate estimated costs using your discounts and benefit sharing preferences.
    /// 
    /// 
    ///  
    /// <para>
    /// The Pricing Calculator API provides the following endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>https://bcm-pricing-calculator.us-east-1.api.aws</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonBCMPricingCalculator : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBCMPricingCalculatorPaginatorFactory Paginators { get; }
#endif


        
        #region  BatchCreateBillScenarioCommitmentModification


        /// <summary>
        /// Create Compute Savings Plans, EC2 Instance Savings Plans, or EC2 Reserved Instances
        /// commitments that you want to model in a Bill Scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateBillScenarioCommitmentModification service method.</param>
        /// 
        /// <returns>The response from the BatchCreateBillScenarioCommitmentModification service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchCreateBillScenarioCommitmentModification">REST API Reference for BatchCreateBillScenarioCommitmentModification Operation</seealso>
        BatchCreateBillScenarioCommitmentModificationResponse BatchCreateBillScenarioCommitmentModification(BatchCreateBillScenarioCommitmentModificationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateBillScenarioCommitmentModification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateBillScenarioCommitmentModification operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateBillScenarioCommitmentModification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchCreateBillScenarioCommitmentModification">REST API Reference for BatchCreateBillScenarioCommitmentModification Operation</seealso>
        IAsyncResult BeginBatchCreateBillScenarioCommitmentModification(BatchCreateBillScenarioCommitmentModificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateBillScenarioCommitmentModification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateBillScenarioCommitmentModification.</param>
        /// 
        /// <returns>Returns a  BatchCreateBillScenarioCommitmentModificationResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchCreateBillScenarioCommitmentModification">REST API Reference for BatchCreateBillScenarioCommitmentModification Operation</seealso>
        BatchCreateBillScenarioCommitmentModificationResponse EndBatchCreateBillScenarioCommitmentModification(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchCreateBillScenarioUsageModification


        /// <summary>
        /// Create Amazon Web Services service usage that you want to model in a Bill Scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateBillScenarioUsageModification service method.</param>
        /// 
        /// <returns>The response from the BatchCreateBillScenarioUsageModification service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchCreateBillScenarioUsageModification">REST API Reference for BatchCreateBillScenarioUsageModification Operation</seealso>
        BatchCreateBillScenarioUsageModificationResponse BatchCreateBillScenarioUsageModification(BatchCreateBillScenarioUsageModificationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateBillScenarioUsageModification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateBillScenarioUsageModification operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateBillScenarioUsageModification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchCreateBillScenarioUsageModification">REST API Reference for BatchCreateBillScenarioUsageModification Operation</seealso>
        IAsyncResult BeginBatchCreateBillScenarioUsageModification(BatchCreateBillScenarioUsageModificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateBillScenarioUsageModification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateBillScenarioUsageModification.</param>
        /// 
        /// <returns>Returns a  BatchCreateBillScenarioUsageModificationResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchCreateBillScenarioUsageModification">REST API Reference for BatchCreateBillScenarioUsageModification Operation</seealso>
        BatchCreateBillScenarioUsageModificationResponse EndBatchCreateBillScenarioUsageModification(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchCreateWorkloadEstimateUsage


        /// <summary>
        /// Create Amazon Web Services service usage that you want to model in a Workload Estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateWorkloadEstimateUsage service method.</param>
        /// 
        /// <returns>The response from the BatchCreateWorkloadEstimateUsage service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchCreateWorkloadEstimateUsage">REST API Reference for BatchCreateWorkloadEstimateUsage Operation</seealso>
        BatchCreateWorkloadEstimateUsageResponse BatchCreateWorkloadEstimateUsage(BatchCreateWorkloadEstimateUsageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateWorkloadEstimateUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateWorkloadEstimateUsage operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateWorkloadEstimateUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchCreateWorkloadEstimateUsage">REST API Reference for BatchCreateWorkloadEstimateUsage Operation</seealso>
        IAsyncResult BeginBatchCreateWorkloadEstimateUsage(BatchCreateWorkloadEstimateUsageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateWorkloadEstimateUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateWorkloadEstimateUsage.</param>
        /// 
        /// <returns>Returns a  BatchCreateWorkloadEstimateUsageResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchCreateWorkloadEstimateUsage">REST API Reference for BatchCreateWorkloadEstimateUsage Operation</seealso>
        BatchCreateWorkloadEstimateUsageResponse EndBatchCreateWorkloadEstimateUsage(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDeleteBillScenarioCommitmentModification


        /// <summary>
        /// Delete commitment that you have created in a Bill Scenario. You can only delete a
        /// commitment that you had added and cannot model deletion (or removal) of a existing
        /// commitment. If you want model deletion of an existing commitment, see the negate <a
        /// href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AWSBCMPricingCalculator_BillScenarioCommitmentModificationAction.html">
        /// BillScenarioCommitmentModificationAction</a> of <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AWSBCMPricingCalculator_BatchCreateBillScenarioUsageModification.html">
        /// BatchCreateBillScenarioCommitmentModification</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBillScenarioCommitmentModification service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteBillScenarioCommitmentModification service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteBillScenarioCommitmentModification">REST API Reference for BatchDeleteBillScenarioCommitmentModification Operation</seealso>
        BatchDeleteBillScenarioCommitmentModificationResponse BatchDeleteBillScenarioCommitmentModification(BatchDeleteBillScenarioCommitmentModificationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteBillScenarioCommitmentModification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBillScenarioCommitmentModification operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteBillScenarioCommitmentModification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteBillScenarioCommitmentModification">REST API Reference for BatchDeleteBillScenarioCommitmentModification Operation</seealso>
        IAsyncResult BeginBatchDeleteBillScenarioCommitmentModification(BatchDeleteBillScenarioCommitmentModificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteBillScenarioCommitmentModification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteBillScenarioCommitmentModification.</param>
        /// 
        /// <returns>Returns a  BatchDeleteBillScenarioCommitmentModificationResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteBillScenarioCommitmentModification">REST API Reference for BatchDeleteBillScenarioCommitmentModification Operation</seealso>
        BatchDeleteBillScenarioCommitmentModificationResponse EndBatchDeleteBillScenarioCommitmentModification(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDeleteBillScenarioUsageModification


        /// <summary>
        /// Delete usage that you have created in a Bill Scenario. You can only delete usage
        /// that you had added and cannot model deletion (or removal) of a existing usage. If
        /// you want model removal of an existing usage, see <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AWSBCMPricingCalculator_BatchUpdateBillScenarioUsageModification.html">
        /// BatchUpdateBillScenarioUsageModification</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBillScenarioUsageModification service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteBillScenarioUsageModification service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteBillScenarioUsageModification">REST API Reference for BatchDeleteBillScenarioUsageModification Operation</seealso>
        BatchDeleteBillScenarioUsageModificationResponse BatchDeleteBillScenarioUsageModification(BatchDeleteBillScenarioUsageModificationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteBillScenarioUsageModification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBillScenarioUsageModification operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteBillScenarioUsageModification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteBillScenarioUsageModification">REST API Reference for BatchDeleteBillScenarioUsageModification Operation</seealso>
        IAsyncResult BeginBatchDeleteBillScenarioUsageModification(BatchDeleteBillScenarioUsageModificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteBillScenarioUsageModification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteBillScenarioUsageModification.</param>
        /// 
        /// <returns>Returns a  BatchDeleteBillScenarioUsageModificationResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteBillScenarioUsageModification">REST API Reference for BatchDeleteBillScenarioUsageModification Operation</seealso>
        BatchDeleteBillScenarioUsageModificationResponse EndBatchDeleteBillScenarioUsageModification(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDeleteWorkloadEstimateUsage


        /// <summary>
        /// Delete usage that you have created in a Workload estimate. You can only delete usage
        /// that you had added and cannot model deletion (or removal) of a existing usage. If
        /// you want model removal of an existing usage, see <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AWSBCMPricingCalculator_BatchUpdateWorkloadEstimateUsage.html">
        /// BatchUpdateWorkloadEstimateUsage</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteWorkloadEstimateUsage service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteWorkloadEstimateUsage service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteWorkloadEstimateUsage">REST API Reference for BatchDeleteWorkloadEstimateUsage Operation</seealso>
        BatchDeleteWorkloadEstimateUsageResponse BatchDeleteWorkloadEstimateUsage(BatchDeleteWorkloadEstimateUsageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteWorkloadEstimateUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteWorkloadEstimateUsage operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteWorkloadEstimateUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteWorkloadEstimateUsage">REST API Reference for BatchDeleteWorkloadEstimateUsage Operation</seealso>
        IAsyncResult BeginBatchDeleteWorkloadEstimateUsage(BatchDeleteWorkloadEstimateUsageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteWorkloadEstimateUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteWorkloadEstimateUsage.</param>
        /// 
        /// <returns>Returns a  BatchDeleteWorkloadEstimateUsageResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteWorkloadEstimateUsage">REST API Reference for BatchDeleteWorkloadEstimateUsage Operation</seealso>
        BatchDeleteWorkloadEstimateUsageResponse EndBatchDeleteWorkloadEstimateUsage(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchUpdateBillScenarioCommitmentModification


        /// <summary>
        /// Update a newly added or existing commitment. You can update the commitment group
        /// based on a commitment ID and a Bill scenario ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateBillScenarioCommitmentModification service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateBillScenarioCommitmentModification service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateBillScenarioCommitmentModification">REST API Reference for BatchUpdateBillScenarioCommitmentModification Operation</seealso>
        BatchUpdateBillScenarioCommitmentModificationResponse BatchUpdateBillScenarioCommitmentModification(BatchUpdateBillScenarioCommitmentModificationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateBillScenarioCommitmentModification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateBillScenarioCommitmentModification operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateBillScenarioCommitmentModification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateBillScenarioCommitmentModification">REST API Reference for BatchUpdateBillScenarioCommitmentModification Operation</seealso>
        IAsyncResult BeginBatchUpdateBillScenarioCommitmentModification(BatchUpdateBillScenarioCommitmentModificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateBillScenarioCommitmentModification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateBillScenarioCommitmentModification.</param>
        /// 
        /// <returns>Returns a  BatchUpdateBillScenarioCommitmentModificationResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateBillScenarioCommitmentModification">REST API Reference for BatchUpdateBillScenarioCommitmentModification Operation</seealso>
        BatchUpdateBillScenarioCommitmentModificationResponse EndBatchUpdateBillScenarioCommitmentModification(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchUpdateBillScenarioUsageModification


        /// <summary>
        /// Update a newly added or existing usage lines. You can update the usage amounts, usage
        /// hour, and usage group based on a usage ID and a Bill scenario ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateBillScenarioUsageModification service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateBillScenarioUsageModification service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateBillScenarioUsageModification">REST API Reference for BatchUpdateBillScenarioUsageModification Operation</seealso>
        BatchUpdateBillScenarioUsageModificationResponse BatchUpdateBillScenarioUsageModification(BatchUpdateBillScenarioUsageModificationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateBillScenarioUsageModification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateBillScenarioUsageModification operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateBillScenarioUsageModification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateBillScenarioUsageModification">REST API Reference for BatchUpdateBillScenarioUsageModification Operation</seealso>
        IAsyncResult BeginBatchUpdateBillScenarioUsageModification(BatchUpdateBillScenarioUsageModificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateBillScenarioUsageModification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateBillScenarioUsageModification.</param>
        /// 
        /// <returns>Returns a  BatchUpdateBillScenarioUsageModificationResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateBillScenarioUsageModification">REST API Reference for BatchUpdateBillScenarioUsageModification Operation</seealso>
        BatchUpdateBillScenarioUsageModificationResponse EndBatchUpdateBillScenarioUsageModification(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchUpdateWorkloadEstimateUsage


        /// <summary>
        /// Update a newly added or existing usage lines. You can update the usage amounts and
        /// usage group based on a usage ID and a Workload estimate ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateWorkloadEstimateUsage service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateWorkloadEstimateUsage service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateWorkloadEstimateUsage">REST API Reference for BatchUpdateWorkloadEstimateUsage Operation</seealso>
        BatchUpdateWorkloadEstimateUsageResponse BatchUpdateWorkloadEstimateUsage(BatchUpdateWorkloadEstimateUsageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateWorkloadEstimateUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateWorkloadEstimateUsage operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateWorkloadEstimateUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateWorkloadEstimateUsage">REST API Reference for BatchUpdateWorkloadEstimateUsage Operation</seealso>
        IAsyncResult BeginBatchUpdateWorkloadEstimateUsage(BatchUpdateWorkloadEstimateUsageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateWorkloadEstimateUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateWorkloadEstimateUsage.</param>
        /// 
        /// <returns>Returns a  BatchUpdateWorkloadEstimateUsageResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateWorkloadEstimateUsage">REST API Reference for BatchUpdateWorkloadEstimateUsage Operation</seealso>
        BatchUpdateWorkloadEstimateUsageResponse EndBatchUpdateWorkloadEstimateUsage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBillEstimate


        /// <summary>
        /// Create a Bill estimate from a Bill scenario. In the Bill scenario you can model usage
        /// addition, usage changes, and usage removal. You can also model commitment addition
        /// and commitment removal. After all changes in a Bill scenario is made satisfactorily,
        /// you can call this API with a Bill scenario ID to generate the Bill estimate. Bill
        /// estimate calculates the pre-tax cost for your consolidated billing family, incorporating
        /// all modeled usage and commitments alongside existing usage and commitments from your
        /// most recent completed anniversary bill, with any applicable discounts applied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBillEstimate service method.</param>
        /// 
        /// <returns>The response from the CreateBillEstimate service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/CreateBillEstimate">REST API Reference for CreateBillEstimate Operation</seealso>
        CreateBillEstimateResponse CreateBillEstimate(CreateBillEstimateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBillEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBillEstimate operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBillEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/CreateBillEstimate">REST API Reference for CreateBillEstimate Operation</seealso>
        IAsyncResult BeginCreateBillEstimate(CreateBillEstimateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBillEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBillEstimate.</param>
        /// 
        /// <returns>Returns a  CreateBillEstimateResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/CreateBillEstimate">REST API Reference for CreateBillEstimate Operation</seealso>
        CreateBillEstimateResponse EndCreateBillEstimate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBillScenario


        /// <summary>
        /// Creates a new bill scenario to model potential changes to Amazon Web Services usage
        /// and costs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBillScenario service method.</param>
        /// 
        /// <returns>The response from the CreateBillScenario service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/CreateBillScenario">REST API Reference for CreateBillScenario Operation</seealso>
        CreateBillScenarioResponse CreateBillScenario(CreateBillScenarioRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBillScenario operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBillScenario operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBillScenario
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/CreateBillScenario">REST API Reference for CreateBillScenario Operation</seealso>
        IAsyncResult BeginCreateBillScenario(CreateBillScenarioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBillScenario operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBillScenario.</param>
        /// 
        /// <returns>Returns a  CreateBillScenarioResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/CreateBillScenario">REST API Reference for CreateBillScenario Operation</seealso>
        CreateBillScenarioResponse EndCreateBillScenario(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkloadEstimate


        /// <summary>
        /// Creates a new workload estimate to model costs for a specific workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkloadEstimate service method.</param>
        /// 
        /// <returns>The response from the CreateWorkloadEstimate service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/CreateWorkloadEstimate">REST API Reference for CreateWorkloadEstimate Operation</seealso>
        CreateWorkloadEstimateResponse CreateWorkloadEstimate(CreateWorkloadEstimateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkloadEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkloadEstimate operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkloadEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/CreateWorkloadEstimate">REST API Reference for CreateWorkloadEstimate Operation</seealso>
        IAsyncResult BeginCreateWorkloadEstimate(CreateWorkloadEstimateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkloadEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkloadEstimate.</param>
        /// 
        /// <returns>Returns a  CreateWorkloadEstimateResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/CreateWorkloadEstimate">REST API Reference for CreateWorkloadEstimate Operation</seealso>
        CreateWorkloadEstimateResponse EndCreateWorkloadEstimate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBillEstimate


        /// <summary>
        /// Deletes an existing bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillEstimate service method.</param>
        /// 
        /// <returns>The response from the DeleteBillEstimate service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteBillEstimate">REST API Reference for DeleteBillEstimate Operation</seealso>
        DeleteBillEstimateResponse DeleteBillEstimate(DeleteBillEstimateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBillEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillEstimate operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBillEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteBillEstimate">REST API Reference for DeleteBillEstimate Operation</seealso>
        IAsyncResult BeginDeleteBillEstimate(DeleteBillEstimateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBillEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBillEstimate.</param>
        /// 
        /// <returns>Returns a  DeleteBillEstimateResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteBillEstimate">REST API Reference for DeleteBillEstimate Operation</seealso>
        DeleteBillEstimateResponse EndDeleteBillEstimate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBillScenario


        /// <summary>
        /// Deletes an existing bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillScenario service method.</param>
        /// 
        /// <returns>The response from the DeleteBillScenario service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteBillScenario">REST API Reference for DeleteBillScenario Operation</seealso>
        DeleteBillScenarioResponse DeleteBillScenario(DeleteBillScenarioRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBillScenario operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillScenario operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBillScenario
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteBillScenario">REST API Reference for DeleteBillScenario Operation</seealso>
        IAsyncResult BeginDeleteBillScenario(DeleteBillScenarioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBillScenario operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBillScenario.</param>
        /// 
        /// <returns>Returns a  DeleteBillScenarioResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteBillScenario">REST API Reference for DeleteBillScenario Operation</seealso>
        DeleteBillScenarioResponse EndDeleteBillScenario(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkloadEstimate


        /// <summary>
        /// Deletes an existing workload estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkloadEstimate service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkloadEstimate service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteWorkloadEstimate">REST API Reference for DeleteWorkloadEstimate Operation</seealso>
        DeleteWorkloadEstimateResponse DeleteWorkloadEstimate(DeleteWorkloadEstimateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkloadEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkloadEstimate operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkloadEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteWorkloadEstimate">REST API Reference for DeleteWorkloadEstimate Operation</seealso>
        IAsyncResult BeginDeleteWorkloadEstimate(DeleteWorkloadEstimateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkloadEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkloadEstimate.</param>
        /// 
        /// <returns>Returns a  DeleteWorkloadEstimateResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteWorkloadEstimate">REST API Reference for DeleteWorkloadEstimate Operation</seealso>
        DeleteWorkloadEstimateResponse EndDeleteWorkloadEstimate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBillEstimate


        /// <summary>
        /// Retrieves details of a specific bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBillEstimate service method.</param>
        /// 
        /// <returns>The response from the GetBillEstimate service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetBillEstimate">REST API Reference for GetBillEstimate Operation</seealso>
        GetBillEstimateResponse GetBillEstimate(GetBillEstimateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBillEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBillEstimate operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBillEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetBillEstimate">REST API Reference for GetBillEstimate Operation</seealso>
        IAsyncResult BeginGetBillEstimate(GetBillEstimateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBillEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBillEstimate.</param>
        /// 
        /// <returns>Returns a  GetBillEstimateResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetBillEstimate">REST API Reference for GetBillEstimate Operation</seealso>
        GetBillEstimateResponse EndGetBillEstimate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBillScenario


        /// <summary>
        /// Retrieves details of a specific bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBillScenario service method.</param>
        /// 
        /// <returns>The response from the GetBillScenario service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetBillScenario">REST API Reference for GetBillScenario Operation</seealso>
        GetBillScenarioResponse GetBillScenario(GetBillScenarioRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBillScenario operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBillScenario operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBillScenario
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetBillScenario">REST API Reference for GetBillScenario Operation</seealso>
        IAsyncResult BeginGetBillScenario(GetBillScenarioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBillScenario operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBillScenario.</param>
        /// 
        /// <returns>Returns a  GetBillScenarioResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetBillScenario">REST API Reference for GetBillScenario Operation</seealso>
        GetBillScenarioResponse EndGetBillScenario(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPreferences


        /// <summary>
        /// Retrieves the current preferences for the Amazon Web Services Cost Explorer service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPreferences service method.</param>
        /// 
        /// <returns>The response from the GetPreferences service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetPreferences">REST API Reference for GetPreferences Operation</seealso>
        GetPreferencesResponse GetPreferences(GetPreferencesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPreferences operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetPreferences">REST API Reference for GetPreferences Operation</seealso>
        IAsyncResult BeginGetPreferences(GetPreferencesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPreferences.</param>
        /// 
        /// <returns>Returns a  GetPreferencesResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetPreferences">REST API Reference for GetPreferences Operation</seealso>
        GetPreferencesResponse EndGetPreferences(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkloadEstimate


        /// <summary>
        /// Retrieves details of a specific workload estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadEstimate service method.</param>
        /// 
        /// <returns>The response from the GetWorkloadEstimate service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetWorkloadEstimate">REST API Reference for GetWorkloadEstimate Operation</seealso>
        GetWorkloadEstimateResponse GetWorkloadEstimate(GetWorkloadEstimateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkloadEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadEstimate operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkloadEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetWorkloadEstimate">REST API Reference for GetWorkloadEstimate Operation</seealso>
        IAsyncResult BeginGetWorkloadEstimate(GetWorkloadEstimateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkloadEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkloadEstimate.</param>
        /// 
        /// <returns>Returns a  GetWorkloadEstimateResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/GetWorkloadEstimate">REST API Reference for GetWorkloadEstimate Operation</seealso>
        GetWorkloadEstimateResponse EndGetWorkloadEstimate(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBillEstimateCommitments


        /// <summary>
        /// Lists the commitments associated with a bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateCommitments service method.</param>
        /// 
        /// <returns>The response from the ListBillEstimateCommitments service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateCommitments">REST API Reference for ListBillEstimateCommitments Operation</seealso>
        ListBillEstimateCommitmentsResponse ListBillEstimateCommitments(ListBillEstimateCommitmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillEstimateCommitments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateCommitments operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillEstimateCommitments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateCommitments">REST API Reference for ListBillEstimateCommitments Operation</seealso>
        IAsyncResult BeginListBillEstimateCommitments(ListBillEstimateCommitmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillEstimateCommitments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillEstimateCommitments.</param>
        /// 
        /// <returns>Returns a  ListBillEstimateCommitmentsResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateCommitments">REST API Reference for ListBillEstimateCommitments Operation</seealso>
        ListBillEstimateCommitmentsResponse EndListBillEstimateCommitments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBillEstimateInputCommitmentModifications


        /// <summary>
        /// Lists the input commitment modifications associated with a bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateInputCommitmentModifications service method.</param>
        /// 
        /// <returns>The response from the ListBillEstimateInputCommitmentModifications service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateInputCommitmentModifications">REST API Reference for ListBillEstimateInputCommitmentModifications Operation</seealso>
        ListBillEstimateInputCommitmentModificationsResponse ListBillEstimateInputCommitmentModifications(ListBillEstimateInputCommitmentModificationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillEstimateInputCommitmentModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateInputCommitmentModifications operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillEstimateInputCommitmentModifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateInputCommitmentModifications">REST API Reference for ListBillEstimateInputCommitmentModifications Operation</seealso>
        IAsyncResult BeginListBillEstimateInputCommitmentModifications(ListBillEstimateInputCommitmentModificationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillEstimateInputCommitmentModifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillEstimateInputCommitmentModifications.</param>
        /// 
        /// <returns>Returns a  ListBillEstimateInputCommitmentModificationsResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateInputCommitmentModifications">REST API Reference for ListBillEstimateInputCommitmentModifications Operation</seealso>
        ListBillEstimateInputCommitmentModificationsResponse EndListBillEstimateInputCommitmentModifications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBillEstimateInputUsageModifications


        /// <summary>
        /// Lists the input usage modifications associated with a bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateInputUsageModifications service method.</param>
        /// 
        /// <returns>The response from the ListBillEstimateInputUsageModifications service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateInputUsageModifications">REST API Reference for ListBillEstimateInputUsageModifications Operation</seealso>
        ListBillEstimateInputUsageModificationsResponse ListBillEstimateInputUsageModifications(ListBillEstimateInputUsageModificationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillEstimateInputUsageModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateInputUsageModifications operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillEstimateInputUsageModifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateInputUsageModifications">REST API Reference for ListBillEstimateInputUsageModifications Operation</seealso>
        IAsyncResult BeginListBillEstimateInputUsageModifications(ListBillEstimateInputUsageModificationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillEstimateInputUsageModifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillEstimateInputUsageModifications.</param>
        /// 
        /// <returns>Returns a  ListBillEstimateInputUsageModificationsResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateInputUsageModifications">REST API Reference for ListBillEstimateInputUsageModifications Operation</seealso>
        ListBillEstimateInputUsageModificationsResponse EndListBillEstimateInputUsageModifications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBillEstimateLineItems


        /// <summary>
        /// Lists the line items associated with a bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateLineItems service method.</param>
        /// 
        /// <returns>The response from the ListBillEstimateLineItems service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateLineItems">REST API Reference for ListBillEstimateLineItems Operation</seealso>
        ListBillEstimateLineItemsResponse ListBillEstimateLineItems(ListBillEstimateLineItemsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillEstimateLineItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateLineItems operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillEstimateLineItems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateLineItems">REST API Reference for ListBillEstimateLineItems Operation</seealso>
        IAsyncResult BeginListBillEstimateLineItems(ListBillEstimateLineItemsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillEstimateLineItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillEstimateLineItems.</param>
        /// 
        /// <returns>Returns a  ListBillEstimateLineItemsResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimateLineItems">REST API Reference for ListBillEstimateLineItems Operation</seealso>
        ListBillEstimateLineItemsResponse EndListBillEstimateLineItems(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBillEstimates


        /// <summary>
        /// Lists all bill estimates for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimates service method.</param>
        /// 
        /// <returns>The response from the ListBillEstimates service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimates">REST API Reference for ListBillEstimates Operation</seealso>
        ListBillEstimatesResponse ListBillEstimates(ListBillEstimatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillEstimates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimates operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillEstimates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimates">REST API Reference for ListBillEstimates Operation</seealso>
        IAsyncResult BeginListBillEstimates(ListBillEstimatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillEstimates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillEstimates.</param>
        /// 
        /// <returns>Returns a  ListBillEstimatesResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillEstimates">REST API Reference for ListBillEstimates Operation</seealso>
        ListBillEstimatesResponse EndListBillEstimates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBillScenarioCommitmentModifications


        /// <summary>
        /// Lists the commitment modifications associated with a bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillScenarioCommitmentModifications service method.</param>
        /// 
        /// <returns>The response from the ListBillScenarioCommitmentModifications service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillScenarioCommitmentModifications">REST API Reference for ListBillScenarioCommitmentModifications Operation</seealso>
        ListBillScenarioCommitmentModificationsResponse ListBillScenarioCommitmentModifications(ListBillScenarioCommitmentModificationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillScenarioCommitmentModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillScenarioCommitmentModifications operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillScenarioCommitmentModifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillScenarioCommitmentModifications">REST API Reference for ListBillScenarioCommitmentModifications Operation</seealso>
        IAsyncResult BeginListBillScenarioCommitmentModifications(ListBillScenarioCommitmentModificationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillScenarioCommitmentModifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillScenarioCommitmentModifications.</param>
        /// 
        /// <returns>Returns a  ListBillScenarioCommitmentModificationsResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillScenarioCommitmentModifications">REST API Reference for ListBillScenarioCommitmentModifications Operation</seealso>
        ListBillScenarioCommitmentModificationsResponse EndListBillScenarioCommitmentModifications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBillScenarios


        /// <summary>
        /// Lists all bill scenarios for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillScenarios service method.</param>
        /// 
        /// <returns>The response from the ListBillScenarios service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillScenarios">REST API Reference for ListBillScenarios Operation</seealso>
        ListBillScenariosResponse ListBillScenarios(ListBillScenariosRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillScenarios operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillScenarios operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillScenarios
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillScenarios">REST API Reference for ListBillScenarios Operation</seealso>
        IAsyncResult BeginListBillScenarios(ListBillScenariosRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillScenarios operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillScenarios.</param>
        /// 
        /// <returns>Returns a  ListBillScenariosResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillScenarios">REST API Reference for ListBillScenarios Operation</seealso>
        ListBillScenariosResponse EndListBillScenarios(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBillScenarioUsageModifications


        /// <summary>
        /// Lists the usage modifications associated with a bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillScenarioUsageModifications service method.</param>
        /// 
        /// <returns>The response from the ListBillScenarioUsageModifications service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillScenarioUsageModifications">REST API Reference for ListBillScenarioUsageModifications Operation</seealso>
        ListBillScenarioUsageModificationsResponse ListBillScenarioUsageModifications(ListBillScenarioUsageModificationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillScenarioUsageModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillScenarioUsageModifications operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillScenarioUsageModifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillScenarioUsageModifications">REST API Reference for ListBillScenarioUsageModifications Operation</seealso>
        IAsyncResult BeginListBillScenarioUsageModifications(ListBillScenarioUsageModificationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillScenarioUsageModifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillScenarioUsageModifications.</param>
        /// 
        /// <returns>Returns a  ListBillScenarioUsageModificationsResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListBillScenarioUsageModifications">REST API Reference for ListBillScenarioUsageModifications Operation</seealso>
        ListBillScenarioUsageModificationsResponse EndListBillScenarioUsageModifications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags associated with a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkloadEstimates


        /// <summary>
        /// Lists all workload estimates for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadEstimates service method.</param>
        /// 
        /// <returns>The response from the ListWorkloadEstimates service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListWorkloadEstimates">REST API Reference for ListWorkloadEstimates Operation</seealso>
        ListWorkloadEstimatesResponse ListWorkloadEstimates(ListWorkloadEstimatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkloadEstimates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadEstimates operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkloadEstimates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListWorkloadEstimates">REST API Reference for ListWorkloadEstimates Operation</seealso>
        IAsyncResult BeginListWorkloadEstimates(ListWorkloadEstimatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkloadEstimates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkloadEstimates.</param>
        /// 
        /// <returns>Returns a  ListWorkloadEstimatesResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListWorkloadEstimates">REST API Reference for ListWorkloadEstimates Operation</seealso>
        ListWorkloadEstimatesResponse EndListWorkloadEstimates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkloadEstimateUsage


        /// <summary>
        /// Lists the usage associated with a workload estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadEstimateUsage service method.</param>
        /// 
        /// <returns>The response from the ListWorkloadEstimateUsage service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListWorkloadEstimateUsage">REST API Reference for ListWorkloadEstimateUsage Operation</seealso>
        ListWorkloadEstimateUsageResponse ListWorkloadEstimateUsage(ListWorkloadEstimateUsageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkloadEstimateUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadEstimateUsage operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkloadEstimateUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListWorkloadEstimateUsage">REST API Reference for ListWorkloadEstimateUsage Operation</seealso>
        IAsyncResult BeginListWorkloadEstimateUsage(ListWorkloadEstimateUsageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkloadEstimateUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkloadEstimateUsage.</param>
        /// 
        /// <returns>Returns a  ListWorkloadEstimateUsageResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/ListWorkloadEstimateUsage">REST API Reference for ListWorkloadEstimateUsage Operation</seealso>
        ListWorkloadEstimateUsageResponse EndListWorkloadEstimateUsage(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBillEstimate


        /// <summary>
        /// Updates an existing bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillEstimate service method.</param>
        /// 
        /// <returns>The response from the UpdateBillEstimate service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdateBillEstimate">REST API Reference for UpdateBillEstimate Operation</seealso>
        UpdateBillEstimateResponse UpdateBillEstimate(UpdateBillEstimateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBillEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillEstimate operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBillEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdateBillEstimate">REST API Reference for UpdateBillEstimate Operation</seealso>
        IAsyncResult BeginUpdateBillEstimate(UpdateBillEstimateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBillEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBillEstimate.</param>
        /// 
        /// <returns>Returns a  UpdateBillEstimateResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdateBillEstimate">REST API Reference for UpdateBillEstimate Operation</seealso>
        UpdateBillEstimateResponse EndUpdateBillEstimate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBillScenario


        /// <summary>
        /// Updates an existing bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillScenario service method.</param>
        /// 
        /// <returns>The response from the UpdateBillScenario service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdateBillScenario">REST API Reference for UpdateBillScenario Operation</seealso>
        UpdateBillScenarioResponse UpdateBillScenario(UpdateBillScenarioRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBillScenario operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillScenario operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBillScenario
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdateBillScenario">REST API Reference for UpdateBillScenario Operation</seealso>
        IAsyncResult BeginUpdateBillScenario(UpdateBillScenarioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBillScenario operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBillScenario.</param>
        /// 
        /// <returns>Returns a  UpdateBillScenarioResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdateBillScenario">REST API Reference for UpdateBillScenario Operation</seealso>
        UpdateBillScenarioResponse EndUpdateBillScenario(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePreferences


        /// <summary>
        /// Updates the preferences for the Amazon Web Services Cost Explorer service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePreferences service method.</param>
        /// 
        /// <returns>The response from the UpdatePreferences service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ServiceQuotaExceededException">
        /// The request would cause you to exceed your service quota.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdatePreferences">REST API Reference for UpdatePreferences Operation</seealso>
        UpdatePreferencesResponse UpdatePreferences(UpdatePreferencesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePreferences operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdatePreferences">REST API Reference for UpdatePreferences Operation</seealso>
        IAsyncResult BeginUpdatePreferences(UpdatePreferencesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePreferences.</param>
        /// 
        /// <returns>Returns a  UpdatePreferencesResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdatePreferences">REST API Reference for UpdatePreferences Operation</seealso>
        UpdatePreferencesResponse EndUpdatePreferences(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorkloadEstimate


        /// <summary>
        /// Updates an existing workload estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkloadEstimate service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkloadEstimate service method, as returned by BCMPricingCalculator.</returns>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.DataUnavailableException">
        /// The requested data is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.InternalServerException">
        /// An internal error has occurred. Retry your request, but if the problem persists,
        /// contact Amazon Web Services support.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BCMPricingCalculator.Model.ValidationException">
        /// The input provided fails to satisfy the constraints specified by an Amazon Web Services
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdateWorkloadEstimate">REST API Reference for UpdateWorkloadEstimate Operation</seealso>
        UpdateWorkloadEstimateResponse UpdateWorkloadEstimate(UpdateWorkloadEstimateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkloadEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkloadEstimate operation on AmazonBCMPricingCalculatorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkloadEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdateWorkloadEstimate">REST API Reference for UpdateWorkloadEstimate Operation</seealso>
        IAsyncResult BeginUpdateWorkloadEstimate(UpdateWorkloadEstimateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkloadEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkloadEstimate.</param>
        /// 
        /// <returns>Returns a  UpdateWorkloadEstimateResult from BCMPricingCalculator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/UpdateWorkloadEstimate">REST API Reference for UpdateWorkloadEstimate Operation</seealso>
        UpdateWorkloadEstimateResponse EndUpdateWorkloadEstimate(IAsyncResult asyncResult);

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