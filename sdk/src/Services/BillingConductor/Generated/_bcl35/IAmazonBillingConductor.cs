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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BillingConductor.Model;

#pragma warning disable CS1570
namespace Amazon.BillingConductor
{
    /// <summary>
    /// <para>Interface for accessing BillingConductor</para>
    ///
    /// Billing Conductor is a fully managed service that you can use to customize a <a href="https://docs.aws.amazon.com/billingconductor/latest/userguide/understanding-eb.html#eb-other-definitions">pro
    /// forma</a> version of your billing data each month, to accurately show or chargeback
    /// your end customers. Billing Conductor doesn't change the way you're billed by Amazon
    /// Web Services each month by design. Instead, it provides you with a mechanism to configure,
    /// generate, and display rates to certain customers over a given billing period. You
    /// can also analyze the difference between the rates you apply to your accounting groupings
    /// relative to your actual rates from Amazon Web Services. As a result of your Billing
    /// Conductor configuration, the payer account can also see the custom rate applied on
    /// the billing details page of the <a href="https://console.aws.amazon.com/billing">Billing
    /// console</a>, or configure a cost and usage report per billing group.
    /// 
    ///  
    /// <para>
    /// This documentation shows how you can configure Billing Conductor by using its API.
    /// For more information about using the <a href="https://console.aws.amazon.com/billingconductor/">Billing
    /// Conductor</a> user interface, see the <a href="https://docs.aws.amazon.com/billingconductor/latest/userguide/what-is-billingconductor.html">
    /// Billing Conductor User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonBillingConductor : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBillingConductorPaginatorFactory Paginators { get; }
#endif


        
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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/AssociateAccounts">REST API Reference for AssociateAccounts Operation</seealso>
        AssociateAccountsResponse AssociateAccounts(AssociateAccountsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAccounts operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/AssociateAccounts">REST API Reference for AssociateAccounts Operation</seealso>
        IAsyncResult BeginAssociateAccounts(AssociateAccountsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAccounts.</param>
        /// 
        /// <returns>Returns a  AssociateAccountsResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/AssociateAccounts">REST API Reference for AssociateAccounts Operation</seealso>
        AssociateAccountsResponse EndAssociateAccounts(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/AssociatePricingRules">REST API Reference for AssociatePricingRules Operation</seealso>
        AssociatePricingRulesResponse AssociatePricingRules(AssociatePricingRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePricingRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePricingRules operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePricingRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/AssociatePricingRules">REST API Reference for AssociatePricingRules Operation</seealso>
        IAsyncResult BeginAssociatePricingRules(AssociatePricingRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePricingRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePricingRules.</param>
        /// 
        /// <returns>Returns a  AssociatePricingRulesResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/AssociatePricingRules">REST API Reference for AssociatePricingRules Operation</seealso>
        AssociatePricingRulesResponse EndAssociatePricingRules(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/BatchAssociateResourcesToCustomLineItem">REST API Reference for BatchAssociateResourcesToCustomLineItem Operation</seealso>
        BatchAssociateResourcesToCustomLineItemResponse BatchAssociateResourcesToCustomLineItem(BatchAssociateResourcesToCustomLineItemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAssociateResourcesToCustomLineItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateResourcesToCustomLineItem operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchAssociateResourcesToCustomLineItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/BatchAssociateResourcesToCustomLineItem">REST API Reference for BatchAssociateResourcesToCustomLineItem Operation</seealso>
        IAsyncResult BeginBatchAssociateResourcesToCustomLineItem(BatchAssociateResourcesToCustomLineItemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAssociateResourcesToCustomLineItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAssociateResourcesToCustomLineItem.</param>
        /// 
        /// <returns>Returns a  BatchAssociateResourcesToCustomLineItemResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/BatchAssociateResourcesToCustomLineItem">REST API Reference for BatchAssociateResourcesToCustomLineItem Operation</seealso>
        BatchAssociateResourcesToCustomLineItemResponse EndBatchAssociateResourcesToCustomLineItem(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/BatchDisassociateResourcesFromCustomLineItem">REST API Reference for BatchDisassociateResourcesFromCustomLineItem Operation</seealso>
        BatchDisassociateResourcesFromCustomLineItemResponse BatchDisassociateResourcesFromCustomLineItem(BatchDisassociateResourcesFromCustomLineItemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisassociateResourcesFromCustomLineItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateResourcesFromCustomLineItem operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDisassociateResourcesFromCustomLineItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/BatchDisassociateResourcesFromCustomLineItem">REST API Reference for BatchDisassociateResourcesFromCustomLineItem Operation</seealso>
        IAsyncResult BeginBatchDisassociateResourcesFromCustomLineItem(BatchDisassociateResourcesFromCustomLineItemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDisassociateResourcesFromCustomLineItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDisassociateResourcesFromCustomLineItem.</param>
        /// 
        /// <returns>Returns a  BatchDisassociateResourcesFromCustomLineItemResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/BatchDisassociateResourcesFromCustomLineItem">REST API Reference for BatchDisassociateResourcesFromCustomLineItem Operation</seealso>
        BatchDisassociateResourcesFromCustomLineItemResponse EndBatchDisassociateResourcesFromCustomLineItem(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreateBillingGroup">REST API Reference for CreateBillingGroup Operation</seealso>
        CreateBillingGroupResponse CreateBillingGroup(CreateBillingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBillingGroup operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBillingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreateBillingGroup">REST API Reference for CreateBillingGroup Operation</seealso>
        IAsyncResult BeginCreateBillingGroup(CreateBillingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBillingGroup.</param>
        /// 
        /// <returns>Returns a  CreateBillingGroupResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreateBillingGroup">REST API Reference for CreateBillingGroup Operation</seealso>
        CreateBillingGroupResponse EndCreateBillingGroup(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreateCustomLineItem">REST API Reference for CreateCustomLineItem Operation</seealso>
        CreateCustomLineItemResponse CreateCustomLineItem(CreateCustomLineItemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomLineItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomLineItem operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomLineItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreateCustomLineItem">REST API Reference for CreateCustomLineItem Operation</seealso>
        IAsyncResult BeginCreateCustomLineItem(CreateCustomLineItemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomLineItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomLineItem.</param>
        /// 
        /// <returns>Returns a  CreateCustomLineItemResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreateCustomLineItem">REST API Reference for CreateCustomLineItem Operation</seealso>
        CreateCustomLineItemResponse EndCreateCustomLineItem(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreatePricingPlan">REST API Reference for CreatePricingPlan Operation</seealso>
        CreatePricingPlanResponse CreatePricingPlan(CreatePricingPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePricingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePricingPlan operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePricingPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreatePricingPlan">REST API Reference for CreatePricingPlan Operation</seealso>
        IAsyncResult BeginCreatePricingPlan(CreatePricingPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePricingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePricingPlan.</param>
        /// 
        /// <returns>Returns a  CreatePricingPlanResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreatePricingPlan">REST API Reference for CreatePricingPlan Operation</seealso>
        CreatePricingPlanResponse EndCreatePricingPlan(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreatePricingRule">REST API Reference for CreatePricingRule Operation</seealso>
        CreatePricingRuleResponse CreatePricingRule(CreatePricingRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePricingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePricingRule operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePricingRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreatePricingRule">REST API Reference for CreatePricingRule Operation</seealso>
        IAsyncResult BeginCreatePricingRule(CreatePricingRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePricingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePricingRule.</param>
        /// 
        /// <returns>Returns a  CreatePricingRuleResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreatePricingRule">REST API Reference for CreatePricingRule Operation</seealso>
        CreatePricingRuleResponse EndCreatePricingRule(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeleteBillingGroup">REST API Reference for DeleteBillingGroup Operation</seealso>
        DeleteBillingGroupResponse DeleteBillingGroup(DeleteBillingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillingGroup operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBillingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeleteBillingGroup">REST API Reference for DeleteBillingGroup Operation</seealso>
        IAsyncResult BeginDeleteBillingGroup(DeleteBillingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBillingGroup.</param>
        /// 
        /// <returns>Returns a  DeleteBillingGroupResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeleteBillingGroup">REST API Reference for DeleteBillingGroup Operation</seealso>
        DeleteBillingGroupResponse EndDeleteBillingGroup(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeleteCustomLineItem">REST API Reference for DeleteCustomLineItem Operation</seealso>
        DeleteCustomLineItemResponse DeleteCustomLineItem(DeleteCustomLineItemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomLineItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomLineItem operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomLineItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeleteCustomLineItem">REST API Reference for DeleteCustomLineItem Operation</seealso>
        IAsyncResult BeginDeleteCustomLineItem(DeleteCustomLineItemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomLineItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomLineItem.</param>
        /// 
        /// <returns>Returns a  DeleteCustomLineItemResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeleteCustomLineItem">REST API Reference for DeleteCustomLineItem Operation</seealso>
        DeleteCustomLineItemResponse EndDeleteCustomLineItem(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeletePricingPlan">REST API Reference for DeletePricingPlan Operation</seealso>
        DeletePricingPlanResponse DeletePricingPlan(DeletePricingPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePricingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePricingPlan operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePricingPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeletePricingPlan">REST API Reference for DeletePricingPlan Operation</seealso>
        IAsyncResult BeginDeletePricingPlan(DeletePricingPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePricingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePricingPlan.</param>
        /// 
        /// <returns>Returns a  DeletePricingPlanResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeletePricingPlan">REST API Reference for DeletePricingPlan Operation</seealso>
        DeletePricingPlanResponse EndDeletePricingPlan(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeletePricingRule">REST API Reference for DeletePricingRule Operation</seealso>
        DeletePricingRuleResponse DeletePricingRule(DeletePricingRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePricingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePricingRule operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePricingRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeletePricingRule">REST API Reference for DeletePricingRule Operation</seealso>
        IAsyncResult BeginDeletePricingRule(DeletePricingRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePricingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePricingRule.</param>
        /// 
        /// <returns>Returns a  DeletePricingRuleResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeletePricingRule">REST API Reference for DeletePricingRule Operation</seealso>
        DeletePricingRuleResponse EndDeletePricingRule(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DisassociateAccounts">REST API Reference for DisassociateAccounts Operation</seealso>
        DisassociateAccountsResponse DisassociateAccounts(DisassociateAccountsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAccounts operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DisassociateAccounts">REST API Reference for DisassociateAccounts Operation</seealso>
        IAsyncResult BeginDisassociateAccounts(DisassociateAccountsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAccounts.</param>
        /// 
        /// <returns>Returns a  DisassociateAccountsResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DisassociateAccounts">REST API Reference for DisassociateAccounts Operation</seealso>
        DisassociateAccountsResponse EndDisassociateAccounts(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DisassociatePricingRules">REST API Reference for DisassociatePricingRules Operation</seealso>
        DisassociatePricingRulesResponse DisassociatePricingRules(DisassociatePricingRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePricingRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePricingRules operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociatePricingRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DisassociatePricingRules">REST API Reference for DisassociatePricingRules Operation</seealso>
        IAsyncResult BeginDisassociatePricingRules(DisassociatePricingRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePricingRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePricingRules.</param>
        /// 
        /// <returns>Returns a  DisassociatePricingRulesResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DisassociatePricingRules">REST API Reference for DisassociatePricingRules Operation</seealso>
        DisassociatePricingRulesResponse EndDisassociatePricingRules(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBillingGroupCostReport


        /// <summary>
        /// Retrieves the margin summary report, which includes the Amazon Web Services cost and
        /// charged amount (pro forma cost) by Amazon Web Services service for a specific billing
        /// group.
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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/GetBillingGroupCostReport">REST API Reference for GetBillingGroupCostReport Operation</seealso>
        GetBillingGroupCostReportResponse GetBillingGroupCostReport(GetBillingGroupCostReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBillingGroupCostReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBillingGroupCostReport operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBillingGroupCostReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/GetBillingGroupCostReport">REST API Reference for GetBillingGroupCostReport Operation</seealso>
        IAsyncResult BeginGetBillingGroupCostReport(GetBillingGroupCostReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBillingGroupCostReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBillingGroupCostReport.</param>
        /// 
        /// <returns>Returns a  GetBillingGroupCostReportResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/GetBillingGroupCostReport">REST API Reference for GetBillingGroupCostReport Operation</seealso>
        GetBillingGroupCostReportResponse EndGetBillingGroupCostReport(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListAccountAssociations">REST API Reference for ListAccountAssociations Operation</seealso>
        ListAccountAssociationsResponse ListAccountAssociations(ListAccountAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAssociations operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListAccountAssociations">REST API Reference for ListAccountAssociations Operation</seealso>
        IAsyncResult BeginListAccountAssociations(ListAccountAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountAssociations.</param>
        /// 
        /// <returns>Returns a  ListAccountAssociationsResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListAccountAssociations">REST API Reference for ListAccountAssociations Operation</seealso>
        ListAccountAssociationsResponse EndListAccountAssociations(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListBillingGroupCostReports">REST API Reference for ListBillingGroupCostReports Operation</seealso>
        ListBillingGroupCostReportsResponse ListBillingGroupCostReports(ListBillingGroupCostReportsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillingGroupCostReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillingGroupCostReports operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillingGroupCostReports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListBillingGroupCostReports">REST API Reference for ListBillingGroupCostReports Operation</seealso>
        IAsyncResult BeginListBillingGroupCostReports(ListBillingGroupCostReportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillingGroupCostReports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillingGroupCostReports.</param>
        /// 
        /// <returns>Returns a  ListBillingGroupCostReportsResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListBillingGroupCostReports">REST API Reference for ListBillingGroupCostReports Operation</seealso>
        ListBillingGroupCostReportsResponse EndListBillingGroupCostReports(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListBillingGroups">REST API Reference for ListBillingGroups Operation</seealso>
        ListBillingGroupsResponse ListBillingGroups(ListBillingGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillingGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillingGroups operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillingGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListBillingGroups">REST API Reference for ListBillingGroups Operation</seealso>
        IAsyncResult BeginListBillingGroups(ListBillingGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillingGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillingGroups.</param>
        /// 
        /// <returns>Returns a  ListBillingGroupsResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListBillingGroups">REST API Reference for ListBillingGroups Operation</seealso>
        ListBillingGroupsResponse EndListBillingGroups(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListCustomLineItems">REST API Reference for ListCustomLineItems Operation</seealso>
        ListCustomLineItemsResponse ListCustomLineItems(ListCustomLineItemsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomLineItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomLineItems operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomLineItems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListCustomLineItems">REST API Reference for ListCustomLineItems Operation</seealso>
        IAsyncResult BeginListCustomLineItems(ListCustomLineItemsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomLineItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomLineItems.</param>
        /// 
        /// <returns>Returns a  ListCustomLineItemsResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListCustomLineItems">REST API Reference for ListCustomLineItems Operation</seealso>
        ListCustomLineItemsResponse EndListCustomLineItems(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListCustomLineItemVersions">REST API Reference for ListCustomLineItemVersions Operation</seealso>
        ListCustomLineItemVersionsResponse ListCustomLineItemVersions(ListCustomLineItemVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomLineItemVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomLineItemVersions operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomLineItemVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListCustomLineItemVersions">REST API Reference for ListCustomLineItemVersions Operation</seealso>
        IAsyncResult BeginListCustomLineItemVersions(ListCustomLineItemVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomLineItemVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomLineItemVersions.</param>
        /// 
        /// <returns>Returns a  ListCustomLineItemVersionsResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListCustomLineItemVersions">REST API Reference for ListCustomLineItemVersions Operation</seealso>
        ListCustomLineItemVersionsResponse EndListCustomLineItemVersions(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingPlans">REST API Reference for ListPricingPlans Operation</seealso>
        ListPricingPlansResponse ListPricingPlans(ListPricingPlansRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPricingPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPricingPlans operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPricingPlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingPlans">REST API Reference for ListPricingPlans Operation</seealso>
        IAsyncResult BeginListPricingPlans(ListPricingPlansRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPricingPlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPricingPlans.</param>
        /// 
        /// <returns>Returns a  ListPricingPlansResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingPlans">REST API Reference for ListPricingPlans Operation</seealso>
        ListPricingPlansResponse EndListPricingPlans(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingPlansAssociatedWithPricingRule">REST API Reference for ListPricingPlansAssociatedWithPricingRule Operation</seealso>
        ListPricingPlansAssociatedWithPricingRuleResponse ListPricingPlansAssociatedWithPricingRule(ListPricingPlansAssociatedWithPricingRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPricingPlansAssociatedWithPricingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPricingPlansAssociatedWithPricingRule operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPricingPlansAssociatedWithPricingRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingPlansAssociatedWithPricingRule">REST API Reference for ListPricingPlansAssociatedWithPricingRule Operation</seealso>
        IAsyncResult BeginListPricingPlansAssociatedWithPricingRule(ListPricingPlansAssociatedWithPricingRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPricingPlansAssociatedWithPricingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPricingPlansAssociatedWithPricingRule.</param>
        /// 
        /// <returns>Returns a  ListPricingPlansAssociatedWithPricingRuleResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingPlansAssociatedWithPricingRule">REST API Reference for ListPricingPlansAssociatedWithPricingRule Operation</seealso>
        ListPricingPlansAssociatedWithPricingRuleResponse EndListPricingPlansAssociatedWithPricingRule(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingRules">REST API Reference for ListPricingRules Operation</seealso>
        ListPricingRulesResponse ListPricingRules(ListPricingRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPricingRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPricingRules operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPricingRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingRules">REST API Reference for ListPricingRules Operation</seealso>
        IAsyncResult BeginListPricingRules(ListPricingRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPricingRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPricingRules.</param>
        /// 
        /// <returns>Returns a  ListPricingRulesResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingRules">REST API Reference for ListPricingRules Operation</seealso>
        ListPricingRulesResponse EndListPricingRules(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingRulesAssociatedToPricingPlan">REST API Reference for ListPricingRulesAssociatedToPricingPlan Operation</seealso>
        ListPricingRulesAssociatedToPricingPlanResponse ListPricingRulesAssociatedToPricingPlan(ListPricingRulesAssociatedToPricingPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPricingRulesAssociatedToPricingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPricingRulesAssociatedToPricingPlan operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPricingRulesAssociatedToPricingPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingRulesAssociatedToPricingPlan">REST API Reference for ListPricingRulesAssociatedToPricingPlan Operation</seealso>
        IAsyncResult BeginListPricingRulesAssociatedToPricingPlan(ListPricingRulesAssociatedToPricingPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPricingRulesAssociatedToPricingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPricingRulesAssociatedToPricingPlan.</param>
        /// 
        /// <returns>Returns a  ListPricingRulesAssociatedToPricingPlanResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingRulesAssociatedToPricingPlan">REST API Reference for ListPricingRulesAssociatedToPricingPlan Operation</seealso>
        ListPricingRulesAssociatedToPricingPlanResponse EndListPricingRulesAssociatedToPricingPlan(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListResourcesAssociatedToCustomLineItem">REST API Reference for ListResourcesAssociatedToCustomLineItem Operation</seealso>
        ListResourcesAssociatedToCustomLineItemResponse ListResourcesAssociatedToCustomLineItem(ListResourcesAssociatedToCustomLineItemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourcesAssociatedToCustomLineItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesAssociatedToCustomLineItem operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourcesAssociatedToCustomLineItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListResourcesAssociatedToCustomLineItem">REST API Reference for ListResourcesAssociatedToCustomLineItem Operation</seealso>
        IAsyncResult BeginListResourcesAssociatedToCustomLineItem(ListResourcesAssociatedToCustomLineItemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourcesAssociatedToCustomLineItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourcesAssociatedToCustomLineItem.</param>
        /// 
        /// <returns>Returns a  ListResourcesAssociatedToCustomLineItemResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListResourcesAssociatedToCustomLineItem">REST API Reference for ListResourcesAssociatedToCustomLineItem Operation</seealso>
        ListResourcesAssociatedToCustomLineItemResponse EndListResourcesAssociatedToCustomLineItem(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdateBillingGroup">REST API Reference for UpdateBillingGroup Operation</seealso>
        UpdateBillingGroupResponse UpdateBillingGroup(UpdateBillingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillingGroup operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBillingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdateBillingGroup">REST API Reference for UpdateBillingGroup Operation</seealso>
        IAsyncResult BeginUpdateBillingGroup(UpdateBillingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBillingGroup.</param>
        /// 
        /// <returns>Returns a  UpdateBillingGroupResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdateBillingGroup">REST API Reference for UpdateBillingGroup Operation</seealso>
        UpdateBillingGroupResponse EndUpdateBillingGroup(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdateCustomLineItem">REST API Reference for UpdateCustomLineItem Operation</seealso>
        UpdateCustomLineItemResponse UpdateCustomLineItem(UpdateCustomLineItemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCustomLineItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomLineItem operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCustomLineItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdateCustomLineItem">REST API Reference for UpdateCustomLineItem Operation</seealso>
        IAsyncResult BeginUpdateCustomLineItem(UpdateCustomLineItemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCustomLineItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCustomLineItem.</param>
        /// 
        /// <returns>Returns a  UpdateCustomLineItemResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdateCustomLineItem">REST API Reference for UpdateCustomLineItem Operation</seealso>
        UpdateCustomLineItemResponse EndUpdateCustomLineItem(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdatePricingPlan">REST API Reference for UpdatePricingPlan Operation</seealso>
        UpdatePricingPlanResponse UpdatePricingPlan(UpdatePricingPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePricingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePricingPlan operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePricingPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdatePricingPlan">REST API Reference for UpdatePricingPlan Operation</seealso>
        IAsyncResult BeginUpdatePricingPlan(UpdatePricingPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePricingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePricingPlan.</param>
        /// 
        /// <returns>Returns a  UpdatePricingPlanResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdatePricingPlan">REST API Reference for UpdatePricingPlan Operation</seealso>
        UpdatePricingPlanResponse EndUpdatePricingPlan(IAsyncResult asyncResult);

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
        /// The input doesn't match with the constraints specified by Amazon Web Services services.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdatePricingRule">REST API Reference for UpdatePricingRule Operation</seealso>
        UpdatePricingRuleResponse UpdatePricingRule(UpdatePricingRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePricingRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePricingRule operation on AmazonBillingConductorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePricingRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdatePricingRule">REST API Reference for UpdatePricingRule Operation</seealso>
        IAsyncResult BeginUpdatePricingRule(UpdatePricingRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePricingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePricingRule.</param>
        /// 
        /// <returns>Returns a  UpdatePricingRuleResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdatePricingRule">REST API Reference for UpdatePricingRule Operation</seealso>
        UpdatePricingRuleResponse EndUpdatePricingRule(IAsyncResult asyncResult);

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