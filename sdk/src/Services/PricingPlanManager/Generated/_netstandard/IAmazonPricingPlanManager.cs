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
 * Do not modify this file. This file is generated from the pricing-plan-manager-2025-08-05.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PricingPlanManager.Model;

#pragma warning disable CS1570
namespace Amazon.PricingPlanManager
{
    /// <summary>
    /// <para>Interface for accessing PricingPlanManager</para>
    ///
    /// Manages flat-rate pricing subscriptions for supported services. Use this API to create,
    /// approve, update, and cancel subscriptions; associate and disassociate resources; and
    /// retrieve subscription details. With a flat-rate pricing subscription, you pay a fixed
    /// recurring fee for eligible resources instead of usage-based pricing.
    /// </summary>
    public partial interface IAmazonPricingPlanManager : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPricingPlanManagerPaginatorFactory Paginators { get; }
#endif
                
        #region  ApprovePaidSubscription



        /// <summary>
        /// Approves a subscription that is in <c>PENDING_APPROVAL</c> status, activating it and
        /// starting billing.
        /// 
        ///  <note> 
        /// <para>
        /// This operation requires the current <c>ETag</c> value for concurrency control. Retrieve
        /// it from a previous <c>GetSubscription</c> or <c>ListSubscriptions</c> response.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApprovePaidSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ApprovePaidSubscription service method, as returned by PricingPlanManager.</returns>
        /// <exception cref="Amazon.PricingPlanManager.Model.AccessDeniedException">
        /// You do not have the required permissions to perform this operation. Verify that your
        /// IAM policy grants access to this action.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This typically occurs
        /// when the <c>ETag</c> value in the <c>If-Match</c> header does not match the current
        /// version of the subscription. Retrieve the latest version and retry.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.InternalServerException">
        /// An unexpected error occurred on the server. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ResourceNotFoundException">
        /// The specified subscription was not found. Verify that the ARN is correct and that
        /// the subscription belongs to your account.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ThrottlingException">
        /// The request rate exceeds the allowed limit. Wait briefly and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ValidationException">
        /// The request failed a business rule validation. For example, the specified resource
        /// might already be associated with another subscription, or the subscription might not
        /// be in the required state for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-plan-manager-2025-08-05/ApprovePaidSubscription">REST API Reference for ApprovePaidSubscription Operation</seealso>
        Task<ApprovePaidSubscriptionResponse> ApprovePaidSubscriptionAsync(ApprovePaidSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateResourcesToSubscription



        /// <summary>
        /// Adds one or more resources to an existing subscription. The subscription must be in
        /// an active state that is not pending other changes.
        /// 
        ///  <note> 
        /// <para>
        /// For subscriptions in the CloudFront plan family, the associated resources must include
        /// exactly one Amazon CloudFront distribution and one WAF web ACL. You can also include
        /// other supported resources, such as Amazon Route 53 hosted zones, and CloudFront KeyValueStores.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResourcesToSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateResourcesToSubscription service method, as returned by PricingPlanManager.</returns>
        /// <exception cref="Amazon.PricingPlanManager.Model.AccessDeniedException">
        /// You do not have the required permissions to perform this operation. Verify that your
        /// IAM policy grants access to this action.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This typically occurs
        /// when the <c>ETag</c> value in the <c>If-Match</c> header does not match the current
        /// version of the subscription. Retrieve the latest version and retry.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.InternalServerException">
        /// An unexpected error occurred on the server. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ResourceNotFoundException">
        /// The specified subscription was not found. Verify that the ARN is correct and that
        /// the subscription belongs to your account.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ThrottlingException">
        /// The request rate exceeds the allowed limit. Wait briefly and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ValidationException">
        /// The request failed a business rule validation. For example, the specified resource
        /// might already be associated with another subscription, or the subscription might not
        /// be in the required state for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-plan-manager-2025-08-05/AssociateResourcesToSubscription">REST API Reference for AssociateResourcesToSubscription Operation</seealso>
        Task<AssociateResourcesToSubscriptionResponse> AssociateResourcesToSubscriptionAsync(AssociateResourcesToSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelSubscription



        /// <summary>
        /// Cancels a flat-rate pricing subscription.
        /// 
        ///  <note> 
        /// <para>
        /// For active subscriptions, the cancellation is scheduled to take effect at the end
        /// of the current billing period. The subscription remains active until that date. To
        /// revert a pending cancellation, use <c>CancelSubscriptionChange</c>.
        /// </para>
        ///  
        /// <para>
        /// For subscriptions in <c>PENDING_APPROVAL</c> status, the subscription is deleted immediately
        /// without scheduling.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSubscription service method, as returned by PricingPlanManager.</returns>
        /// <exception cref="Amazon.PricingPlanManager.Model.AccessDeniedException">
        /// You do not have the required permissions to perform this operation. Verify that your
        /// IAM policy grants access to this action.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This typically occurs
        /// when the <c>ETag</c> value in the <c>If-Match</c> header does not match the current
        /// version of the subscription. Retrieve the latest version and retry.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.InternalServerException">
        /// An unexpected error occurred on the server. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ResourceNotFoundException">
        /// The specified subscription was not found. Verify that the ARN is correct and that
        /// the subscription belongs to your account.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ThrottlingException">
        /// The request rate exceeds the allowed limit. Wait briefly and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ValidationException">
        /// The request failed a business rule validation. For example, the specified resource
        /// might already be associated with another subscription, or the subscription might not
        /// be in the required state for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-plan-manager-2025-08-05/CancelSubscription">REST API Reference for CancelSubscription Operation</seealso>
        Task<CancelSubscriptionResponse> CancelSubscriptionAsync(CancelSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelSubscriptionChange



        /// <summary>
        /// Cancels a pending scheduled change on a subscription, such as a pending downgrade
        /// or cancellation. The subscription returns to its state before the change was scheduled.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot cancel a scheduled change close to its effective date. If the change is
        /// within the processing window, this operation returns an error.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSubscriptionChange service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSubscriptionChange service method, as returned by PricingPlanManager.</returns>
        /// <exception cref="Amazon.PricingPlanManager.Model.AccessDeniedException">
        /// You do not have the required permissions to perform this operation. Verify that your
        /// IAM policy grants access to this action.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This typically occurs
        /// when the <c>ETag</c> value in the <c>If-Match</c> header does not match the current
        /// version of the subscription. Retrieve the latest version and retry.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.InternalServerException">
        /// An unexpected error occurred on the server. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ResourceNotFoundException">
        /// The specified subscription was not found. Verify that the ARN is correct and that
        /// the subscription belongs to your account.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ThrottlingException">
        /// The request rate exceeds the allowed limit. Wait briefly and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ValidationException">
        /// The request failed a business rule validation. For example, the specified resource
        /// might already be associated with another subscription, or the subscription might not
        /// be in the required state for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-plan-manager-2025-08-05/CancelSubscriptionChange">REST API Reference for CancelSubscriptionChange Operation</seealso>
        Task<CancelSubscriptionChangeResponse> CancelSubscriptionChangeAsync(CancelSubscriptionChangeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSubscription



        /// <summary>
        /// Creates a flat-rate pricing subscription for the specified resources.
        /// 
        ///  <note> 
        /// <para>
        /// When <c>approvalMode</c> is set to <c>MANUAL</c>, paid-tier subscriptions are created
        /// in <c>PENDING_APPROVAL</c> status and require a separate <c>ApprovePaidSubscription</c>
        /// call before billing starts. Free-tier subscriptions are always activated immediately
        /// regardless of approval mode.
        /// </para>
        ///  
        /// <para>
        /// When <c>approvalMode</c> is set to <c>IMMEDIATE</c> or is not specified, the subscription
        /// is activated immediately.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscription service method, as returned by PricingPlanManager.</returns>
        /// <exception cref="Amazon.PricingPlanManager.Model.AccessDeniedException">
        /// You do not have the required permissions to perform this operation. Verify that your
        /// IAM policy grants access to this action.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This typically occurs
        /// when the <c>ETag</c> value in the <c>If-Match</c> header does not match the current
        /// version of the subscription. Retrieve the latest version and retry.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.InternalServerException">
        /// An unexpected error occurred on the server. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ResourceNotFoundException">
        /// The specified subscription was not found. Verify that the ARN is correct and that
        /// the subscription belongs to your account.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service limit. You have reached the maximum number of subscriptions
        /// allowed for your account.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ThrottlingException">
        /// The request rate exceeds the allowed limit. Wait briefly and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ValidationException">
        /// The request failed a business rule validation. For example, the specified resource
        /// might already be associated with another subscription, or the subscription might not
        /// be in the required state for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-plan-manager-2025-08-05/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        Task<CreateSubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateResourcesFromSubscription



        /// <summary>
        /// Removes one or more resources from an existing subscription.
        /// 
        ///  <note> 
        /// <para>
        /// For subscriptions in the CloudFront plan family, the associated resources must always
        /// include exactly one Amazon CloudFront distribution and exactly one WAF web ACL. You
        /// cannot remove these required resources.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourcesFromSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateResourcesFromSubscription service method, as returned by PricingPlanManager.</returns>
        /// <exception cref="Amazon.PricingPlanManager.Model.AccessDeniedException">
        /// You do not have the required permissions to perform this operation. Verify that your
        /// IAM policy grants access to this action.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This typically occurs
        /// when the <c>ETag</c> value in the <c>If-Match</c> header does not match the current
        /// version of the subscription. Retrieve the latest version and retry.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.InternalServerException">
        /// An unexpected error occurred on the server. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ResourceNotFoundException">
        /// The specified subscription was not found. Verify that the ARN is correct and that
        /// the subscription belongs to your account.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ThrottlingException">
        /// The request rate exceeds the allowed limit. Wait briefly and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ValidationException">
        /// The request failed a business rule validation. For example, the specified resource
        /// might already be associated with another subscription, or the subscription might not
        /// be in the required state for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-plan-manager-2025-08-05/DisassociateResourcesFromSubscription">REST API Reference for DisassociateResourcesFromSubscription Operation</seealso>
        Task<DisassociateResourcesFromSubscriptionResponse> DisassociateResourcesFromSubscriptionAsync(DisassociateResourcesFromSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSubscription



        /// <summary>
        /// Returns the details of a flat-rate pricing subscription, including its current status,
        /// associated resources, and any pending scheduled changes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscription service method, as returned by PricingPlanManager.</returns>
        /// <exception cref="Amazon.PricingPlanManager.Model.AccessDeniedException">
        /// You do not have the required permissions to perform this operation. Verify that your
        /// IAM policy grants access to this action.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.InternalServerException">
        /// An unexpected error occurred on the server. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ResourceNotFoundException">
        /// The specified subscription was not found. Verify that the ARN is correct and that
        /// the subscription belongs to your account.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ThrottlingException">
        /// The request rate exceeds the allowed limit. Wait briefly and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ValidationException">
        /// The request failed a business rule validation. For example, the specified resource
        /// might already be associated with another subscription, or the subscription might not
        /// be in the required state for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-plan-manager-2025-08-05/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        Task<GetSubscriptionResponse> GetSubscriptionAsync(GetSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSubscriptions



        /// <summary>
        /// Returns a summary of all flat-rate pricing subscriptions in the calling account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by PricingPlanManager.</returns>
        /// <exception cref="Amazon.PricingPlanManager.Model.AccessDeniedException">
        /// You do not have the required permissions to perform this operation. Verify that your
        /// IAM policy grants access to this action.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.InternalServerException">
        /// An unexpected error occurred on the server. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ResourceNotFoundException">
        /// The specified subscription was not found. Verify that the ARN is correct and that
        /// the subscription belongs to your account.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ThrottlingException">
        /// The request rate exceeds the allowed limit. Wait briefly and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ValidationException">
        /// The request failed a business rule validation. For example, the specified resource
        /// might already be associated with another subscription, or the subscription might not
        /// be in the required state for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-plan-manager-2025-08-05/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSubscription



        /// <summary>
        /// Changes the plan tier of an existing subscription.
        /// 
        ///  <note> 
        /// <para>
        /// Upgrades take effect immediately. Downgrades are scheduled and the current tier remains
        /// unchanged until the end of the billing cycle (calendar month). You cannot update a
        /// subscription while a scheduled change is pending. To make a new change, first cancel
        /// the pending change using <c>CancelSubscriptionChange</c>.
        /// </para>
        ///  
        /// <para>
        /// This operation replaces the plan tier value. If you omit the optional <c>usageLevel</c>
        /// field, it is reset to the default.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscription service method, as returned by PricingPlanManager.</returns>
        /// <exception cref="Amazon.PricingPlanManager.Model.AccessDeniedException">
        /// You do not have the required permissions to perform this operation. Verify that your
        /// IAM policy grants access to this action.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ConflictException">
        /// The request conflicts with the current state of the resource. This typically occurs
        /// when the <c>ETag</c> value in the <c>If-Match</c> header does not match the current
        /// version of the subscription. Retrieve the latest version and retry.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.InternalServerException">
        /// An unexpected error occurred on the server. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ResourceNotFoundException">
        /// The specified subscription was not found. Verify that the ARN is correct and that
        /// the subscription belongs to your account.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ServiceQuotaExceededException">
        /// The request would exceed a service limit. You have reached the maximum number of subscriptions
        /// allowed for your account.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ThrottlingException">
        /// The request rate exceeds the allowed limit. Wait briefly and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PricingPlanManager.Model.ValidationException">
        /// The request failed a business rule validation. For example, the specified resource
        /// might already be associated with another subscription, or the subscription might not
        /// be in the required state for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-plan-manager-2025-08-05/UpdateSubscription">REST API Reference for UpdateSubscription Operation</seealso>
        Task<UpdateSubscriptionResponse> UpdateSubscriptionAsync(UpdateSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonPricingPlanManagerConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonPricingPlanManagerConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonPricingPlanManagerConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonPricingPlanManagerConfig to create AmazonPricingPlanManagerClient");
            }

            return awsCredentials == null ? 
                    new AmazonPricingPlanManagerClient(serviceClientConfig) :
                    new AmazonPricingPlanManagerClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}