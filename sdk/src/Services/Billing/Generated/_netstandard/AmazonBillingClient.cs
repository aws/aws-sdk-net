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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Billing.Model;
using Amazon.Billing.Model.Internal.MarshallTransformations;
using Amazon.Billing.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Billing
{
    /// <summary>
    /// <para>Implementation for accessing Billing</para>
    ///
    /// You can use the Billing API to programatically list the billing views available to
    /// you for a given time period. A billing view represents a set of billing data. 
    /// 
    ///  
    /// <para>
    /// The Billing API provides the following endpoint:
    /// </para>
    ///  
    /// <para>
    ///  <c>https://billing.us-east-1.api.aws</c> 
    /// </para>
    /// </summary>
    public partial class AmazonBillingClient : AmazonServiceClient, IAmazonBilling
    {
        private static IServiceMetadata serviceMetadata = new AmazonBillingMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonBillingClient with the credentials loaded from the application's
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
        public AmazonBillingClient()
            : base(new AmazonBillingConfig()) { }

        /// <summary>
        /// Constructs AmazonBillingClient with the credentials loaded from the application's
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
        public AmazonBillingClient(RegionEndpoint region)
            : base(new AmazonBillingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBillingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBillingClient Configuration Object</param>
        public AmazonBillingClient(AmazonBillingConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonBillingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBillingClient(AWSCredentials credentials)
            : this(credentials, new AmazonBillingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBillingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBillingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBillingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBillingClient with AWS Credentials and an
        /// AmazonBillingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBillingClient Configuration Object</param>
        public AmazonBillingClient(AWSCredentials credentials, AmazonBillingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBillingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBillingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBillingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBillingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBillingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBillingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBillingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBillingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBillingClient Configuration Object</param>
        public AmazonBillingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBillingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBillingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBillingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBillingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBillingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBillingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBillingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBillingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBillingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBillingClient Configuration Object</param>
        public AmazonBillingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBillingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IBillingPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBillingPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BillingPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBillingEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBillingAuthSchemeHandler());
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


        #region  AssociateSourceViews

        internal virtual AssociateSourceViewsResponse AssociateSourceViews(AssociateSourceViewsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateSourceViewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSourceViewsResponseUnmarshaller.Instance;

            return Invoke<AssociateSourceViewsResponse>(request, options);
        }



        /// <summary>
        /// Associates one or more source billing views with an existing billing view. This allows
        /// creating aggregate billing views that combine data from multiple sources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSourceViews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateSourceViews service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.BillingViewHealthStatusException">
        /// Exception thrown when a billing view's health status prevents an operation from being
        /// performed. This may occur if the billing view is in a state other than <c>HEALTHY</c>.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ServiceQuotaExceededException">
        /// You've reached the limit of resources you can create, or exceeded the size of an
        /// individual resource.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/AssociateSourceViews">REST API Reference for AssociateSourceViews Operation</seealso>
        public virtual Task<AssociateSourceViewsResponse> AssociateSourceViewsAsync(AssociateSourceViewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateSourceViewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSourceViewsResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateSourceViewsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateBillingView

        internal virtual CreateBillingViewResponse CreateBillingView(CreateBillingViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBillingViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillingViewResponseUnmarshaller.Instance;

            return Invoke<CreateBillingViewResponse>(request, options);
        }



        /// <summary>
        /// Creates a billing view with the specified billing view attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBillingView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBillingView service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.BillingViewHealthStatusException">
        /// Exception thrown when a billing view's health status prevents an operation from being
        /// performed. This may occur if the billing view is in a state other than <c>HEALTHY</c>.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ServiceQuotaExceededException">
        /// You've reached the limit of resources you can create, or exceeded the size of an
        /// individual resource.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/CreateBillingView">REST API Reference for CreateBillingView Operation</seealso>
        public virtual Task<CreateBillingViewResponse> CreateBillingViewAsync(CreateBillingViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBillingViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBillingViewResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBillingViewResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteBillingView

        internal virtual DeleteBillingViewResponse DeleteBillingView(DeleteBillingViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBillingViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBillingViewResponseUnmarshaller.Instance;

            return Invoke<DeleteBillingViewResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified billing view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillingView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBillingView service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/DeleteBillingView">REST API Reference for DeleteBillingView Operation</seealso>
        public virtual Task<DeleteBillingViewResponse> DeleteBillingViewAsync(DeleteBillingViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBillingViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBillingViewResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBillingViewResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateSourceViews

        internal virtual DisassociateSourceViewsResponse DisassociateSourceViews(DisassociateSourceViewsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateSourceViewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSourceViewsResponseUnmarshaller.Instance;

            return Invoke<DisassociateSourceViewsResponse>(request, options);
        }



        /// <summary>
        /// Removes the association between one or more source billing views and an existing
        /// billing view. This allows modifying the composition of aggregate billing views.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSourceViews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateSourceViews service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.BillingViewHealthStatusException">
        /// Exception thrown when a billing view's health status prevents an operation from being
        /// performed. This may occur if the billing view is in a state other than <c>HEALTHY</c>.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/DisassociateSourceViews">REST API Reference for DisassociateSourceViews Operation</seealso>
        public virtual Task<DisassociateSourceViewsResponse> DisassociateSourceViewsAsync(DisassociateSourceViewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateSourceViewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSourceViewsResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateSourceViewsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetBillingView

        internal virtual GetBillingViewResponse GetBillingView(GetBillingViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBillingViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillingViewResponseUnmarshaller.Instance;

            return Invoke<GetBillingViewResponse>(request, options);
        }



        /// <summary>
        /// Returns the metadata associated to the specified billing view ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBillingView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBillingView service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/GetBillingView">REST API Reference for GetBillingView Operation</seealso>
        public virtual Task<GetBillingViewResponse> GetBillingViewAsync(GetBillingViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBillingViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillingViewResponseUnmarshaller.Instance;

            return InvokeAsync<GetBillingViewResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResourcePolicy

        internal virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns the resource-based policy document attached to the resource in <c>JSON</c>
        /// format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBillingViews

        internal virtual ListBillingViewsResponse ListBillingViews(ListBillingViewsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillingViewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillingViewsResponseUnmarshaller.Instance;

            return Invoke<ListBillingViewsResponse>(request, options);
        }



        /// <summary>
        /// Lists the billing views available for a given time period. 
        /// 
        ///  
        /// <para>
        /// Every Amazon Web Services account has a unique <c>PRIMARY</c> billing view that represents
        /// the billing data available by default. Accounts that use Billing Conductor also have
        /// <c>BILLING_GROUP</c> billing views representing pro forma costs associated with each
        /// created billing group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillingViews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBillingViews service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/ListBillingViews">REST API Reference for ListBillingViews Operation</seealso>
        public virtual Task<ListBillingViewsResponse> ListBillingViewsAsync(ListBillingViewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillingViewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillingViewsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBillingViewsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSourceViewsForBillingView

        internal virtual ListSourceViewsForBillingViewResponse ListSourceViewsForBillingView(ListSourceViewsForBillingViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSourceViewsForBillingViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceViewsForBillingViewResponseUnmarshaller.Instance;

            return Invoke<ListSourceViewsForBillingViewResponse>(request, options);
        }



        /// <summary>
        /// Lists the source views (managed Amazon Web Services billing views) associated with
        /// the billing view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceViewsForBillingView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSourceViewsForBillingView service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/ListSourceViewsForBillingView">REST API Reference for ListSourceViewsForBillingView Operation</seealso>
        public virtual Task<ListSourceViewsForBillingViewResponse> ListSourceViewsForBillingViewAsync(ListSourceViewsForBillingViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSourceViewsForBillingViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSourceViewsForBillingViewResponseUnmarshaller.Instance;

            return InvokeAsync<ListSourceViewsForBillingViewResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists tags associated with the billing view resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// An API operation for adding one or more tags (key-value pairs) to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes one or more tags from a resource. Specify only tag keys in your request.
        /// Don't specify the value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateBillingView

        internal virtual UpdateBillingViewResponse UpdateBillingView(UpdateBillingViewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBillingViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBillingViewResponseUnmarshaller.Instance;

            return Invoke<UpdateBillingViewResponse>(request, options);
        }



        /// <summary>
        /// An API to update the attributes of the billing view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillingView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBillingView service method, as returned by Billing.</returns>
        /// <exception cref="Amazon.Billing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.BillingViewHealthStatusException">
        /// Exception thrown when a billing view's health status prevents an operation from being
        /// performed. This may occur if the billing view is in a state other than <c>HEALTHY</c>.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.InternalServerException">
        /// The request processing failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ServiceQuotaExceededException">
        /// You've reached the limit of resources you can create, or exceeded the size of an
        /// individual resource.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Billing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/billing-2023-09-07/UpdateBillingView">REST API Reference for UpdateBillingView Operation</seealso>
        public virtual Task<UpdateBillingViewResponse> UpdateBillingViewAsync(UpdateBillingViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBillingViewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBillingViewResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBillingViewResponse>(request, options, cancellationToken);
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