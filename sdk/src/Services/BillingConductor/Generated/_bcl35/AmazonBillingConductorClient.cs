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
using System.Net;

using Amazon.BillingConductor.Model;
using Amazon.BillingConductor.Model.Internal.MarshallTransformations;
using Amazon.BillingConductor.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
#endif
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBillingConductorConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBillingConductorConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBillingConductorEndpointResolver());
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
        public virtual IAsyncResult BeginAssociateAccounts(AssociateAccountsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAccountsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAccounts.</param>
        /// 
        /// <returns>Returns a  AssociateAccountsResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/AssociateAccounts">REST API Reference for AssociateAccounts Operation</seealso>
        public virtual AssociateAccountsResponse EndAssociateAccounts(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateAccountsResponse>(asyncResult);
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
        public virtual IAsyncResult BeginAssociatePricingRules(AssociatePricingRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociatePricingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociatePricingRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePricingRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePricingRules.</param>
        /// 
        /// <returns>Returns a  AssociatePricingRulesResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/AssociatePricingRules">REST API Reference for AssociatePricingRules Operation</seealso>
        public virtual AssociatePricingRulesResponse EndAssociatePricingRules(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociatePricingRulesResponse>(asyncResult);
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
        public virtual IAsyncResult BeginBatchAssociateResourcesToCustomLineItem(BatchAssociateResourcesToCustomLineItemRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateResourcesToCustomLineItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateResourcesToCustomLineItemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAssociateResourcesToCustomLineItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAssociateResourcesToCustomLineItem.</param>
        /// 
        /// <returns>Returns a  BatchAssociateResourcesToCustomLineItemResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/BatchAssociateResourcesToCustomLineItem">REST API Reference for BatchAssociateResourcesToCustomLineItem Operation</seealso>
        public virtual BatchAssociateResourcesToCustomLineItemResponse EndBatchAssociateResourcesToCustomLineItem(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchAssociateResourcesToCustomLineItemResponse>(asyncResult);
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
        public virtual IAsyncResult BeginBatchDisassociateResourcesFromCustomLineItem(BatchDisassociateResourcesFromCustomLineItemRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateResourcesFromCustomLineItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateResourcesFromCustomLineItemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDisassociateResourcesFromCustomLineItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDisassociateResourcesFromCustomLineItem.</param>
        /// 
        /// <returns>Returns a  BatchDisassociateResourcesFromCustomLineItemResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/BatchDisassociateResourcesFromCustomLineItem">REST API Reference for BatchDisassociateResourcesFromCustomLineItem Operation</seealso>
        public virtual BatchDisassociateResourcesFromCustomLineItemResponse EndBatchDisassociateResourcesFromCustomLineItem(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDisassociateResourcesFromCustomLineItemResponse>(asyncResult);
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
        public virtual IAsyncResult BeginCreateBillingGroup(CreateBillingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBillingGroup.</param>
        /// 
        /// <returns>Returns a  CreateBillingGroupResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreateBillingGroup">REST API Reference for CreateBillingGroup Operation</seealso>
        public virtual CreateBillingGroupResponse EndCreateBillingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBillingGroupResponse>(asyncResult);
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
        public virtual IAsyncResult BeginCreateCustomLineItem(CreateCustomLineItemRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomLineItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomLineItemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomLineItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomLineItem.</param>
        /// 
        /// <returns>Returns a  CreateCustomLineItemResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreateCustomLineItem">REST API Reference for CreateCustomLineItem Operation</seealso>
        public virtual CreateCustomLineItemResponse EndCreateCustomLineItem(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCustomLineItemResponse>(asyncResult);
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
        public virtual IAsyncResult BeginCreatePricingPlan(CreatePricingPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePricingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePricingPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePricingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePricingPlan.</param>
        /// 
        /// <returns>Returns a  CreatePricingPlanResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreatePricingPlan">REST API Reference for CreatePricingPlan Operation</seealso>
        public virtual CreatePricingPlanResponse EndCreatePricingPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePricingPlanResponse>(asyncResult);
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
        public virtual IAsyncResult BeginCreatePricingRule(CreatePricingRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePricingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePricingRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePricingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePricingRule.</param>
        /// 
        /// <returns>Returns a  CreatePricingRuleResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/CreatePricingRule">REST API Reference for CreatePricingRule Operation</seealso>
        public virtual CreatePricingRuleResponse EndCreatePricingRule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePricingRuleResponse>(asyncResult);
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
        public virtual IAsyncResult BeginDeleteBillingGroup(DeleteBillingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBillingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBillingGroup.</param>
        /// 
        /// <returns>Returns a  DeleteBillingGroupResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeleteBillingGroup">REST API Reference for DeleteBillingGroup Operation</seealso>
        public virtual DeleteBillingGroupResponse EndDeleteBillingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBillingGroupResponse>(asyncResult);
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
        public virtual IAsyncResult BeginDeleteCustomLineItem(DeleteCustomLineItemRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomLineItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomLineItemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomLineItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomLineItem.</param>
        /// 
        /// <returns>Returns a  DeleteCustomLineItemResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeleteCustomLineItem">REST API Reference for DeleteCustomLineItem Operation</seealso>
        public virtual DeleteCustomLineItemResponse EndDeleteCustomLineItem(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCustomLineItemResponse>(asyncResult);
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
        public virtual IAsyncResult BeginDeletePricingPlan(DeletePricingPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePricingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePricingPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePricingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePricingPlan.</param>
        /// 
        /// <returns>Returns a  DeletePricingPlanResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeletePricingPlan">REST API Reference for DeletePricingPlan Operation</seealso>
        public virtual DeletePricingPlanResponse EndDeletePricingPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePricingPlanResponse>(asyncResult);
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
        public virtual IAsyncResult BeginDeletePricingRule(DeletePricingRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePricingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePricingRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePricingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePricingRule.</param>
        /// 
        /// <returns>Returns a  DeletePricingRuleResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DeletePricingRule">REST API Reference for DeletePricingRule Operation</seealso>
        public virtual DeletePricingRuleResponse EndDeletePricingRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePricingRuleResponse>(asyncResult);
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
        public virtual IAsyncResult BeginDisassociateAccounts(DisassociateAccountsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAccountsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAccounts.</param>
        /// 
        /// <returns>Returns a  DisassociateAccountsResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DisassociateAccounts">REST API Reference for DisassociateAccounts Operation</seealso>
        public virtual DisassociateAccountsResponse EndDisassociateAccounts(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateAccountsResponse>(asyncResult);
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
        public virtual IAsyncResult BeginDisassociatePricingRules(DisassociatePricingRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociatePricingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociatePricingRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePricingRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePricingRules.</param>
        /// 
        /// <returns>Returns a  DisassociatePricingRulesResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/DisassociatePricingRules">REST API Reference for DisassociatePricingRules Operation</seealso>
        public virtual DisassociatePricingRulesResponse EndDisassociatePricingRules(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociatePricingRulesResponse>(asyncResult);
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
        public virtual IAsyncResult BeginGetBillingGroupCostReport(GetBillingGroupCostReportRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBillingGroupCostReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillingGroupCostReportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBillingGroupCostReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBillingGroupCostReport.</param>
        /// 
        /// <returns>Returns a  GetBillingGroupCostReportResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/GetBillingGroupCostReport">REST API Reference for GetBillingGroupCostReport Operation</seealso>
        public virtual GetBillingGroupCostReportResponse EndGetBillingGroupCostReport(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBillingGroupCostReportResponse>(asyncResult);
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
        public virtual IAsyncResult BeginListAccountAssociations(ListAccountAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountAssociations.</param>
        /// 
        /// <returns>Returns a  ListAccountAssociationsResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListAccountAssociations">REST API Reference for ListAccountAssociations Operation</seealso>
        public virtual ListAccountAssociationsResponse EndListAccountAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccountAssociationsResponse>(asyncResult);
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
        public virtual IAsyncResult BeginListBillingGroupCostReports(ListBillingGroupCostReportsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillingGroupCostReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillingGroupCostReportsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillingGroupCostReports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillingGroupCostReports.</param>
        /// 
        /// <returns>Returns a  ListBillingGroupCostReportsResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListBillingGroupCostReports">REST API Reference for ListBillingGroupCostReports Operation</seealso>
        public virtual ListBillingGroupCostReportsResponse EndListBillingGroupCostReports(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBillingGroupCostReportsResponse>(asyncResult);
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
        public virtual IAsyncResult BeginListBillingGroups(ListBillingGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillingGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillingGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillingGroups.</param>
        /// 
        /// <returns>Returns a  ListBillingGroupsResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListBillingGroups">REST API Reference for ListBillingGroups Operation</seealso>
        public virtual ListBillingGroupsResponse EndListBillingGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBillingGroupsResponse>(asyncResult);
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
        public virtual IAsyncResult BeginListCustomLineItems(ListCustomLineItemsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomLineItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomLineItemsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomLineItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomLineItems.</param>
        /// 
        /// <returns>Returns a  ListCustomLineItemsResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListCustomLineItems">REST API Reference for ListCustomLineItems Operation</seealso>
        public virtual ListCustomLineItemsResponse EndListCustomLineItems(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCustomLineItemsResponse>(asyncResult);
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
        public virtual IAsyncResult BeginListCustomLineItemVersions(ListCustomLineItemVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomLineItemVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomLineItemVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomLineItemVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomLineItemVersions.</param>
        /// 
        /// <returns>Returns a  ListCustomLineItemVersionsResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListCustomLineItemVersions">REST API Reference for ListCustomLineItemVersions Operation</seealso>
        public virtual ListCustomLineItemVersionsResponse EndListCustomLineItemVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCustomLineItemVersionsResponse>(asyncResult);
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
        public virtual IAsyncResult BeginListPricingPlans(ListPricingPlansRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPricingPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPricingPlansResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPricingPlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPricingPlans.</param>
        /// 
        /// <returns>Returns a  ListPricingPlansResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingPlans">REST API Reference for ListPricingPlans Operation</seealso>
        public virtual ListPricingPlansResponse EndListPricingPlans(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPricingPlansResponse>(asyncResult);
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
        public virtual IAsyncResult BeginListPricingPlansAssociatedWithPricingRule(ListPricingPlansAssociatedWithPricingRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPricingPlansAssociatedWithPricingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPricingPlansAssociatedWithPricingRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPricingPlansAssociatedWithPricingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPricingPlansAssociatedWithPricingRule.</param>
        /// 
        /// <returns>Returns a  ListPricingPlansAssociatedWithPricingRuleResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingPlansAssociatedWithPricingRule">REST API Reference for ListPricingPlansAssociatedWithPricingRule Operation</seealso>
        public virtual ListPricingPlansAssociatedWithPricingRuleResponse EndListPricingPlansAssociatedWithPricingRule(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPricingPlansAssociatedWithPricingRuleResponse>(asyncResult);
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
        public virtual IAsyncResult BeginListPricingRules(ListPricingRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPricingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPricingRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPricingRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPricingRules.</param>
        /// 
        /// <returns>Returns a  ListPricingRulesResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingRules">REST API Reference for ListPricingRules Operation</seealso>
        public virtual ListPricingRulesResponse EndListPricingRules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPricingRulesResponse>(asyncResult);
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
        public virtual IAsyncResult BeginListPricingRulesAssociatedToPricingPlan(ListPricingRulesAssociatedToPricingPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPricingRulesAssociatedToPricingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPricingRulesAssociatedToPricingPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPricingRulesAssociatedToPricingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPricingRulesAssociatedToPricingPlan.</param>
        /// 
        /// <returns>Returns a  ListPricingRulesAssociatedToPricingPlanResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListPricingRulesAssociatedToPricingPlan">REST API Reference for ListPricingRulesAssociatedToPricingPlan Operation</seealso>
        public virtual ListPricingRulesAssociatedToPricingPlanResponse EndListPricingRulesAssociatedToPricingPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPricingRulesAssociatedToPricingPlanResponse>(asyncResult);
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
        public virtual IAsyncResult BeginListResourcesAssociatedToCustomLineItem(ListResourcesAssociatedToCustomLineItemRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcesAssociatedToCustomLineItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcesAssociatedToCustomLineItemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourcesAssociatedToCustomLineItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourcesAssociatedToCustomLineItem.</param>
        /// 
        /// <returns>Returns a  ListResourcesAssociatedToCustomLineItemResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListResourcesAssociatedToCustomLineItem">REST API Reference for ListResourcesAssociatedToCustomLineItem Operation</seealso>
        public virtual ListResourcesAssociatedToCustomLineItemResponse EndListResourcesAssociatedToCustomLineItem(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourcesAssociatedToCustomLineItemResponse>(asyncResult);
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
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
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
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
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
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
        public virtual IAsyncResult BeginUpdateBillingGroup(UpdateBillingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBillingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBillingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBillingGroup.</param>
        /// 
        /// <returns>Returns a  UpdateBillingGroupResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdateBillingGroup">REST API Reference for UpdateBillingGroup Operation</seealso>
        public virtual UpdateBillingGroupResponse EndUpdateBillingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBillingGroupResponse>(asyncResult);
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
        public virtual IAsyncResult BeginUpdateCustomLineItem(UpdateCustomLineItemRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCustomLineItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomLineItemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCustomLineItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCustomLineItem.</param>
        /// 
        /// <returns>Returns a  UpdateCustomLineItemResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdateCustomLineItem">REST API Reference for UpdateCustomLineItem Operation</seealso>
        public virtual UpdateCustomLineItemResponse EndUpdateCustomLineItem(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCustomLineItemResponse>(asyncResult);
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
        public virtual IAsyncResult BeginUpdatePricingPlan(UpdatePricingPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePricingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePricingPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePricingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePricingPlan.</param>
        /// 
        /// <returns>Returns a  UpdatePricingPlanResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdatePricingPlan">REST API Reference for UpdatePricingPlan Operation</seealso>
        public virtual UpdatePricingPlanResponse EndUpdatePricingPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePricingPlanResponse>(asyncResult);
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
        public virtual IAsyncResult BeginUpdatePricingRule(UpdatePricingRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePricingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePricingRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePricingRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePricingRule.</param>
        /// 
        /// <returns>Returns a  UpdatePricingRuleResult from BillingConductor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billingconductor-2021-07-30/UpdatePricingRule">REST API Reference for UpdatePricingRule Operation</seealso>
        public virtual UpdatePricingRuleResponse EndUpdatePricingRule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePricingRuleResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonBillingConductorEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}