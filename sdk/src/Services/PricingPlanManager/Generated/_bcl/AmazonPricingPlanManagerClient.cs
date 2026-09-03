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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.PricingPlanManager.Model;
using Amazon.PricingPlanManager.Model.Internal.MarshallTransformations;
using Amazon.PricingPlanManager.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.PricingPlanManager
{
    /// <summary>
    /// <para>Implementation for accessing PricingPlanManager</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Manages flat-rate pricing subscriptions for supported services. Use this API to create,
    /// approve, update, and cancel subscriptions; associate and disassociate resources; and
    /// retrieve subscription details. With a flat-rate pricing subscription, you pay a fixed
    /// recurring fee for eligible resources instead of usage-based pricing.
    /// </summary>
    public partial class AmazonPricingPlanManagerClient : AmazonServiceClient, IAmazonPricingPlanManager
    {
        private static IServiceMetadata serviceMetadata = new AmazonPricingPlanManagerMetadata();
        private IPricingPlanManagerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPricingPlanManagerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PricingPlanManagerPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonPricingPlanManagerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonPricingPlanManagerClient()
            : base(new AmazonPricingPlanManagerConfig()) { }

        /// <summary>
        /// Constructs AmazonPricingPlanManagerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonPricingPlanManagerClient(RegionEndpoint region)
            : base(new AmazonPricingPlanManagerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPricingPlanManagerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonPricingPlanManagerClient Configuration Object</param>
        public AmazonPricingPlanManagerClient(AmazonPricingPlanManagerConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonPricingPlanManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPricingPlanManagerClient(AWSCredentials credentials)
            : this(credentials, new AmazonPricingPlanManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPricingPlanManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPricingPlanManagerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPricingPlanManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPricingPlanManagerClient with AWS Credentials and an
        /// AmazonPricingPlanManagerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPricingPlanManagerClient Configuration Object</param>
        public AmazonPricingPlanManagerClient(AWSCredentials credentials, AmazonPricingPlanManagerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPricingPlanManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPricingPlanManagerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPricingPlanManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPricingPlanManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPricingPlanManagerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPricingPlanManagerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPricingPlanManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPricingPlanManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPricingPlanManagerClient Configuration Object</param>
        public AmazonPricingPlanManagerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPricingPlanManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPricingPlanManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPricingPlanManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPricingPlanManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPricingPlanManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPricingPlanManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPricingPlanManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPricingPlanManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPricingPlanManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPricingPlanManagerClient Configuration Object</param>
        public AmazonPricingPlanManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPricingPlanManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPricingPlanManagerEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPricingPlanManagerAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


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
        public virtual ApprovePaidSubscriptionResponse ApprovePaidSubscription(ApprovePaidSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApprovePaidSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApprovePaidSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ApprovePaidSubscriptionResponse>(request, options);
        }


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
        public virtual Task<ApprovePaidSubscriptionResponse> ApprovePaidSubscriptionAsync(ApprovePaidSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApprovePaidSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApprovePaidSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ApprovePaidSubscriptionResponse>(request, options, cancellationToken);
        }

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
        public virtual AssociateResourcesToSubscriptionResponse AssociateResourcesToSubscription(AssociateResourcesToSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateResourcesToSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourcesToSubscriptionResponseUnmarshaller.Instance;

            return Invoke<AssociateResourcesToSubscriptionResponse>(request, options);
        }


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
        public virtual Task<AssociateResourcesToSubscriptionResponse> AssociateResourcesToSubscriptionAsync(AssociateResourcesToSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateResourcesToSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourcesToSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateResourcesToSubscriptionResponse>(request, options, cancellationToken);
        }

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
        public virtual CancelSubscriptionResponse CancelSubscription(CancelSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CancelSubscriptionResponse>(request, options);
        }


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
        public virtual Task<CancelSubscriptionResponse> CancelSubscriptionAsync(CancelSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelSubscriptionResponse>(request, options, cancellationToken);
        }

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
        public virtual CancelSubscriptionChangeResponse CancelSubscriptionChange(CancelSubscriptionChangeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSubscriptionChangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSubscriptionChangeResponseUnmarshaller.Instance;

            return Invoke<CancelSubscriptionChangeResponse>(request, options);
        }


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
        public virtual Task<CancelSubscriptionChangeResponse> CancelSubscriptionChangeAsync(CancelSubscriptionChangeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSubscriptionChangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSubscriptionChangeResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelSubscriptionChangeResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateSubscriptionResponse CreateSubscription(CreateSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionResponse>(request, options);
        }


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
        public virtual Task<CreateSubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSubscriptionResponse>(request, options, cancellationToken);
        }

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
        public virtual DisassociateResourcesFromSubscriptionResponse DisassociateResourcesFromSubscription(DisassociateResourcesFromSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateResourcesFromSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourcesFromSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DisassociateResourcesFromSubscriptionResponse>(request, options);
        }


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
        public virtual Task<DisassociateResourcesFromSubscriptionResponse> DisassociateResourcesFromSubscriptionAsync(DisassociateResourcesFromSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateResourcesFromSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourcesFromSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateResourcesFromSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSubscription


        /// <summary>
        /// Returns the details of a flat-rate pricing subscription, including its current status,
        /// associated resources, and any pending scheduled changes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription service method.</param>
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
        public virtual GetSubscriptionResponse GetSubscription(GetSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionResponse>(request, options);
        }


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
        public virtual Task<GetSubscriptionResponse> GetSubscriptionAsync(GetSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSubscriptions


        /// <summary>
        /// Returns a summary of all flat-rate pricing subscriptions in the calling account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
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
        public virtual ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionsResponse>(request, options);
        }


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
        public virtual Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSubscriptionsResponse>(request, options, cancellationToken);
        }

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
        public virtual UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionResponse>(request, options);
        }


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
        public virtual Task<UpdateSubscriptionResponse> UpdateSubscriptionAsync(UpdateSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}