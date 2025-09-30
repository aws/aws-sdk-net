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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.BillingConductor.Model;
using Amazon.BillingConductor.Model.Internal.MarshallTransformations;
using Amazon.BillingConductor.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.BillingConductor
{
    /// <summary>
    /// <para>Implementation for accessing BillingConductor</para>
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
    public partial class AmazonBillingConductorClient : AmazonServiceClient, IAmazonBillingConductor
    {
        private static IServiceMetadata serviceMetadata = new AmazonBillingConductorMetadata();
        private IBillingConductorPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBillingConductorPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BillingConductorPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonBillingConductorClient with the credentials loaded from the application's
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
        public AmazonBillingConductorClient()
            : base(new AmazonBillingConductorConfig()) { }

        /// <summary>
        /// Constructs AmazonBillingConductorClient with the credentials loaded from the application's
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
        public AmazonBillingConductorClient(RegionEndpoint region)
            : base(new AmazonBillingConductorConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBillingConductorClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBillingConductorClient Configuration Object</param>
        public AmazonBillingConductorClient(AmazonBillingConductorConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonBillingConductorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBillingConductorClient(AWSCredentials credentials)
            : this(credentials, new AmazonBillingConductorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBillingConductorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBillingConductorClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBillingConductorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBillingConductorClient with AWS Credentials and an
        /// AmazonBillingConductorClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBillingConductorClient Configuration Object</param>
        public AmazonBillingConductorClient(AWSCredentials credentials, AmazonBillingConductorConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBillingConductorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBillingConductorClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBillingConductorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBillingConductorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBillingConductorClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBillingConductorConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBillingConductorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBillingConductorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBillingConductorClient Configuration Object</param>
        public AmazonBillingConductorClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBillingConductorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBillingConductorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBillingConductorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBillingConductorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBillingConductorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBillingConductorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBillingConductorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBillingConductorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBillingConductorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBillingConductorClient Configuration Object</param>
        public AmazonBillingConductorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBillingConductorConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBillingConductorEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBillingConductorAuthSchemeHandler());
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
        public virtual AssociateAccountsResponse AssociateAccounts(AssociateAccountsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAccountsResponseUnmarshaller.Instance;

            return Invoke<AssociateAccountsResponse>(request, options);
        }


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
        public virtual Task<AssociateAccountsResponse> AssociateAccountsAsync(AssociateAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAccountsResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateAccountsResponse>(request, options, cancellationToken);
        }

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
        public virtual AssociatePricingRulesResponse AssociatePricingRules(AssociatePricingRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociatePricingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePricingRulesResponseUnmarshaller.Instance;

            return Invoke<AssociatePricingRulesResponse>(request, options);
        }


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
        public virtual Task<AssociatePricingRulesResponse> AssociatePricingRulesAsync(AssociatePricingRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociatePricingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePricingRulesResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociatePricingRulesResponse>(request, options, cancellationToken);
        }

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
        public virtual BatchAssociateResourcesToCustomLineItemResponse BatchAssociateResourcesToCustomLineItem(BatchAssociateResourcesToCustomLineItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateResourcesToCustomLineItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateResourcesToCustomLineItemResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateResourcesToCustomLineItemResponse>(request, options);
        }


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
        public virtual Task<BatchAssociateResourcesToCustomLineItemResponse> BatchAssociateResourcesToCustomLineItemAsync(BatchAssociateResourcesToCustomLineItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateResourcesToCustomLineItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateResourcesToCustomLineItemResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchAssociateResourcesToCustomLineItemResponse>(request, options, cancellationToken);
        }

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
        public virtual BatchDisassociateResourcesFromCustomLineItemResponse BatchDisassociateResourcesFromCustomLineItem(BatchDisassociateResourcesFromCustomLineItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateResourcesFromCustomLineItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateResourcesFromCustomLineItemResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateResourcesFromCustomLineItemResponse>(request, options);
        }


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
        public virtual Task<BatchDisassociateResourcesFromCustomLineItemResponse> BatchDisassociateResourcesFromCustomLineItemAsync(BatchDisassociateResourcesFromCustomLineItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateResourcesFromCustomLineItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateResourcesFromCustomLineItemResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDisassociateResourcesFromCustomLineItemResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateBillingGroupResponse CreateBillingGroup(CreateBillingGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillingGroupResponseUnmarshaller.Instance;

            return Invoke<CreateBillingGroupResponse>(request, options);
        }


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
        public virtual Task<CreateBillingGroupResponse> CreateBillingGroupAsync(CreateBillingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateBillingGroupResponse>(request, options, cancellationToken);
        }

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
        public virtual CreateCustomLineItemResponse CreateCustomLineItem(CreateCustomLineItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomLineItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomLineItemResponseUnmarshaller.Instance;

            return Invoke<CreateCustomLineItemResponse>(request, options);
        }


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
        public virtual Task<CreateCustomLineItemResponse> CreateCustomLineItemAsync(CreateCustomLineItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomLineItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomLineItemResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCustomLineItemResponse>(request, options, cancellationToken);
        }

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
        public virtual CreatePricingPlanResponse CreatePricingPlan(CreatePricingPlanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePricingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePricingPlanResponseUnmarshaller.Instance;

            return Invoke<CreatePricingPlanResponse>(request, options);
        }


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
        public virtual Task<CreatePricingPlanResponse> CreatePricingPlanAsync(CreatePricingPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePricingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePricingPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePricingPlanResponse>(request, options, cancellationToken);
        }

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
        public virtual CreatePricingRuleResponse CreatePricingRule(CreatePricingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePricingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePricingRuleResponseUnmarshaller.Instance;

            return Invoke<CreatePricingRuleResponse>(request, options);
        }


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
        public virtual Task<CreatePricingRuleResponse> CreatePricingRuleAsync(CreatePricingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePricingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePricingRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePricingRuleResponse>(request, options, cancellationToken);
        }

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
        public virtual DeleteBillingGroupResponse DeleteBillingGroup(DeleteBillingGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBillingGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteBillingGroupResponse>(request, options);
        }


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
        public virtual Task<DeleteBillingGroupResponse> DeleteBillingGroupAsync(DeleteBillingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBillingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBillingGroupResponse>(request, options, cancellationToken);
        }

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
        public virtual DeleteCustomLineItemResponse DeleteCustomLineItem(DeleteCustomLineItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomLineItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomLineItemResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomLineItemResponse>(request, options);
        }


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
        public virtual Task<DeleteCustomLineItemResponse> DeleteCustomLineItemAsync(DeleteCustomLineItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomLineItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomLineItemResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCustomLineItemResponse>(request, options, cancellationToken);
        }

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
        public virtual DeletePricingPlanResponse DeletePricingPlan(DeletePricingPlanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePricingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePricingPlanResponseUnmarshaller.Instance;

            return Invoke<DeletePricingPlanResponse>(request, options);
        }


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
        public virtual Task<DeletePricingPlanResponse> DeletePricingPlanAsync(DeletePricingPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePricingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePricingPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePricingPlanResponse>(request, options, cancellationToken);
        }

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
        public virtual DeletePricingRuleResponse DeletePricingRule(DeletePricingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePricingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePricingRuleResponseUnmarshaller.Instance;

            return Invoke<DeletePricingRuleResponse>(request, options);
        }


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
        public virtual Task<DeletePricingRuleResponse> DeletePricingRuleAsync(DeletePricingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePricingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePricingRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePricingRuleResponse>(request, options, cancellationToken);
        }

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
        public virtual DisassociateAccountsResponse DisassociateAccounts(DisassociateAccountsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAccountsResponseUnmarshaller.Instance;

            return Invoke<DisassociateAccountsResponse>(request, options);
        }


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
        public virtual Task<DisassociateAccountsResponse> DisassociateAccountsAsync(DisassociateAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAccountsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateAccountsResponse>(request, options, cancellationToken);
        }

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
        public virtual DisassociatePricingRulesResponse DisassociatePricingRules(DisassociatePricingRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociatePricingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePricingRulesResponseUnmarshaller.Instance;

            return Invoke<DisassociatePricingRulesResponse>(request, options);
        }


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
        public virtual Task<DisassociatePricingRulesResponse> DisassociatePricingRulesAsync(DisassociatePricingRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociatePricingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePricingRulesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociatePricingRulesResponse>(request, options, cancellationToken);
        }

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
        public virtual GetBillingGroupCostReportResponse GetBillingGroupCostReport(GetBillingGroupCostReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBillingGroupCostReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillingGroupCostReportResponseUnmarshaller.Instance;

            return Invoke<GetBillingGroupCostReportResponse>(request, options);
        }


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
        public virtual Task<GetBillingGroupCostReportResponse> GetBillingGroupCostReportAsync(GetBillingGroupCostReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBillingGroupCostReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillingGroupCostReportResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBillingGroupCostReportResponse>(request, options, cancellationToken);
        }

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
        public virtual ListAccountAssociationsResponse ListAccountAssociations(ListAccountAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListAccountAssociationsResponse>(request, options);
        }


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
        public virtual Task<ListAccountAssociationsResponse> ListAccountAssociationsAsync(ListAccountAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssociationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAccountAssociationsResponse>(request, options, cancellationToken);
        }

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
        public virtual ListBillingGroupCostReportsResponse ListBillingGroupCostReports(ListBillingGroupCostReportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillingGroupCostReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillingGroupCostReportsResponseUnmarshaller.Instance;

            return Invoke<ListBillingGroupCostReportsResponse>(request, options);
        }


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
        public virtual Task<ListBillingGroupCostReportsResponse> ListBillingGroupCostReportsAsync(ListBillingGroupCostReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillingGroupCostReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillingGroupCostReportsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBillingGroupCostReportsResponse>(request, options, cancellationToken);
        }

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
        public virtual ListBillingGroupsResponse ListBillingGroups(ListBillingGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillingGroupsResponseUnmarshaller.Instance;

            return Invoke<ListBillingGroupsResponse>(request, options);
        }


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
        public virtual Task<ListBillingGroupsResponse> ListBillingGroupsAsync(ListBillingGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillingGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBillingGroupsResponse>(request, options, cancellationToken);
        }

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
        public virtual ListCustomLineItemsResponse ListCustomLineItems(ListCustomLineItemsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomLineItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomLineItemsResponseUnmarshaller.Instance;

            return Invoke<ListCustomLineItemsResponse>(request, options);
        }


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
        public virtual Task<ListCustomLineItemsResponse> ListCustomLineItemsAsync(ListCustomLineItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomLineItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomLineItemsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCustomLineItemsResponse>(request, options, cancellationToken);
        }

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
        public virtual ListCustomLineItemVersionsResponse ListCustomLineItemVersions(ListCustomLineItemVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomLineItemVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomLineItemVersionsResponseUnmarshaller.Instance;

            return Invoke<ListCustomLineItemVersionsResponse>(request, options);
        }


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
        public virtual Task<ListCustomLineItemVersionsResponse> ListCustomLineItemVersionsAsync(ListCustomLineItemVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomLineItemVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomLineItemVersionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCustomLineItemVersionsResponse>(request, options, cancellationToken);
        }

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
        public virtual ListPricingPlansResponse ListPricingPlans(ListPricingPlansRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPricingPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPricingPlansResponseUnmarshaller.Instance;

            return Invoke<ListPricingPlansResponse>(request, options);
        }


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
        public virtual Task<ListPricingPlansResponse> ListPricingPlansAsync(ListPricingPlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPricingPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPricingPlansResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPricingPlansResponse>(request, options, cancellationToken);
        }

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
        public virtual ListPricingPlansAssociatedWithPricingRuleResponse ListPricingPlansAssociatedWithPricingRule(ListPricingPlansAssociatedWithPricingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPricingPlansAssociatedWithPricingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPricingPlansAssociatedWithPricingRuleResponseUnmarshaller.Instance;

            return Invoke<ListPricingPlansAssociatedWithPricingRuleResponse>(request, options);
        }


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
        public virtual Task<ListPricingPlansAssociatedWithPricingRuleResponse> ListPricingPlansAssociatedWithPricingRuleAsync(ListPricingPlansAssociatedWithPricingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPricingPlansAssociatedWithPricingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPricingPlansAssociatedWithPricingRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPricingPlansAssociatedWithPricingRuleResponse>(request, options, cancellationToken);
        }

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
        public virtual ListPricingRulesResponse ListPricingRules(ListPricingRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPricingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPricingRulesResponseUnmarshaller.Instance;

            return Invoke<ListPricingRulesResponse>(request, options);
        }


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
        public virtual Task<ListPricingRulesResponse> ListPricingRulesAsync(ListPricingRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPricingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPricingRulesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPricingRulesResponse>(request, options, cancellationToken);
        }

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
        public virtual ListPricingRulesAssociatedToPricingPlanResponse ListPricingRulesAssociatedToPricingPlan(ListPricingRulesAssociatedToPricingPlanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPricingRulesAssociatedToPricingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPricingRulesAssociatedToPricingPlanResponseUnmarshaller.Instance;

            return Invoke<ListPricingRulesAssociatedToPricingPlanResponse>(request, options);
        }


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
        public virtual Task<ListPricingRulesAssociatedToPricingPlanResponse> ListPricingRulesAssociatedToPricingPlanAsync(ListPricingRulesAssociatedToPricingPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPricingRulesAssociatedToPricingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPricingRulesAssociatedToPricingPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPricingRulesAssociatedToPricingPlanResponse>(request, options, cancellationToken);
        }

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
        public virtual ListResourcesAssociatedToCustomLineItemResponse ListResourcesAssociatedToCustomLineItem(ListResourcesAssociatedToCustomLineItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcesAssociatedToCustomLineItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesAssociatedToCustomLineItemResponseUnmarshaller.Instance;

            return Invoke<ListResourcesAssociatedToCustomLineItemResponse>(request, options);
        }


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
        public virtual Task<ListResourcesAssociatedToCustomLineItemResponse> ListResourcesAssociatedToCustomLineItemAsync(ListResourcesAssociatedToCustomLineItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcesAssociatedToCustomLineItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesAssociatedToCustomLineItemResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListResourcesAssociatedToCustomLineItemResponse>(request, options, cancellationToken);
        }

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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

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
        public virtual UpdateBillingGroupResponse UpdateBillingGroup(UpdateBillingGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBillingGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateBillingGroupResponse>(request, options);
        }


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
        public virtual Task<UpdateBillingGroupResponse> UpdateBillingGroupAsync(UpdateBillingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBillingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateBillingGroupResponse>(request, options, cancellationToken);
        }

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
        public virtual UpdateCustomLineItemResponse UpdateCustomLineItem(UpdateCustomLineItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCustomLineItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomLineItemResponseUnmarshaller.Instance;

            return Invoke<UpdateCustomLineItemResponse>(request, options);
        }


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
        public virtual Task<UpdateCustomLineItemResponse> UpdateCustomLineItemAsync(UpdateCustomLineItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCustomLineItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomLineItemResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateCustomLineItemResponse>(request, options, cancellationToken);
        }

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
        public virtual UpdatePricingPlanResponse UpdatePricingPlan(UpdatePricingPlanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePricingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePricingPlanResponseUnmarshaller.Instance;

            return Invoke<UpdatePricingPlanResponse>(request, options);
        }


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
        public virtual Task<UpdatePricingPlanResponse> UpdatePricingPlanAsync(UpdatePricingPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePricingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePricingPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePricingPlanResponse>(request, options, cancellationToken);
        }

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
        public virtual UpdatePricingRuleResponse UpdatePricingRule(UpdatePricingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePricingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePricingRuleResponseUnmarshaller.Instance;

            return Invoke<UpdatePricingRuleResponse>(request, options);
        }


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
        public virtual Task<UpdatePricingRuleResponse> UpdatePricingRuleAsync(UpdatePricingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePricingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePricingRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePricingRuleResponse>(request, options, cancellationToken);
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