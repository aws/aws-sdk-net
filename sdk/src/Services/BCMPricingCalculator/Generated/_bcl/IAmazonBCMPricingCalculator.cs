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
using System.Threading;
using System.Threading.Tasks;
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBCMPricingCalculatorPaginatorFactory Paginators { get; }

        
        #region  BatchCreateBillScenarioCommitmentModification


        /// <summary>
        /// Create Compute Savings Plans, EC2 Instance Savings Plans, or EC2 Reserved Instances
        /// commitments that you want to model in a Bill Scenario. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchCreateBillScenarioCommitmentModification</c> operation doesn't have its
        /// own IAM permission. To authorize this operation for Amazon Web Services principals,
        /// include the permission <c>bcm-pricing-calculator:CreateBillScenarioCommitmentModification</c>
        /// in your policies.
        /// </para>
        ///  </note>
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
        /// Create Compute Savings Plans, EC2 Instance Savings Plans, or EC2 Reserved Instances
        /// commitments that you want to model in a Bill Scenario. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchCreateBillScenarioCommitmentModification</c> operation doesn't have its
        /// own IAM permission. To authorize this operation for Amazon Web Services principals,
        /// include the permission <c>bcm-pricing-calculator:CreateBillScenarioCommitmentModification</c>
        /// in your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateBillScenarioCommitmentModification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchCreateBillScenarioCommitmentModificationResponse> BatchCreateBillScenarioCommitmentModificationAsync(BatchCreateBillScenarioCommitmentModificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchCreateBillScenarioUsageModification


        /// <summary>
        /// Create Amazon Web Services service usage that you want to model in a Bill Scenario.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchCreateBillScenarioUsageModification</c> operation doesn't have its own
        /// IAM permission. To authorize this operation for Amazon Web Services principals, include
        /// the permission <c>bcm-pricing-calculator:CreateBillScenarioUsageModification</c> in
        /// your policies.
        /// </para>
        ///  </note>
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
        /// Create Amazon Web Services service usage that you want to model in a Bill Scenario.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchCreateBillScenarioUsageModification</c> operation doesn't have its own
        /// IAM permission. To authorize this operation for Amazon Web Services principals, include
        /// the permission <c>bcm-pricing-calculator:CreateBillScenarioUsageModification</c> in
        /// your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateBillScenarioUsageModification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchCreateBillScenarioUsageModificationResponse> BatchCreateBillScenarioUsageModificationAsync(BatchCreateBillScenarioUsageModificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchCreateWorkloadEstimateUsage


        /// <summary>
        /// Create Amazon Web Services service usage that you want to model in a Workload Estimate.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchCreateWorkloadEstimateUsage</c> operation doesn't have its own IAM permission.
        /// To authorize this operation for Amazon Web Services principals, include the permission
        /// <c>bcm-pricing-calculator:CreateWorkloadEstimateUsage</c> in your policies.
        /// </para>
        ///  </note>
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
        /// Create Amazon Web Services service usage that you want to model in a Workload Estimate.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchCreateWorkloadEstimateUsage</c> operation doesn't have its own IAM permission.
        /// To authorize this operation for Amazon Web Services principals, include the permission
        /// <c>bcm-pricing-calculator:CreateWorkloadEstimateUsage</c> in your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateWorkloadEstimateUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchCreateWorkloadEstimateUsageResponse> BatchCreateWorkloadEstimateUsageAsync(BatchCreateWorkloadEstimateUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDeleteBillScenarioCommitmentModification


        /// <summary>
        /// Delete commitment that you have created in a Bill Scenario. You can only delete a
        /// commitment that you had added and cannot model deletion (or removal) of a existing
        /// commitment. If you want model deletion of an existing commitment, see the negate <a
        /// href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AWSBCMPricingCalculator_BillScenarioCommitmentModificationAction.html">
        /// BillScenarioCommitmentModificationAction</a> of <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AWSBCMPricingCalculator_BatchCreateBillScenarioUsageModification.html">
        /// BatchCreateBillScenarioCommitmentModification</a> operation. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchDeleteBillScenarioCommitmentModification</c> operation doesn't have its
        /// own IAM permission. To authorize this operation for Amazon Web Services principals,
        /// include the permission <c>bcm-pricing-calculator:DeleteBillScenarioCommitmentModification</c>
        /// in your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBillScenarioCommitmentModification service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteBillScenarioCommitmentModification service method, as returned by BCMPricingCalculator.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteBillScenarioCommitmentModification">REST API Reference for BatchDeleteBillScenarioCommitmentModification Operation</seealso>
        BatchDeleteBillScenarioCommitmentModificationResponse BatchDeleteBillScenarioCommitmentModification(BatchDeleteBillScenarioCommitmentModificationRequest request);



        /// <summary>
        /// Delete commitment that you have created in a Bill Scenario. You can only delete a
        /// commitment that you had added and cannot model deletion (or removal) of a existing
        /// commitment. If you want model deletion of an existing commitment, see the negate <a
        /// href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AWSBCMPricingCalculator_BillScenarioCommitmentModificationAction.html">
        /// BillScenarioCommitmentModificationAction</a> of <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AWSBCMPricingCalculator_BatchCreateBillScenarioUsageModification.html">
        /// BatchCreateBillScenarioCommitmentModification</a> operation. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchDeleteBillScenarioCommitmentModification</c> operation doesn't have its
        /// own IAM permission. To authorize this operation for Amazon Web Services principals,
        /// include the permission <c>bcm-pricing-calculator:DeleteBillScenarioCommitmentModification</c>
        /// in your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBillScenarioCommitmentModification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteBillScenarioCommitmentModification service method, as returned by BCMPricingCalculator.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteBillScenarioCommitmentModification">REST API Reference for BatchDeleteBillScenarioCommitmentModification Operation</seealso>
        Task<BatchDeleteBillScenarioCommitmentModificationResponse> BatchDeleteBillScenarioCommitmentModificationAsync(BatchDeleteBillScenarioCommitmentModificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDeleteBillScenarioUsageModification


        /// <summary>
        /// Delete usage that you have created in a Bill Scenario. You can only delete usage
        /// that you had added and cannot model deletion (or removal) of a existing usage. If
        /// you want model removal of an existing usage, see <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AWSBCMPricingCalculator_BatchUpdateBillScenarioUsageModification.html">
        /// BatchUpdateBillScenarioUsageModification</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchDeleteBillScenarioUsageModification</c> operation doesn't have its own
        /// IAM permission. To authorize this operation for Amazon Web Services principals, include
        /// the permission <c>bcm-pricing-calculator:DeleteBillScenarioUsageModification</c> in
        /// your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBillScenarioUsageModification service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteBillScenarioUsageModification service method, as returned by BCMPricingCalculator.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteBillScenarioUsageModification">REST API Reference for BatchDeleteBillScenarioUsageModification Operation</seealso>
        BatchDeleteBillScenarioUsageModificationResponse BatchDeleteBillScenarioUsageModification(BatchDeleteBillScenarioUsageModificationRequest request);



        /// <summary>
        /// Delete usage that you have created in a Bill Scenario. You can only delete usage
        /// that you had added and cannot model deletion (or removal) of a existing usage. If
        /// you want model removal of an existing usage, see <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AWSBCMPricingCalculator_BatchUpdateBillScenarioUsageModification.html">
        /// BatchUpdateBillScenarioUsageModification</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchDeleteBillScenarioUsageModification</c> operation doesn't have its own
        /// IAM permission. To authorize this operation for Amazon Web Services principals, include
        /// the permission <c>bcm-pricing-calculator:DeleteBillScenarioUsageModification</c> in
        /// your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteBillScenarioUsageModification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteBillScenarioUsageModification service method, as returned by BCMPricingCalculator.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchDeleteBillScenarioUsageModification">REST API Reference for BatchDeleteBillScenarioUsageModification Operation</seealso>
        Task<BatchDeleteBillScenarioUsageModificationResponse> BatchDeleteBillScenarioUsageModificationAsync(BatchDeleteBillScenarioUsageModificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDeleteWorkloadEstimateUsage


        /// <summary>
        /// Delete usage that you have created in a Workload estimate. You can only delete usage
        /// that you had added and cannot model deletion (or removal) of a existing usage. If
        /// you want model removal of an existing usage, see <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AWSBCMPricingCalculator_BatchUpdateWorkloadEstimateUsage.html">
        /// BatchUpdateWorkloadEstimateUsage</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchDeleteWorkloadEstimateUsage</c> operation doesn't have its own IAM permission.
        /// To authorize this operation for Amazon Web Services principals, include the permission
        /// <c>bcm-pricing-calculator:DeleteWorkloadEstimateUsage</c> in your policies.
        /// </para>
        ///  </note>
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
        /// Delete usage that you have created in a Workload estimate. You can only delete usage
        /// that you had added and cannot model deletion (or removal) of a existing usage. If
        /// you want model removal of an existing usage, see <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AWSBCMPricingCalculator_BatchUpdateWorkloadEstimateUsage.html">
        /// BatchUpdateWorkloadEstimateUsage</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchDeleteWorkloadEstimateUsage</c> operation doesn't have its own IAM permission.
        /// To authorize this operation for Amazon Web Services principals, include the permission
        /// <c>bcm-pricing-calculator:DeleteWorkloadEstimateUsage</c> in your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteWorkloadEstimateUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchDeleteWorkloadEstimateUsageResponse> BatchDeleteWorkloadEstimateUsageAsync(BatchDeleteWorkloadEstimateUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchUpdateBillScenarioCommitmentModification


        /// <summary>
        /// Update a newly added or existing commitment. You can update the commitment group
        /// based on a commitment ID and a Bill scenario ID. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchUpdateBillScenarioCommitmentModification</c> operation doesn't have its
        /// own IAM permission. To authorize this operation for Amazon Web Services principals,
        /// include the permission <c>bcm-pricing-calculator:UpdateBillScenarioCommitmentModification</c>
        /// in your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateBillScenarioCommitmentModification service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateBillScenarioCommitmentModification service method, as returned by BCMPricingCalculator.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateBillScenarioCommitmentModification">REST API Reference for BatchUpdateBillScenarioCommitmentModification Operation</seealso>
        BatchUpdateBillScenarioCommitmentModificationResponse BatchUpdateBillScenarioCommitmentModification(BatchUpdateBillScenarioCommitmentModificationRequest request);



        /// <summary>
        /// Update a newly added or existing commitment. You can update the commitment group
        /// based on a commitment ID and a Bill scenario ID. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchUpdateBillScenarioCommitmentModification</c> operation doesn't have its
        /// own IAM permission. To authorize this operation for Amazon Web Services principals,
        /// include the permission <c>bcm-pricing-calculator:UpdateBillScenarioCommitmentModification</c>
        /// in your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateBillScenarioCommitmentModification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateBillScenarioCommitmentModification service method, as returned by BCMPricingCalculator.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateBillScenarioCommitmentModification">REST API Reference for BatchUpdateBillScenarioCommitmentModification Operation</seealso>
        Task<BatchUpdateBillScenarioCommitmentModificationResponse> BatchUpdateBillScenarioCommitmentModificationAsync(BatchUpdateBillScenarioCommitmentModificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchUpdateBillScenarioUsageModification


        /// <summary>
        /// Update a newly added or existing usage lines. You can update the usage amounts, usage
        /// hour, and usage group based on a usage ID and a Bill scenario ID. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchUpdateBillScenarioUsageModification</c> operation doesn't have its own
        /// IAM permission. To authorize this operation for Amazon Web Services principals, include
        /// the permission <c>bcm-pricing-calculator:UpdateBillScenarioUsageModification</c> in
        /// your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateBillScenarioUsageModification service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateBillScenarioUsageModification service method, as returned by BCMPricingCalculator.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateBillScenarioUsageModification">REST API Reference for BatchUpdateBillScenarioUsageModification Operation</seealso>
        BatchUpdateBillScenarioUsageModificationResponse BatchUpdateBillScenarioUsageModification(BatchUpdateBillScenarioUsageModificationRequest request);



        /// <summary>
        /// Update a newly added or existing usage lines. You can update the usage amounts, usage
        /// hour, and usage group based on a usage ID and a Bill scenario ID. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchUpdateBillScenarioUsageModification</c> operation doesn't have its own
        /// IAM permission. To authorize this operation for Amazon Web Services principals, include
        /// the permission <c>bcm-pricing-calculator:UpdateBillScenarioUsageModification</c> in
        /// your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateBillScenarioUsageModification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateBillScenarioUsageModification service method, as returned by BCMPricingCalculator.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/BatchUpdateBillScenarioUsageModification">REST API Reference for BatchUpdateBillScenarioUsageModification Operation</seealso>
        Task<BatchUpdateBillScenarioUsageModificationResponse> BatchUpdateBillScenarioUsageModificationAsync(BatchUpdateBillScenarioUsageModificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchUpdateWorkloadEstimateUsage


        /// <summary>
        /// Update a newly added or existing usage lines. You can update the usage amounts and
        /// usage group based on a usage ID and a Workload estimate ID. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchUpdateWorkloadEstimateUsage</c> operation doesn't have its own IAM permission.
        /// To authorize this operation for Amazon Web Services principals, include the permission
        /// <c>bcm-pricing-calculator:UpdateWorkloadEstimateUsage</c> in your policies.
        /// </para>
        ///  </note>
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
        /// Update a newly added or existing usage lines. You can update the usage amounts and
        /// usage group based on a usage ID and a Workload estimate ID. 
        /// 
        ///  <note> 
        /// <para>
        /// The <c>BatchUpdateWorkloadEstimateUsage</c> operation doesn't have its own IAM permission.
        /// To authorize this operation for Amazon Web Services principals, include the permission
        /// <c>bcm-pricing-calculator:UpdateWorkloadEstimateUsage</c> in your policies.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateWorkloadEstimateUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchUpdateWorkloadEstimateUsageResponse> BatchUpdateWorkloadEstimateUsageAsync(BatchUpdateWorkloadEstimateUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Create a Bill estimate from a Bill scenario. In the Bill scenario you can model usage
        /// addition, usage changes, and usage removal. You can also model commitment addition
        /// and commitment removal. After all changes in a Bill scenario is made satisfactorily,
        /// you can call this API with a Bill scenario ID to generate the Bill estimate. Bill
        /// estimate calculates the pre-tax cost for your consolidated billing family, incorporating
        /// all modeled usage and commitments alongside existing usage and commitments from your
        /// most recent completed anniversary bill, with any applicable discounts applied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBillEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateBillEstimateResponse> CreateBillEstimateAsync(CreateBillEstimateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a new bill scenario to model potential changes to Amazon Web Services usage
        /// and costs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBillScenario service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateBillScenarioResponse> CreateBillScenarioAsync(CreateBillScenarioRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a new workload estimate to model costs for a specific workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkloadEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateWorkloadEstimateResponse> CreateWorkloadEstimateAsync(CreateWorkloadEstimateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes an existing bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteBillEstimateResponse> DeleteBillEstimateAsync(DeleteBillEstimateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteBillScenario">REST API Reference for DeleteBillScenario Operation</seealso>
        DeleteBillScenarioResponse DeleteBillScenario(DeleteBillScenarioRequest request);



        /// <summary>
        /// Deletes an existing bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillScenario service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBillScenario service method, as returned by BCMPricingCalculator.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-pricing-calculator-2024-06-19/DeleteBillScenario">REST API Reference for DeleteBillScenario Operation</seealso>
        Task<DeleteBillScenarioResponse> DeleteBillScenarioAsync(DeleteBillScenarioRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes an existing workload estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkloadEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteWorkloadEstimateResponse> DeleteWorkloadEstimateAsync(DeleteWorkloadEstimateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves details of a specific bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBillEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetBillEstimateResponse> GetBillEstimateAsync(GetBillEstimateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves details of a specific bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBillScenario service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetBillScenarioResponse> GetBillScenarioAsync(GetBillScenarioRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPreferences


        /// <summary>
        /// Retrieves the current preferences for Pricing Calculator.
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
        /// Retrieves the current preferences for Pricing Calculator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetPreferencesResponse> GetPreferencesAsync(GetPreferencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves details of a specific workload estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetWorkloadEstimateResponse> GetWorkloadEstimateAsync(GetWorkloadEstimateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the commitments associated with a bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateCommitments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListBillEstimateCommitmentsResponse> ListBillEstimateCommitmentsAsync(ListBillEstimateCommitmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the input commitment modifications associated with a bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateInputCommitmentModifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListBillEstimateInputCommitmentModificationsResponse> ListBillEstimateInputCommitmentModificationsAsync(ListBillEstimateInputCommitmentModificationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the input usage modifications associated with a bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateInputUsageModifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListBillEstimateInputUsageModificationsResponse> ListBillEstimateInputUsageModificationsAsync(ListBillEstimateInputUsageModificationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the line items associated with a bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimateLineItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListBillEstimateLineItemsResponse> ListBillEstimateLineItemsAsync(ListBillEstimateLineItemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists all bill estimates for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillEstimates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListBillEstimatesResponse> ListBillEstimatesAsync(ListBillEstimatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the commitment modifications associated with a bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillScenarioCommitmentModifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListBillScenarioCommitmentModificationsResponse> ListBillScenarioCommitmentModificationsAsync(ListBillScenarioCommitmentModificationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists all bill scenarios for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillScenarios service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListBillScenariosResponse> ListBillScenariosAsync(ListBillScenariosRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the usage modifications associated with a bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillScenarioUsageModifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListBillScenarioUsageModificationsResponse> ListBillScenarioUsageModificationsAsync(ListBillScenarioUsageModificationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists all tags associated with a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists all workload estimates for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadEstimates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListWorkloadEstimatesResponse> ListWorkloadEstimatesAsync(ListWorkloadEstimatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the usage associated with a workload estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadEstimateUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListWorkloadEstimateUsageResponse> ListWorkloadEstimateUsageAsync(ListWorkloadEstimateUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Adds one or more tags to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes one or more tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates an existing bill estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateBillEstimateResponse> UpdateBillEstimateAsync(UpdateBillEstimateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates an existing bill scenario.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillScenario service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateBillScenarioResponse> UpdateBillScenarioAsync(UpdateBillScenarioRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePreferences


        /// <summary>
        /// Updates the preferences for Pricing Calculator.
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
        /// Updates the preferences for Pricing Calculator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdatePreferencesResponse> UpdatePreferencesAsync(UpdatePreferencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates an existing workload estimate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkloadEstimate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateWorkloadEstimateResponse> UpdateWorkloadEstimateAsync(UpdateWorkloadEstimateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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