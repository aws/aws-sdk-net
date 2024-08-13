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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BillingConductor.Model;

#pragma warning disable CS1570
namespace Amazon.BillingConductor
{
    /// <summary>
    /// <para>Interface for accessing BillingConductor</para>
    ///
    /// Amazon Web Services Billing Conductor is a fully managed service that you can use
    /// to customize a <a href="https://docs.aws.amazon.com/billingconductor/latest/userguide/understanding-eb.html#eb-other-definitions">proforma</a>
    /// version of your billing data each month, to accurately show or chargeback your end
    /// customers. Amazon Web Services Billing Conductor doesn't change the way you're billed
    /// by Amazon Web Services each month by design. Instead, it provides you with a mechanism
    /// to configure, generate, and display rates to certain customers over a given billing
    /// period. You can also analyze the difference between the rates you apply to your accounting
    /// groupings relative to your actual rates from Amazon Web Services. As a result of your
    /// Amazon Web Services Billing Conductor configuration, the payer account can also see
    /// the custom rate applied on the billing details page of the <a href="https://console.aws.amazon.com/billing">Amazon
    /// Web Services Billing console</a>, or configure a cost and usage report per billing
    /// group.
    /// 
    ///  
    /// <para>
    /// This documentation shows how you can configure Amazon Web Services Billing Conductor
    /// using its API. For more information about using the <a href="https://console.aws.amazon.com/billingconductor/">Amazon
    /// Web Services Billing Conductor</a> user interface, see the <a href="https://docs.aws.amazon.com/billingconductor/latest/userguide/what-is-billingconductor.html">
    /// Amazon Web Services Billing Conductor User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonBillingConductor : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBillingConductorPaginatorFactory Paginators { get; }

        
        #region  AssociateAccounts


        /// <summary>
        /// Connects an array of account IDs in a consolidated billing family to a predefined
        /// billing group. The account IDs must be a part of the consolidated billing family during
        /// the current month, and not already associated with another billing group. The maximum
        /// number of accounts that can be associated in one call is 30.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAccounts service method.</param>
        /// 
        /// <returns>The response from the AssociateAccounts service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ServiceLimitExceededException">
        /// The request would cause a service limit to exceed.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/AssociateAccounts">REST API Reference for AssociateAccounts Operation</seealso>
        AssociateAccountsResponse AssociateAccounts(AssociateAccountsRequest request);



        /// <summary>
        /// Connects an array of account IDs in a consolidated billing family to a predefined
        /// billing group. The account IDs must be a part of the consolidated billing family during
        /// the current month, and not already associated with another billing group. The maximum
        /// number of accounts that can be associated in one call is 30.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAccounts service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ServiceLimitExceededException">
        /// The request would cause a service limit to exceed.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/AssociateAccounts">REST API Reference for AssociateAccounts Operation</seealso>
        Task<AssociateAccountsResponse> AssociateAccountsAsync(AssociateAccountsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociatePricingRules


        /// <summary>
        /// Connects an array of <c>PricingRuleArns</c> to a defined <c>PricingPlan</c>. The maximum
        /// number <c>PricingRuleArn</c> that can be associated in one call is 30.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePricingRules service method.</param>
        /// 
        /// <returns>The response from the AssociatePricingRules service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ServiceLimitExceededException">
        /// The request would cause a service limit to exceed.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/AssociatePricingRules">REST API Reference for AssociatePricingRules Operation</seealso>
        AssociatePricingRulesResponse AssociatePricingRules(AssociatePricingRulesRequest request);



        /// <summary>
        /// Connects an array of <c>PricingRuleArns</c> to a defined <c>PricingPlan</c>. The maximum
        /// number <c>PricingRuleArn</c> that can be associated in one call is 30.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePricingRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociatePricingRules service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ServiceLimitExceededException">
        /// The request would cause a service limit to exceed.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/AssociatePricingRules">REST API Reference for AssociatePricingRules Operation</seealso>
        Task<AssociatePricingRulesResponse> AssociatePricingRulesAsync(AssociatePricingRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchAssociateResourcesToCustomLineItem


        /// <summary>
        /// Associates a batch of resources to a percentage custom line item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateResourcesToCustomLineItem service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateResourcesToCustomLineItem service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ServiceLimitExceededException">
        /// The request would cause a service limit to exceed.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/BatchAssociateResourcesToCustomLineItem">REST API Reference for BatchAssociateResourcesToCustomLineItem Operation</seealso>
        BatchAssociateResourcesToCustomLineItemResponse BatchAssociateResourcesToCustomLineItem(BatchAssociateResourcesToCustomLineItemRequest request);



        /// <summary>
        /// Associates a batch of resources to a percentage custom line item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateResourcesToCustomLineItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchAssociateResourcesToCustomLineItem service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ServiceLimitExceededException">
        /// The request would cause a service limit to exceed.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/BatchAssociateResourcesToCustomLineItem">REST API Reference for BatchAssociateResourcesToCustomLineItem Operation</seealso>
        Task<BatchAssociateResourcesToCustomLineItemResponse> BatchAssociateResourcesToCustomLineItemAsync(BatchAssociateResourcesToCustomLineItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDisassociateResourcesFromCustomLineItem


        /// <summary>
        /// Disassociates a batch of resources from a percentage custom line item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateResourcesFromCustomLineItem service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateResourcesFromCustomLineItem service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/BatchDisassociateResourcesFromCustomLineItem">REST API Reference for BatchDisassociateResourcesFromCustomLineItem Operation</seealso>
        BatchDisassociateResourcesFromCustomLineItemResponse BatchDisassociateResourcesFromCustomLineItem(BatchDisassociateResourcesFromCustomLineItemRequest request);



        /// <summary>
        /// Disassociates a batch of resources from a percentage custom line item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateResourcesFromCustomLineItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDisassociateResourcesFromCustomLineItem service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/BatchDisassociateResourcesFromCustomLineItem">REST API Reference for BatchDisassociateResourcesFromCustomLineItem Operation</seealso>
        Task<BatchDisassociateResourcesFromCustomLineItemResponse> BatchDisassociateResourcesFromCustomLineItemAsync(BatchDisassociateResourcesFromCustomLineItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateBillingGroup


        /// <summary>
        /// Creates a billing group that resembles a consolidated billing family that Amazon
        /// Web Services charges, based off of the predefined pricing plan computation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBillingGroup service method.</param>
        /// 
        /// <returns>The response from the CreateBillingGroup service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ServiceLimitExceededException">
        /// The request would cause a service limit to exceed.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreateBillingGroup">REST API Reference for CreateBillingGroup Operation</seealso>
        CreateBillingGroupResponse CreateBillingGroup(CreateBillingGroupRequest request);



        /// <summary>
        /// Creates a billing group that resembles a consolidated billing family that Amazon
        /// Web Services charges, based off of the predefined pricing plan computation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBillingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBillingGroup service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ServiceLimitExceededException">
        /// The request would cause a service limit to exceed.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreateBillingGroup">REST API Reference for CreateBillingGroup Operation</seealso>
        Task<CreateBillingGroupResponse> CreateBillingGroupAsync(CreateBillingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCustomLineItem


        /// <summary>
        /// Creates a custom line item that can be used to create a one-time fixed charge that
        /// can be applied to a single billing group for the current or previous billing period.
        /// The one-time fixed charge is either a fee or discount.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomLineItem service method.</param>
        /// 
        /// <returns>The response from the CreateCustomLineItem service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ServiceLimitExceededException">
        /// The request would cause a service limit to exceed.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreateCustomLineItem">REST API Reference for CreateCustomLineItem Operation</seealso>
        CreateCustomLineItemResponse CreateCustomLineItem(CreateCustomLineItemRequest request);



        /// <summary>
        /// Creates a custom line item that can be used to create a one-time fixed charge that
        /// can be applied to a single billing group for the current or previous billing period.
        /// The one-time fixed charge is either a fee or discount.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomLineItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomLineItem service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ServiceLimitExceededException">
        /// The request would cause a service limit to exceed.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreateCustomLineItem">REST API Reference for CreateCustomLineItem Operation</seealso>
        Task<CreateCustomLineItemResponse> CreateCustomLineItemAsync(CreateCustomLineItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePricingPlan


        /// <summary>
        /// Creates a pricing plan that is used for computing Amazon Web Services charges for
        /// billing groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePricingPlan service method.</param>
        /// 
        /// <returns>The response from the CreatePricingPlan service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ServiceLimitExceededException">
        /// The request would cause a service limit to exceed.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreatePricingPlan">REST API Reference for CreatePricingPlan Operation</seealso>
        CreatePricingPlanResponse CreatePricingPlan(CreatePricingPlanRequest request);



        /// <summary>
        /// Creates a pricing plan that is used for computing Amazon Web Services charges for
        /// billing groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePricingPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePricingPlan service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ServiceLimitExceededException">
        /// The request would cause a service limit to exceed.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreatePricingPlan">REST API Reference for CreatePricingPlan Operation</seealso>
        Task<CreatePricingPlanResponse> CreatePricingPlanAsync(CreatePricingPlanRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePricingRule


        /// <summary>
        /// Creates a pricing rule can be associated to a pricing plan, or a set of pricing plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePricingRule service method.</param>
        /// 
        /// <returns>The response from the CreatePricingRule service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ServiceLimitExceededException">
        /// The request would cause a service limit to exceed.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreatePricingRule">REST API Reference for CreatePricingRule Operation</seealso>
        CreatePricingRuleResponse CreatePricingRule(CreatePricingRuleRequest request);



        /// <summary>
        /// Creates a pricing rule can be associated to a pricing plan, or a set of pricing plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePricingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePricingRule service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ServiceLimitExceededException">
        /// The request would cause a service limit to exceed.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreatePricingRule">REST API Reference for CreatePricingRule Operation</seealso>
        Task<CreatePricingRuleResponse> CreatePricingRuleAsync(CreatePricingRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBillingGroup


        /// <summary>
        /// Deletes a billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillingGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteBillingGroup service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeleteBillingGroup">REST API Reference for DeleteBillingGroup Operation</seealso>
        DeleteBillingGroupResponse DeleteBillingGroup(DeleteBillingGroupRequest request);



        /// <summary>
        /// Deletes a billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBillingGroup service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeleteBillingGroup">REST API Reference for DeleteBillingGroup Operation</seealso>
        Task<DeleteBillingGroupResponse> DeleteBillingGroupAsync(DeleteBillingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCustomLineItem


        /// <summary>
        /// Deletes the custom line item identified by the given ARN in the current, or previous
        /// billing period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomLineItem service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomLineItem service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeleteCustomLineItem">REST API Reference for DeleteCustomLineItem Operation</seealso>
        DeleteCustomLineItemResponse DeleteCustomLineItem(DeleteCustomLineItemRequest request);



        /// <summary>
        /// Deletes the custom line item identified by the given ARN in the current, or previous
        /// billing period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomLineItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomLineItem service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeleteCustomLineItem">REST API Reference for DeleteCustomLineItem Operation</seealso>
        Task<DeleteCustomLineItemResponse> DeleteCustomLineItemAsync(DeleteCustomLineItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePricingPlan


        /// <summary>
        /// Deletes a pricing plan. The pricing plan must not be associated with any billing groups
        /// to delete successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePricingPlan service method.</param>
        /// 
        /// <returns>The response from the DeletePricingPlan service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeletePricingPlan">REST API Reference for DeletePricingPlan Operation</seealso>
        DeletePricingPlanResponse DeletePricingPlan(DeletePricingPlanRequest request);



        /// <summary>
        /// Deletes a pricing plan. The pricing plan must not be associated with any billing groups
        /// to delete successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePricingPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePricingPlan service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeletePricingPlan">REST API Reference for DeletePricingPlan Operation</seealso>
        Task<DeletePricingPlanResponse> DeletePricingPlanAsync(DeletePricingPlanRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePricingRule


        /// <summary>
        /// Deletes the pricing rule that's identified by the input Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePricingRule service method.</param>
        /// 
        /// <returns>The response from the DeletePricingRule service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeletePricingRule">REST API Reference for DeletePricingRule Operation</seealso>
        DeletePricingRuleResponse DeletePricingRule(DeletePricingRuleRequest request);



        /// <summary>
        /// Deletes the pricing rule that's identified by the input Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePricingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePricingRule service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeletePricingRule">REST API Reference for DeletePricingRule Operation</seealso>
        Task<DeletePricingRuleResponse> DeletePricingRuleAsync(DeletePricingRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateAccounts


        /// <summary>
        /// Removes the specified list of account IDs from the given billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAccounts service method.</param>
        /// 
        /// <returns>The response from the DisassociateAccounts service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DisassociateAccounts">REST API Reference for DisassociateAccounts Operation</seealso>
        DisassociateAccountsResponse DisassociateAccounts(DisassociateAccountsRequest request);



        /// <summary>
        /// Removes the specified list of account IDs from the given billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateAccounts service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DisassociateAccounts">REST API Reference for DisassociateAccounts Operation</seealso>
        Task<DisassociateAccountsResponse> DisassociateAccountsAsync(DisassociateAccountsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociatePricingRules


        /// <summary>
        /// Disassociates a list of pricing rules from a pricing plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePricingRules service method.</param>
        /// 
        /// <returns>The response from the DisassociatePricingRules service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DisassociatePricingRules">REST API Reference for DisassociatePricingRules Operation</seealso>
        DisassociatePricingRulesResponse DisassociatePricingRules(DisassociatePricingRulesRequest request);



        /// <summary>
        /// Disassociates a list of pricing rules from a pricing plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePricingRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociatePricingRules service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DisassociatePricingRules">REST API Reference for DisassociatePricingRules Operation</seealso>
        Task<DisassociatePricingRulesResponse> DisassociatePricingRulesAsync(DisassociatePricingRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBillingGroupCostReport


        /// <summary>
        /// Retrieves the margin summary report, which includes the Amazon Web Services cost and
        /// charged amount (pro forma cost) by Amazon Web Service for a specific billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBillingGroupCostReport service method.</param>
        /// 
        /// <returns>The response from the GetBillingGroupCostReport service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/GetBillingGroupCostReport">REST API Reference for GetBillingGroupCostReport Operation</seealso>
        GetBillingGroupCostReportResponse GetBillingGroupCostReport(GetBillingGroupCostReportRequest request);



        /// <summary>
        /// Retrieves the margin summary report, which includes the Amazon Web Services cost and
        /// charged amount (pro forma cost) by Amazon Web Service for a specific billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBillingGroupCostReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBillingGroupCostReport service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/GetBillingGroupCostReport">REST API Reference for GetBillingGroupCostReport Operation</seealso>
        Task<GetBillingGroupCostReportResponse> GetBillingGroupCostReportAsync(GetBillingGroupCostReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAccountAssociations


        /// <summary>
        /// This is a paginated call to list linked accounts that are linked to the payer account
        /// for the specified time period. If no information is provided, the current billing
        /// period is used. The response will optionally include the billing group that's associated
        /// with the linked account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssociations service method.</param>
        /// 
        /// <returns>The response from the ListAccountAssociations service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListAccountAssociations">REST API Reference for ListAccountAssociations Operation</seealso>
        ListAccountAssociationsResponse ListAccountAssociations(ListAccountAssociationsRequest request);



        /// <summary>
        /// This is a paginated call to list linked accounts that are linked to the payer account
        /// for the specified time period. If no information is provided, the current billing
        /// period is used. The response will optionally include the billing group that's associated
        /// with the linked account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountAssociations service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListAccountAssociations">REST API Reference for ListAccountAssociations Operation</seealso>
        Task<ListAccountAssociationsResponse> ListAccountAssociationsAsync(ListAccountAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBillingGroupCostReports


        /// <summary>
        /// A paginated call to retrieve a summary report of actual Amazon Web Services charges
        /// and the calculated Amazon Web Services charges based on the associated pricing plan
        /// of a billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillingGroupCostReports service method.</param>
        /// 
        /// <returns>The response from the ListBillingGroupCostReports service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListBillingGroupCostReports">REST API Reference for ListBillingGroupCostReports Operation</seealso>
        ListBillingGroupCostReportsResponse ListBillingGroupCostReports(ListBillingGroupCostReportsRequest request);



        /// <summary>
        /// A paginated call to retrieve a summary report of actual Amazon Web Services charges
        /// and the calculated Amazon Web Services charges based on the associated pricing plan
        /// of a billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillingGroupCostReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBillingGroupCostReports service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListBillingGroupCostReports">REST API Reference for ListBillingGroupCostReports Operation</seealso>
        Task<ListBillingGroupCostReportsResponse> ListBillingGroupCostReportsAsync(ListBillingGroupCostReportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBillingGroups


        /// <summary>
        /// A paginated call to retrieve a list of billing groups for the given billing period.
        /// If you don't provide a billing group, the current billing period is used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillingGroups service method.</param>
        /// 
        /// <returns>The response from the ListBillingGroups service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListBillingGroups">REST API Reference for ListBillingGroups Operation</seealso>
        ListBillingGroupsResponse ListBillingGroups(ListBillingGroupsRequest request);



        /// <summary>
        /// A paginated call to retrieve a list of billing groups for the given billing period.
        /// If you don't provide a billing group, the current billing period is used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillingGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBillingGroups service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListBillingGroups">REST API Reference for ListBillingGroups Operation</seealso>
        Task<ListBillingGroupsResponse> ListBillingGroupsAsync(ListBillingGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCustomLineItems


        /// <summary>
        /// A paginated call to get a list of all custom line items (FFLIs) for the given billing
        /// period. If you don't provide a billing period, the current billing period is used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomLineItems service method.</param>
        /// 
        /// <returns>The response from the ListCustomLineItems service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListCustomLineItems">REST API Reference for ListCustomLineItems Operation</seealso>
        ListCustomLineItemsResponse ListCustomLineItems(ListCustomLineItemsRequest request);



        /// <summary>
        /// A paginated call to get a list of all custom line items (FFLIs) for the given billing
        /// period. If you don't provide a billing period, the current billing period is used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomLineItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomLineItems service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListCustomLineItems">REST API Reference for ListCustomLineItems Operation</seealso>
        Task<ListCustomLineItemsResponse> ListCustomLineItemsAsync(ListCustomLineItemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCustomLineItemVersions


        /// <summary>
        /// A paginated call to get a list of all custom line item versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomLineItemVersions service method.</param>
        /// 
        /// <returns>The response from the ListCustomLineItemVersions service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListCustomLineItemVersions">REST API Reference for ListCustomLineItemVersions Operation</seealso>
        ListCustomLineItemVersionsResponse ListCustomLineItemVersions(ListCustomLineItemVersionsRequest request);



        /// <summary>
        /// A paginated call to get a list of all custom line item versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomLineItemVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomLineItemVersions service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListCustomLineItemVersions">REST API Reference for ListCustomLineItemVersions Operation</seealso>
        Task<ListCustomLineItemVersionsResponse> ListCustomLineItemVersionsAsync(ListCustomLineItemVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPricingPlans


        /// <summary>
        /// A paginated call to get pricing plans for the given billing period. If you don't provide
        /// a billing period, the current billing period is used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPricingPlans service method.</param>
        /// 
        /// <returns>The response from the ListPricingPlans service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingPlans">REST API Reference for ListPricingPlans Operation</seealso>
        ListPricingPlansResponse ListPricingPlans(ListPricingPlansRequest request);



        /// <summary>
        /// A paginated call to get pricing plans for the given billing period. If you don't provide
        /// a billing period, the current billing period is used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPricingPlans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPricingPlans service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingPlans">REST API Reference for ListPricingPlans Operation</seealso>
        Task<ListPricingPlansResponse> ListPricingPlansAsync(ListPricingPlansRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPricingPlansAssociatedWithPricingRule


        /// <summary>
        /// A list of the pricing plans that are associated with a pricing rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPricingPlansAssociatedWithPricingRule service method.</param>
        /// 
        /// <returns>The response from the ListPricingPlansAssociatedWithPricingRule service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingPlansAssociatedWithPricingRule">REST API Reference for ListPricingPlansAssociatedWithPricingRule Operation</seealso>
        ListPricingPlansAssociatedWithPricingRuleResponse ListPricingPlansAssociatedWithPricingRule(ListPricingPlansAssociatedWithPricingRuleRequest request);



        /// <summary>
        /// A list of the pricing plans that are associated with a pricing rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPricingPlansAssociatedWithPricingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPricingPlansAssociatedWithPricingRule service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingPlansAssociatedWithPricingRule">REST API Reference for ListPricingPlansAssociatedWithPricingRule Operation</seealso>
        Task<ListPricingPlansAssociatedWithPricingRuleResponse> ListPricingPlansAssociatedWithPricingRuleAsync(ListPricingPlansAssociatedWithPricingRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPricingRules


        /// <summary>
        /// Describes a pricing rule that can be associated to a pricing plan, or set of pricing
        /// plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPricingRules service method.</param>
        /// 
        /// <returns>The response from the ListPricingRules service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingRules">REST API Reference for ListPricingRules Operation</seealso>
        ListPricingRulesResponse ListPricingRules(ListPricingRulesRequest request);



        /// <summary>
        /// Describes a pricing rule that can be associated to a pricing plan, or set of pricing
        /// plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPricingRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPricingRules service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingRules">REST API Reference for ListPricingRules Operation</seealso>
        Task<ListPricingRulesResponse> ListPricingRulesAsync(ListPricingRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPricingRulesAssociatedToPricingPlan


        /// <summary>
        /// Lists the pricing rules that are associated with a pricing plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPricingRulesAssociatedToPricingPlan service method.</param>
        /// 
        /// <returns>The response from the ListPricingRulesAssociatedToPricingPlan service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingRulesAssociatedToPricingPlan">REST API Reference for ListPricingRulesAssociatedToPricingPlan Operation</seealso>
        ListPricingRulesAssociatedToPricingPlanResponse ListPricingRulesAssociatedToPricingPlan(ListPricingRulesAssociatedToPricingPlanRequest request);



        /// <summary>
        /// Lists the pricing rules that are associated with a pricing plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPricingRulesAssociatedToPricingPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPricingRulesAssociatedToPricingPlan service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingRulesAssociatedToPricingPlan">REST API Reference for ListPricingRulesAssociatedToPricingPlan Operation</seealso>
        Task<ListPricingRulesAssociatedToPricingPlanResponse> ListPricingRulesAssociatedToPricingPlanAsync(ListPricingRulesAssociatedToPricingPlanRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResourcesAssociatedToCustomLineItem


        /// <summary>
        /// List the resources that are associated to a custom line item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesAssociatedToCustomLineItem service method.</param>
        /// 
        /// <returns>The response from the ListResourcesAssociatedToCustomLineItem service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListResourcesAssociatedToCustomLineItem">REST API Reference for ListResourcesAssociatedToCustomLineItem Operation</seealso>
        ListResourcesAssociatedToCustomLineItemResponse ListResourcesAssociatedToCustomLineItem(ListResourcesAssociatedToCustomLineItemRequest request);



        /// <summary>
        /// List the resources that are associated to a custom line item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesAssociatedToCustomLineItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourcesAssociatedToCustomLineItem service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListResourcesAssociatedToCustomLineItem">REST API Reference for ListResourcesAssociatedToCustomLineItem Operation</seealso>
        Task<ListResourcesAssociatedToCustomLineItemResponse> ListResourcesAssociatedToCustomLineItemAsync(ListResourcesAssociatedToCustomLineItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// A list the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// A list the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates the specified tags to a resource with the specified <c>resourceArn</c>.
        /// If existing tags on a resource are not specified in the request parameters, they are
        /// not changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Associates the specified tags to a resource with the specified <c>resourceArn</c>.
        /// If existing tags on a resource are not specified in the request parameters, they are
        /// not changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateBillingGroup


        /// <summary>
        /// This updates an existing billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillingGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateBillingGroup service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdateBillingGroup">REST API Reference for UpdateBillingGroup Operation</seealso>
        UpdateBillingGroupResponse UpdateBillingGroup(UpdateBillingGroupRequest request);



        /// <summary>
        /// This updates an existing billing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBillingGroup service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdateBillingGroup">REST API Reference for UpdateBillingGroup Operation</seealso>
        Task<UpdateBillingGroupResponse> UpdateBillingGroupAsync(UpdateBillingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCustomLineItem


        /// <summary>
        /// Update an existing custom line item in the current or previous billing period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomLineItem service method.</param>
        /// 
        /// <returns>The response from the UpdateCustomLineItem service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdateCustomLineItem">REST API Reference for UpdateCustomLineItem Operation</seealso>
        UpdateCustomLineItemResponse UpdateCustomLineItem(UpdateCustomLineItemRequest request);



        /// <summary>
        /// Update an existing custom line item in the current or previous billing period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomLineItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCustomLineItem service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdateCustomLineItem">REST API Reference for UpdateCustomLineItem Operation</seealso>
        Task<UpdateCustomLineItemResponse> UpdateCustomLineItemAsync(UpdateCustomLineItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePricingPlan


        /// <summary>
        /// This updates an existing pricing plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePricingPlan service method.</param>
        /// 
        /// <returns>The response from the UpdatePricingPlan service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdatePricingPlan">REST API Reference for UpdatePricingPlan Operation</seealso>
        UpdatePricingPlanResponse UpdatePricingPlan(UpdatePricingPlanRequest request);



        /// <summary>
        /// This updates an existing pricing plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePricingPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePricingPlan service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdatePricingPlan">REST API Reference for UpdatePricingPlan Operation</seealso>
        Task<UpdatePricingPlanResponse> UpdatePricingPlanAsync(UpdatePricingPlanRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePricingRule


        /// <summary>
        /// Updates an existing pricing rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePricingRule service method.</param>
        /// 
        /// <returns>The response from the UpdatePricingRule service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdatePricingRule">REST API Reference for UpdatePricingRule Operation</seealso>
        UpdatePricingRuleResponse UpdatePricingRule(UpdatePricingRuleRequest request);



        /// <summary>
        /// Updates an existing pricing rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePricingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePricingRule service method, as returned by BillingConductor.</returns>
        /// <exception cref="Amazon.BillingConductor.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ConflictException">
        /// You can cause an inconsistent state by updating or deleting a resource.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.BillingConductor.Model.ValidationException">
        /// The input doesn't match with the constraints specified by Amazon Web Services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdatePricingRule">REST API Reference for UpdatePricingRule Operation</seealso>
        Task<UpdatePricingRuleResponse> UpdatePricingRuleAsync(UpdatePricingRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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