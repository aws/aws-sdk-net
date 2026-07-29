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
 * Do not modify this file. This file is generated from the partnercentral-revenue-measurement-2022-07-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.PartnerCentralRevenueMeasurement.Model;
using Amazon.PartnerCentralRevenueMeasurement.Model.Internal.MarshallTransformations;
using Amazon.PartnerCentralRevenueMeasurement.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.PartnerCentralRevenueMeasurement
{
    /// <summary>
    /// <para>Implementation for accessing PartnerCentralRevenueMeasurement</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// AWS Partner Central Revenue Measurement API for creating, managing, and tracking revenue
    /// attributions and their allocations with deal entities such as offers and opportunities.
    /// </summary>
    public partial class AmazonPartnerCentralRevenueMeasurementClient : AmazonServiceClient, IAmazonPartnerCentralRevenueMeasurement
    {
        private static IServiceMetadata serviceMetadata = new AmazonPartnerCentralRevenueMeasurementMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonPartnerCentralRevenueMeasurementClient with the credentials loaded from the application's
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
        public AmazonPartnerCentralRevenueMeasurementClient()
            : base(new AmazonPartnerCentralRevenueMeasurementConfig()) { }

        /// <summary>
        /// Constructs AmazonPartnerCentralRevenueMeasurementClient with the credentials loaded from the application's
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
        public AmazonPartnerCentralRevenueMeasurementClient(RegionEndpoint region)
            : base(new AmazonPartnerCentralRevenueMeasurementConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPartnerCentralRevenueMeasurementClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPartnerCentralRevenueMeasurementClient Configuration Object</param>
        public AmazonPartnerCentralRevenueMeasurementClient(AmazonPartnerCentralRevenueMeasurementConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonPartnerCentralRevenueMeasurementClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPartnerCentralRevenueMeasurementClient(AWSCredentials credentials)
            : this(credentials, new AmazonPartnerCentralRevenueMeasurementConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralRevenueMeasurementClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralRevenueMeasurementClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPartnerCentralRevenueMeasurementConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralRevenueMeasurementClient with AWS Credentials and an
        /// AmazonPartnerCentralRevenueMeasurementClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPartnerCentralRevenueMeasurementClient Configuration Object</param>
        public AmazonPartnerCentralRevenueMeasurementClient(AWSCredentials credentials, AmazonPartnerCentralRevenueMeasurementConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralRevenueMeasurementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPartnerCentralRevenueMeasurementClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPartnerCentralRevenueMeasurementConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralRevenueMeasurementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralRevenueMeasurementClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPartnerCentralRevenueMeasurementConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralRevenueMeasurementClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPartnerCentralRevenueMeasurementClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPartnerCentralRevenueMeasurementClient Configuration Object</param>
        public AmazonPartnerCentralRevenueMeasurementClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPartnerCentralRevenueMeasurementConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralRevenueMeasurementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPartnerCentralRevenueMeasurementClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPartnerCentralRevenueMeasurementConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralRevenueMeasurementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralRevenueMeasurementClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPartnerCentralRevenueMeasurementConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralRevenueMeasurementClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPartnerCentralRevenueMeasurementClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPartnerCentralRevenueMeasurementClient Configuration Object</param>
        public AmazonPartnerCentralRevenueMeasurementClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPartnerCentralRevenueMeasurementConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IPartnerCentralRevenueMeasurementPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPartnerCentralRevenueMeasurementPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PartnerCentralRevenueMeasurementPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPartnerCentralRevenueMeasurementEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPartnerCentralRevenueMeasurementAuthSchemeHandler());
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


        #region  CreateMarketplaceRevenueShare

        internal virtual CreateMarketplaceRevenueShareResponse CreateMarketplaceRevenueShare(CreateMarketplaceRevenueShareRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMarketplaceRevenueShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMarketplaceRevenueShareResponseUnmarshaller.Instance;

            return Invoke<CreateMarketplaceRevenueShareResponse>(request, options);
        }



        /// <summary>
        /// Creates a new marketplace revenue share resource in the specified catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMarketplaceRevenueShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMarketplaceRevenueShare service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/CreateMarketplaceRevenueShare">REST API Reference for CreateMarketplaceRevenueShare Operation</seealso>
        public virtual Task<CreateMarketplaceRevenueShareResponse> CreateMarketplaceRevenueShareAsync(CreateMarketplaceRevenueShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMarketplaceRevenueShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMarketplaceRevenueShareResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMarketplaceRevenueShareResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateMarketplaceRevenueShareAllocation

        internal virtual CreateMarketplaceRevenueShareAllocationResponse CreateMarketplaceRevenueShareAllocation(CreateMarketplaceRevenueShareAllocationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMarketplaceRevenueShareAllocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMarketplaceRevenueShareAllocationResponseUnmarshaller.Instance;

            return Invoke<CreateMarketplaceRevenueShareAllocationResponse>(request, options);
        }



        /// <summary>
        /// Creates a new marketplace revenue share allocation for the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMarketplaceRevenueShareAllocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMarketplaceRevenueShareAllocation service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/CreateMarketplaceRevenueShareAllocation">REST API Reference for CreateMarketplaceRevenueShareAllocation Operation</seealso>
        public virtual Task<CreateMarketplaceRevenueShareAllocationResponse> CreateMarketplaceRevenueShareAllocationAsync(CreateMarketplaceRevenueShareAllocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMarketplaceRevenueShareAllocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMarketplaceRevenueShareAllocationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMarketplaceRevenueShareAllocationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRevenueAttribution

        internal virtual CreateRevenueAttributionResponse CreateRevenueAttribution(CreateRevenueAttributionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRevenueAttributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRevenueAttributionResponseUnmarshaller.Instance;

            return Invoke<CreateRevenueAttributionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new revenue attribution record in the specified catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRevenueAttribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRevenueAttribution service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/CreateRevenueAttribution">REST API Reference for CreateRevenueAttribution Operation</seealso>
        public virtual Task<CreateRevenueAttributionResponse> CreateRevenueAttributionAsync(CreateRevenueAttributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRevenueAttributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRevenueAttributionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRevenueAttributionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMarketplaceRevenueShare

        internal virtual GetMarketplaceRevenueShareResponse GetMarketplaceRevenueShare(GetMarketplaceRevenueShareRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMarketplaceRevenueShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMarketplaceRevenueShareResponseUnmarshaller.Instance;

            return Invoke<GetMarketplaceRevenueShareResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of a specific marketplace revenue share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMarketplaceRevenueShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMarketplaceRevenueShare service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/GetMarketplaceRevenueShare">REST API Reference for GetMarketplaceRevenueShare Operation</seealso>
        public virtual Task<GetMarketplaceRevenueShareResponse> GetMarketplaceRevenueShareAsync(GetMarketplaceRevenueShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMarketplaceRevenueShareRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMarketplaceRevenueShareResponseUnmarshaller.Instance;

            return InvokeAsync<GetMarketplaceRevenueShareResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetMarketplaceRevenueShareAllocation

        internal virtual GetMarketplaceRevenueShareAllocationResponse GetMarketplaceRevenueShareAllocation(GetMarketplaceRevenueShareAllocationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMarketplaceRevenueShareAllocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMarketplaceRevenueShareAllocationResponseUnmarshaller.Instance;

            return Invoke<GetMarketplaceRevenueShareAllocationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of a specific marketplace revenue share allocation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMarketplaceRevenueShareAllocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMarketplaceRevenueShareAllocation service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/GetMarketplaceRevenueShareAllocation">REST API Reference for GetMarketplaceRevenueShareAllocation Operation</seealso>
        public virtual Task<GetMarketplaceRevenueShareAllocationResponse> GetMarketplaceRevenueShareAllocationAsync(GetMarketplaceRevenueShareAllocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMarketplaceRevenueShareAllocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMarketplaceRevenueShareAllocationResponseUnmarshaller.Instance;

            return InvokeAsync<GetMarketplaceRevenueShareAllocationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRevenueAttribution

        internal virtual GetRevenueAttributionResponse GetRevenueAttribution(GetRevenueAttributionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRevenueAttributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevenueAttributionResponseUnmarshaller.Instance;

            return Invoke<GetRevenueAttributionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of a specific revenue attribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevenueAttribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRevenueAttribution service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/GetRevenueAttribution">REST API Reference for GetRevenueAttribution Operation</seealso>
        public virtual Task<GetRevenueAttributionResponse> GetRevenueAttributionAsync(GetRevenueAttributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRevenueAttributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevenueAttributionResponseUnmarshaller.Instance;

            return InvokeAsync<GetRevenueAttributionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRevenueAttributionAllocation

        internal virtual GetRevenueAttributionAllocationResponse GetRevenueAttributionAllocation(GetRevenueAttributionAllocationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRevenueAttributionAllocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevenueAttributionAllocationResponseUnmarshaller.Instance;

            return Invoke<GetRevenueAttributionAllocationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a single allocation by its RevenueAttributionAllocationId. Supports optional
        /// point-in-time version queries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevenueAttributionAllocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRevenueAttributionAllocation service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/GetRevenueAttributionAllocation">REST API Reference for GetRevenueAttributionAllocation Operation</seealso>
        public virtual Task<GetRevenueAttributionAllocationResponse> GetRevenueAttributionAllocationAsync(GetRevenueAttributionAllocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRevenueAttributionAllocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevenueAttributionAllocationResponseUnmarshaller.Instance;

            return InvokeAsync<GetRevenueAttributionAllocationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRevenueAttributionAllocationsTask

        internal virtual GetRevenueAttributionAllocationsTaskResponse GetRevenueAttributionAllocationsTask(GetRevenueAttributionAllocationsTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRevenueAttributionAllocationsTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevenueAttributionAllocationsTaskResponseUnmarshaller.Instance;

            return Invoke<GetRevenueAttributionAllocationsTaskResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current status of a previously submitted allocations task. When COMPLETE,
        /// includes the latest revision. When FAILED, includes error details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevenueAttributionAllocationsTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRevenueAttributionAllocationsTask service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/GetRevenueAttributionAllocationsTask">REST API Reference for GetRevenueAttributionAllocationsTask Operation</seealso>
        public virtual Task<GetRevenueAttributionAllocationsTaskResponse> GetRevenueAttributionAllocationsTaskAsync(GetRevenueAttributionAllocationsTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRevenueAttributionAllocationsTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRevenueAttributionAllocationsTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetRevenueAttributionAllocationsTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMarketplaceRevenueShareAllocations

        internal virtual ListMarketplaceRevenueShareAllocationsResponse ListMarketplaceRevenueShareAllocations(ListMarketplaceRevenueShareAllocationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMarketplaceRevenueShareAllocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMarketplaceRevenueShareAllocationsResponseUnmarshaller.Instance;

            return Invoke<ListMarketplaceRevenueShareAllocationsResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of allocations under a marketplace revenue share, with optional
        /// filtering by status and effective date range. Supports historical reads at a specific
        /// share revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMarketplaceRevenueShareAllocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMarketplaceRevenueShareAllocations service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/ListMarketplaceRevenueShareAllocations">REST API Reference for ListMarketplaceRevenueShareAllocations Operation</seealso>
        public virtual Task<ListMarketplaceRevenueShareAllocationsResponse> ListMarketplaceRevenueShareAllocationsAsync(ListMarketplaceRevenueShareAllocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMarketplaceRevenueShareAllocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMarketplaceRevenueShareAllocationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMarketplaceRevenueShareAllocationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListMarketplaceRevenueShares

        internal virtual ListMarketplaceRevenueSharesResponse ListMarketplaceRevenueShares(ListMarketplaceRevenueSharesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMarketplaceRevenueSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMarketplaceRevenueSharesResponseUnmarshaller.Instance;

            return Invoke<ListMarketplaceRevenueSharesResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of marketplace revenue shares with optional filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMarketplaceRevenueShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMarketplaceRevenueShares service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/ListMarketplaceRevenueShares">REST API Reference for ListMarketplaceRevenueShares Operation</seealso>
        public virtual Task<ListMarketplaceRevenueSharesResponse> ListMarketplaceRevenueSharesAsync(ListMarketplaceRevenueSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMarketplaceRevenueSharesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMarketplaceRevenueSharesResponseUnmarshaller.Instance;

            return InvokeAsync<ListMarketplaceRevenueSharesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRevenueAttributionAllocations

        internal virtual ListRevenueAttributionAllocationsResponse ListRevenueAttributionAllocations(ListRevenueAttributionAllocationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRevenueAttributionAllocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRevenueAttributionAllocationsResponseUnmarshaller.Instance;

            return Invoke<ListRevenueAttributionAllocationsResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of committed allocations with support for filtering by entity,
        /// customer, status, or date range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRevenueAttributionAllocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRevenueAttributionAllocations service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/ListRevenueAttributionAllocations">REST API Reference for ListRevenueAttributionAllocations Operation</seealso>
        public virtual Task<ListRevenueAttributionAllocationsResponse> ListRevenueAttributionAllocationsAsync(ListRevenueAttributionAllocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRevenueAttributionAllocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRevenueAttributionAllocationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRevenueAttributionAllocationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRevenueAttributions

        internal virtual ListRevenueAttributionsResponse ListRevenueAttributions(ListRevenueAttributionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRevenueAttributionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRevenueAttributionsResponseUnmarshaller.Instance;

            return Invoke<ListRevenueAttributionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of revenue attributions with optional filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRevenueAttributions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRevenueAttributions service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/ListRevenueAttributions">REST API Reference for ListRevenueAttributions Operation</seealso>
        public virtual Task<ListRevenueAttributionsResponse> ListRevenueAttributionsAsync(ListRevenueAttributionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRevenueAttributionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRevenueAttributionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRevenueAttributionsResponse>(request, options, cancellationToken);
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
        /// Returns the tags associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartRevenueAttributionAllocationsTask

        internal virtual StartRevenueAttributionAllocationsTaskResponse StartRevenueAttributionAllocationsTask(StartRevenueAttributionAllocationsTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartRevenueAttributionAllocationsTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRevenueAttributionAllocationsTaskResponseUnmarshaller.Instance;

            return Invoke<StartRevenueAttributionAllocationsTaskResponse>(request, options);
        }



        /// <summary>
        /// Submits a batch of up to 250 allocation changes (CREATE and/or UPDATE) for asynchronous
        /// processing. Returns a TaskId for tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRevenueAttributionAllocationsTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartRevenueAttributionAllocationsTask service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/StartRevenueAttributionAllocationsTask">REST API Reference for StartRevenueAttributionAllocationsTask Operation</seealso>
        public virtual Task<StartRevenueAttributionAllocationsTaskResponse> StartRevenueAttributionAllocationsTaskAsync(StartRevenueAttributionAllocationsTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartRevenueAttributionAllocationsTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRevenueAttributionAllocationsTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartRevenueAttributionAllocationsTaskResponse>(request, options, cancellationToken);
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
        /// Adds or overwrites one or more tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateMarketplaceRevenueShareAllocation

        internal virtual UpdateMarketplaceRevenueShareAllocationResponse UpdateMarketplaceRevenueShareAllocation(UpdateMarketplaceRevenueShareAllocationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMarketplaceRevenueShareAllocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMarketplaceRevenueShareAllocationResponseUnmarshaller.Instance;

            return Invoke<UpdateMarketplaceRevenueShareAllocationResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing marketplace revenue share allocation. Supports modifying effective
        /// dates, revenue share percentage, and status with time-based mutability rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMarketplaceRevenueShareAllocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMarketplaceRevenueShareAllocation service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/UpdateMarketplaceRevenueShareAllocation">REST API Reference for UpdateMarketplaceRevenueShareAllocation Operation</seealso>
        public virtual Task<UpdateMarketplaceRevenueShareAllocationResponse> UpdateMarketplaceRevenueShareAllocationAsync(UpdateMarketplaceRevenueShareAllocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMarketplaceRevenueShareAllocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMarketplaceRevenueShareAllocationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMarketplaceRevenueShareAllocationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRevenueAttribution

        internal virtual UpdateRevenueAttributionResponse UpdateRevenueAttribution(UpdateRevenueAttributionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRevenueAttributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRevenueAttributionResponseUnmarshaller.Instance;

            return Invoke<UpdateRevenueAttributionResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing revenue attribution record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRevenueAttribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRevenueAttribution service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/UpdateRevenueAttribution">REST API Reference for UpdateRevenueAttribution Operation</seealso>
        public virtual Task<UpdateRevenueAttributionResponse> UpdateRevenueAttributionAsync(UpdateRevenueAttributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRevenueAttributionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRevenueAttributionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRevenueAttributionResponse>(request, options, cancellationToken);
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