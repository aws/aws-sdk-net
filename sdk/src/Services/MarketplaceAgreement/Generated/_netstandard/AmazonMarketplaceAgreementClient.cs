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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MarketplaceAgreement.Model;
using Amazon.MarketplaceAgreement.Model.Internal.MarshallTransformations;
using Amazon.MarketplaceAgreement.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.MarketplaceAgreement
{
    /// <summary>
    /// <para>Implementation for accessing MarketplaceAgreement</para>
    ///
    /// AWS Marketplace is a curated digital catalog that customers can use to find, buy,
    /// deploy, and manage third-party software, data, and services to build solutions and
    /// run their businesses. The AWS Marketplace Agreement Service provides an API interface
    /// that helps AWS Marketplace sellers manage their product-related agreements, including
    /// listing, searching, and filtering agreements.
    /// 
    ///  
    /// <para>
    /// To manage agreements in AWS Marketplace, you must ensure that your AWS Identity and
    /// Access Management (IAM) policies and roles are set up. The user must have the required
    /// policies/permissions that allow them to carry out the actions in AWS:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>DescribeAgreement</c> – Grants permission to users to obtain detailed meta data
    /// about any of their agreements.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>GetAgreementTerms</c> – Grants permission to users to obtain details about the
    /// terms of an agreement.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>SearchAgreements</c> – Grants permission to users to search through all their
    /// agreements.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonMarketplaceAgreementClient : AmazonServiceClient, IAmazonMarketplaceAgreement
    {
        private static IServiceMetadata serviceMetadata = new AmazonMarketplaceAgreementMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with the credentials loaded from the application's
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
        public AmazonMarketplaceAgreementClient()
            : base(new AmazonMarketplaceAgreementConfig()) { }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with the credentials loaded from the application's
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
        public AmazonMarketplaceAgreementClient(RegionEndpoint region)
            : base(new AmazonMarketplaceAgreementConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMarketplaceAgreementClient Configuration Object</param>
        public AmazonMarketplaceAgreementClient(AmazonMarketplaceAgreementConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMarketplaceAgreementClient(AWSCredentials credentials)
            : this(credentials, new AmazonMarketplaceAgreementConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceAgreementClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMarketplaceAgreementConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with AWS Credentials and an
        /// AmazonMarketplaceAgreementClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMarketplaceAgreementClient Configuration Object</param>
        public AmazonMarketplaceAgreementClient(AWSCredentials credentials, AmazonMarketplaceAgreementConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMarketplaceAgreementClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMarketplaceAgreementConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceAgreementClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMarketplaceAgreementConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMarketplaceAgreementClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMarketplaceAgreementClient Configuration Object</param>
        public AmazonMarketplaceAgreementClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMarketplaceAgreementConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMarketplaceAgreementClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMarketplaceAgreementConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceAgreementClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMarketplaceAgreementConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceAgreementClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMarketplaceAgreementClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMarketplaceAgreementClient Configuration Object</param>
        public AmazonMarketplaceAgreementClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMarketplaceAgreementConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IMarketplaceAgreementPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMarketplaceAgreementPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MarketplaceAgreementPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMarketplaceAgreementEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMarketplaceAgreementAuthSchemeHandler());
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


        #region  BatchCreateBillingAdjustmentRequest

        internal virtual BatchCreateBillingAdjustmentRequestResponse BatchCreateBillingAdjustmentRequest(BatchCreateBillingAdjustmentRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateBillingAdjustmentRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateBillingAdjustmentRequestResponseUnmarshaller.Instance;

            return Invoke<BatchCreateBillingAdjustmentRequestResponse>(request, options);
        }



        /// <summary>
        /// Allows sellers (proposers) to submit billing adjustment requests for one or more invoices
        /// within an agreement. Each entry in the batch specifies an invoice and the adjustment
        /// amount. The operation returns successfully created adjustment request IDs and any
        /// errors for entries that failed validation.
        /// 
        ///  <note> 
        /// <para>
        /// Each entry requires a unique <c>clientToken</c> for idempotency. A <c>ValidationException</c>
        /// is returned if the adjustment amount exceeds the maximum refundable amount for the
        /// invoice.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateBillingAdjustmentRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateBillingAdjustmentRequest service method, as returned by MarketplaceAgreement.</returns>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-agreement-2020-03-01/BatchCreateBillingAdjustmentRequest">REST API Reference for BatchCreateBillingAdjustmentRequest Operation</seealso>
        public virtual Task<BatchCreateBillingAdjustmentRequestResponse> BatchCreateBillingAdjustmentRequestAsync(BatchCreateBillingAdjustmentRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateBillingAdjustmentRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateBillingAdjustmentRequestResponseUnmarshaller.Instance;

            return InvokeAsync<BatchCreateBillingAdjustmentRequestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelAgreementCancellationRequest

        internal virtual CancelAgreementCancellationRequestResponse CancelAgreementCancellationRequest(CancelAgreementCancellationRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelAgreementCancellationRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelAgreementCancellationRequestResponseUnmarshaller.Instance;

            return Invoke<CancelAgreementCancellationRequestResponse>(request, options);
        }



        /// <summary>
        /// Allows sellers (proposers) to withdraw an existing agreement cancellation request
        /// that is in a pending state. Once cancelled, the cancellation request transitions to
        /// <c>CANCELLED</c> status and can no longer be approved or rejected by the buyer.
        /// 
        ///  <note> 
        /// <para>
        /// Only cancellation requests in <c>PENDING_APPROVAL</c> status can be cancelled. A <c>ConflictException</c>
        /// is thrown if the cancellation request is in any other status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelAgreementCancellationRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelAgreementCancellationRequest service method, as returned by MarketplaceAgreement.</returns>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-agreement-2020-03-01/CancelAgreementCancellationRequest">REST API Reference for CancelAgreementCancellationRequest Operation</seealso>
        public virtual Task<CancelAgreementCancellationRequestResponse> CancelAgreementCancellationRequestAsync(CancelAgreementCancellationRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelAgreementCancellationRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelAgreementCancellationRequestResponseUnmarshaller.Instance;

            return InvokeAsync<CancelAgreementCancellationRequestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelAgreementPaymentRequest

        internal virtual CancelAgreementPaymentRequestResponse CancelAgreementPaymentRequest(CancelAgreementPaymentRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelAgreementPaymentRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelAgreementPaymentRequestResponseUnmarshaller.Instance;

            return Invoke<CancelAgreementPaymentRequestResponse>(request, options);
        }



        /// <summary>
        /// Allows sellers (proposers) to cancel a payment request that is in <c>PENDING_APPROVAL</c>
        /// status. Once cancelled, the payment request transitions to <c>CANCELLED</c> status
        /// and can no longer be accepted or rejected by the buyer.
        /// 
        ///  <note> 
        /// <para>
        /// Only payment requests in <c>PENDING_APPROVAL</c> status can be cancelled. A <c>ConflictException</c>
        /// is thrown if the payment request is in any other status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelAgreementPaymentRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelAgreementPaymentRequest service method, as returned by MarketplaceAgreement.</returns>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-agreement-2020-03-01/CancelAgreementPaymentRequest">REST API Reference for CancelAgreementPaymentRequest Operation</seealso>
        public virtual Task<CancelAgreementPaymentRequestResponse> CancelAgreementPaymentRequestAsync(CancelAgreementPaymentRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelAgreementPaymentRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelAgreementPaymentRequestResponseUnmarshaller.Instance;

            return InvokeAsync<CancelAgreementPaymentRequestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAgreement

        internal virtual DescribeAgreementResponse DescribeAgreement(DescribeAgreementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgreementResponseUnmarshaller.Instance;

            return Invoke<DescribeAgreementResponse>(request, options);
        }



        /// <summary>
        /// Provides details about an agreement, such as the proposer, acceptor, start date, and
        /// end date.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgreement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAgreement service method, as returned by MarketplaceAgreement.</returns>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-agreement-2020-03-01/DescribeAgreement">REST API Reference for DescribeAgreement Operation</seealso>
        public virtual Task<DescribeAgreementResponse> DescribeAgreementAsync(DescribeAgreementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgreementResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAgreementResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAgreementCancellationRequest

        internal virtual GetAgreementCancellationRequestResponse GetAgreementCancellationRequest(GetAgreementCancellationRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgreementCancellationRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgreementCancellationRequestResponseUnmarshaller.Instance;

            return Invoke<GetAgreementCancellationRequestResponse>(request, options);
        }



        /// <summary>
        /// Retrieves detailed information about a specific agreement cancellation request. Both
        /// sellers (proposers) and buyers (acceptors) can use this operation to view cancellation
        /// requests associated with their agreements.
        /// 
        ///  <note> 
        /// <para>
        /// The calling identity must be either the acceptor or proposer of the agreement. A <c>ResourceNotFoundException</c>
        /// is returned if the cancellation request does not exist.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgreementCancellationRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgreementCancellationRequest service method, as returned by MarketplaceAgreement.</returns>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-agreement-2020-03-01/GetAgreementCancellationRequest">REST API Reference for GetAgreementCancellationRequest Operation</seealso>
        public virtual Task<GetAgreementCancellationRequestResponse> GetAgreementCancellationRequestAsync(GetAgreementCancellationRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgreementCancellationRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgreementCancellationRequestResponseUnmarshaller.Instance;

            return InvokeAsync<GetAgreementCancellationRequestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAgreementPaymentRequest

        internal virtual GetAgreementPaymentRequestResponse GetAgreementPaymentRequest(GetAgreementPaymentRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgreementPaymentRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgreementPaymentRequestResponseUnmarshaller.Instance;

            return Invoke<GetAgreementPaymentRequestResponse>(request, options);
        }



        /// <summary>
        /// Retrieves detailed information about a specific payment request. Both sellers (proposers)
        /// and buyers (acceptors) can use this operation to view payment requests associated
        /// with their agreements. The response includes the current status, charge details, timestamps,
        /// and the charge ID if the request has been approved.
        /// 
        ///  <note> 
        /// <para>
        /// The calling identity must be either the acceptor or proposer of the payment request.
        /// A <c>ResourceNotFoundException</c> is returned if the payment request does not exist.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgreementPaymentRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgreementPaymentRequest service method, as returned by MarketplaceAgreement.</returns>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-agreement-2020-03-01/GetAgreementPaymentRequest">REST API Reference for GetAgreementPaymentRequest Operation</seealso>
        public virtual Task<GetAgreementPaymentRequestResponse> GetAgreementPaymentRequestAsync(GetAgreementPaymentRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgreementPaymentRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgreementPaymentRequestResponseUnmarshaller.Instance;

            return InvokeAsync<GetAgreementPaymentRequestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAgreementTerms

        internal virtual GetAgreementTermsResponse GetAgreementTerms(GetAgreementTermsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgreementTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgreementTermsResponseUnmarshaller.Instance;

            return Invoke<GetAgreementTermsResponse>(request, options);
        }



        /// <summary>
        /// Obtains details about the terms in an agreement that you participated in as proposer
        /// or acceptor.
        /// 
        ///  
        /// <para>
        /// The details include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TermType</c> – The type of term, such as <c>LegalTerm</c>, <c>RenewalTerm</c>,
        /// or <c>ConfigurableUpfrontPricingTerm</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TermID</c> – The ID of the particular term, which is common between offer and
        /// agreement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TermPayload</c> – The key information contained in the term, such as the EULA
        /// for <c>LegalTerm</c> or pricing and dimensions for various pricing terms, such as
        /// <c>ConfigurableUpfrontPricingTerm</c> or <c>UsageBasedPricingTerm</c>.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>Configuration</c> – The buyer/acceptor's selection at the time of agreement creation,
        /// such as the number of units purchased for a dimension or setting the <c>EnableAutoRenew</c>
        /// flag.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgreementTerms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgreementTerms service method, as returned by MarketplaceAgreement.</returns>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-agreement-2020-03-01/GetAgreementTerms">REST API Reference for GetAgreementTerms Operation</seealso>
        public virtual Task<GetAgreementTermsResponse> GetAgreementTermsAsync(GetAgreementTermsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAgreementTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAgreementTermsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAgreementTermsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetBillingAdjustmentRequest

        internal virtual GetBillingAdjustmentRequestResponse GetBillingAdjustmentRequest(GetBillingAdjustmentRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBillingAdjustmentRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillingAdjustmentRequestResponseUnmarshaller.Instance;

            return Invoke<GetBillingAdjustmentRequestResponse>(request, options);
        }



        /// <summary>
        /// Retrieves detailed information about a specific billing adjustment request. Sellers
        /// (proposers) can use this operation to view the status and details of a billing adjustment
        /// request they submitted.
        /// 
        ///  <note> 
        /// <para>
        /// A <c>ResourceNotFoundException</c> is returned if the billing adjustment request does
        /// not exist or the caller does not have permission to access it.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBillingAdjustmentRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBillingAdjustmentRequest service method, as returned by MarketplaceAgreement.</returns>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-agreement-2020-03-01/GetBillingAdjustmentRequest">REST API Reference for GetBillingAdjustmentRequest Operation</seealso>
        public virtual Task<GetBillingAdjustmentRequestResponse> GetBillingAdjustmentRequestAsync(GetBillingAdjustmentRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBillingAdjustmentRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBillingAdjustmentRequestResponseUnmarshaller.Instance;

            return InvokeAsync<GetBillingAdjustmentRequestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAgreementCancellationRequests

        internal virtual ListAgreementCancellationRequestsResponse ListAgreementCancellationRequests(ListAgreementCancellationRequestsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgreementCancellationRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgreementCancellationRequestsResponseUnmarshaller.Instance;

            return Invoke<ListAgreementCancellationRequestsResponse>(request, options);
        }



        /// <summary>
        /// Lists agreement cancellation requests available to you as a seller or buyer. Both
        /// sellers (proposers) and buyers (acceptors) can use this operation to find cancellation
        /// requests by specifying their party type and applying optional filters.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>PartyType</c> is a required parameter. A <c>ValidationException</c> is returned
        /// if <c>PartyType</c> is not provided. Pagination is supported through <c>maxResults</c>
        /// (1-50, default 20) and <c>nextToken</c> parameters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgreementCancellationRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgreementCancellationRequests service method, as returned by MarketplaceAgreement.</returns>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-agreement-2020-03-01/ListAgreementCancellationRequests">REST API Reference for ListAgreementCancellationRequests Operation</seealso>
        public virtual Task<ListAgreementCancellationRequestsResponse> ListAgreementCancellationRequestsAsync(ListAgreementCancellationRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgreementCancellationRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgreementCancellationRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAgreementCancellationRequestsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAgreementInvoiceLineItems

        internal virtual ListAgreementInvoiceLineItemsResponse ListAgreementInvoiceLineItems(ListAgreementInvoiceLineItemsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgreementInvoiceLineItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgreementInvoiceLineItemsResponseUnmarshaller.Instance;

            return Invoke<ListAgreementInvoiceLineItemsResponse>(request, options);
        }



        /// <summary>
        /// Allows sellers (proposers) to retrieve aggregated billing data from AWS Marketplace
        /// agreements using flexible grouping. Supports invoice-level aggregation with filtering
        /// by billing period, invoice type, and issued date.
        /// 
        ///  <note> 
        /// <para>
        /// The <c>groupBy</c> parameter is required and currently supports only <c>INVOICE_ID</c>
        /// as a value. The <c>agreementId</c> parameter is required.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgreementInvoiceLineItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgreementInvoiceLineItems service method, as returned by MarketplaceAgreement.</returns>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-agreement-2020-03-01/ListAgreementInvoiceLineItems">REST API Reference for ListAgreementInvoiceLineItems Operation</seealso>
        public virtual Task<ListAgreementInvoiceLineItemsResponse> ListAgreementInvoiceLineItemsAsync(ListAgreementInvoiceLineItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgreementInvoiceLineItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgreementInvoiceLineItemsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAgreementInvoiceLineItemsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAgreementPaymentRequests

        internal virtual ListAgreementPaymentRequestsResponse ListAgreementPaymentRequests(ListAgreementPaymentRequestsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgreementPaymentRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgreementPaymentRequestsResponseUnmarshaller.Instance;

            return Invoke<ListAgreementPaymentRequestsResponse>(request, options);
        }



        /// <summary>
        /// Lists payment requests available to you as a seller or buyer. Both sellers (proposers)
        /// and buyers (acceptors) can use this operation to find payment requests by specifying
        /// their party type and applying optional parameters.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>PartyType</c> is a required parameter. A <c>ValidationException</c> is returned
        /// if <c>PartyType</c> is not provided. Pagination is supported through <c>maxResults</c>
        /// (1-50, default 50) and <c>nextToken</c> parameters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgreementPaymentRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgreementPaymentRequests service method, as returned by MarketplaceAgreement.</returns>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-agreement-2020-03-01/ListAgreementPaymentRequests">REST API Reference for ListAgreementPaymentRequests Operation</seealso>
        public virtual Task<ListAgreementPaymentRequestsResponse> ListAgreementPaymentRequestsAsync(ListAgreementPaymentRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAgreementPaymentRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgreementPaymentRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAgreementPaymentRequestsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBillingAdjustmentRequests

        internal virtual ListBillingAdjustmentRequestsResponse ListBillingAdjustmentRequests(ListBillingAdjustmentRequestsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillingAdjustmentRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillingAdjustmentRequestsResponseUnmarshaller.Instance;

            return Invoke<ListBillingAdjustmentRequestsResponse>(request, options);
        }



        /// <summary>
        /// Lists billing adjustment requests for a specific agreement. Sellers (proposers) can
        /// use this operation to view all billing adjustment requests associated with an agreement.
        /// 
        ///  <note> 
        /// <para>
        /// Pagination is supported through <c>maxResults</c> and <c>nextToken</c> parameters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillingAdjustmentRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBillingAdjustmentRequests service method, as returned by MarketplaceAgreement.</returns>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-agreement-2020-03-01/ListBillingAdjustmentRequests">REST API Reference for ListBillingAdjustmentRequests Operation</seealso>
        public virtual Task<ListBillingAdjustmentRequestsResponse> ListBillingAdjustmentRequestsAsync(ListBillingAdjustmentRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBillingAdjustmentRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBillingAdjustmentRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBillingAdjustmentRequestsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchAgreements

        internal virtual SearchAgreementsResponse SearchAgreements(SearchAgreementsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchAgreementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchAgreementsResponseUnmarshaller.Instance;

            return Invoke<SearchAgreementsResponse>(request, options);
        }



        /// <summary>
        /// Searches across all agreements that a proposer has in AWS Marketplace. The search
        /// returns a list of agreements with basic agreement information.
        /// 
        ///  
        /// <para>
        /// The following filter combinations are supported when the <c>PartyType</c> is <c>Proposer</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AgreementType</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>ResourceType</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>ResourceType</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>ResourceType</c> + <c>Status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>ResourceType</c> + <c>Status</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>ResourceId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>ResourceId</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>ResourceId</c> + <c>Status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>ResourceId</c> + <c>Status</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>AcceptorAccountId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>AcceptorAccountId</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>AcceptorAccountId</c> + <c>Status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>AcceptorAccountId</c> + <c>Status</c> + <c>EndTime</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>AcceptorAccountId</c> + <c>OfferId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>AcceptorAccountId</c> + <c>OfferId</c> + <c>Status</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>AcceptorAccountId</c> + <c>OfferId</c> + <c>EndTime</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>AcceptorAccountId</c> + <c>OfferId</c> + <c>Status</c>
        /// + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>AcceptorAccountId</c> + <c>ResourceId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>AcceptorAccountId</c> + <c>ResourceId</c> + <c>Status</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>AcceptorAccountId</c> + <c>ResourceId</c> + <c>EndTime</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>AcceptorAccountId</c> + <c>ResourceId</c> + <c>Status</c>
        /// + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>AcceptorAccountId</c> + <c>ResourceType</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>AcceptorAccountId</c> + <c>ResourceType</c> + <c>EndTime</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>AcceptorAccountId</c> + <c>ResourceType</c> + <c>Status</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>AcceptorAccountId</c> + <c>ResourceType</c> + <c>Status</c>
        /// + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>Status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>Status</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>OfferId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>OfferId</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>OfferId</c> + <c>Status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>OfferId</c> + <c>Status</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>OfferSetId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>OfferSetId</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>OfferSetId</c> + <c>Status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AgreementType</c> + <c>OfferSetId</c> + <c>Status</c> + <c>EndTime</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  To filter by <c>EndTime</c>, you can use either <c>BeforeEndTime</c> or <c>AfterEndTime</c>.
        /// Only <c>EndTime</c> is supported for sorting.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchAgreements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchAgreements service method, as returned by MarketplaceAgreement.</returns>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-agreement-2020-03-01/SearchAgreements">REST API Reference for SearchAgreements Operation</seealso>
        public virtual Task<SearchAgreementsResponse> SearchAgreementsAsync(SearchAgreementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchAgreementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchAgreementsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchAgreementsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SendAgreementCancellationRequest

        internal virtual SendAgreementCancellationRequestResponse SendAgreementCancellationRequest(SendAgreementCancellationRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendAgreementCancellationRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendAgreementCancellationRequestResponseUnmarshaller.Instance;

            return Invoke<SendAgreementCancellationRequestResponse>(request, options);
        }



        /// <summary>
        /// Allows sellers (proposers) to submit a cancellation request for an active agreement.
        /// The cancellation request is created in <c>PENDING_APPROVAL</c> status, at which point
        /// the buyer can review it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendAgreementCancellationRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendAgreementCancellationRequest service method, as returned by MarketplaceAgreement.</returns>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-agreement-2020-03-01/SendAgreementCancellationRequest">REST API Reference for SendAgreementCancellationRequest Operation</seealso>
        public virtual Task<SendAgreementCancellationRequestResponse> SendAgreementCancellationRequestAsync(SendAgreementCancellationRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendAgreementCancellationRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendAgreementCancellationRequestResponseUnmarshaller.Instance;

            return InvokeAsync<SendAgreementCancellationRequestResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SendAgreementPaymentRequest

        internal virtual SendAgreementPaymentRequestResponse SendAgreementPaymentRequest(SendAgreementPaymentRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendAgreementPaymentRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendAgreementPaymentRequestResponseUnmarshaller.Instance;

            return Invoke<SendAgreementPaymentRequestResponse>(request, options);
        }



        /// <summary>
        /// Allows sellers (proposers) to submit a payment request to buyers (acceptors) for a
        /// specific charge amount for an agreement that includes a <c>VariablePaymentTerm</c>.
        /// The payment request is created in <c>PENDING_APPROVAL</c> status, at which point the
        /// buyer can accept or reject it.
        /// 
        ///  <note> 
        /// <para>
        /// The agreement must be active and have a <c>VariablePaymentTerm</c> to support payment
        /// requests. The <c>chargeAmount</c> must not exceed the remaining available balance
        /// under the <c>VariablePaymentTerm</c> <c>maxTotalChargeAmount</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendAgreementPaymentRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendAgreementPaymentRequest service method, as returned by MarketplaceAgreement.</returns>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceAgreement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-agreement-2020-03-01/SendAgreementPaymentRequest">REST API Reference for SendAgreementPaymentRequest Operation</seealso>
        public virtual Task<SendAgreementPaymentRequestResponse> SendAgreementPaymentRequestAsync(SendAgreementPaymentRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendAgreementPaymentRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendAgreementPaymentRequestResponseUnmarshaller.Instance;

            return InvokeAsync<SendAgreementPaymentRequestResponse>(request, options, cancellationToken);
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