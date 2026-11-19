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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;
using Amazon.PartnerCentralMarketing.Model;
using Amazon.PartnerCentralMarketing.Model.Internal.MarshallTransformations;
using Amazon.PartnerCentralMarketing.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570

namespace Amazon.PartnerCentralMarketing
{
    /// <summary>
    /// <para>Implementation for accessing PartnerCentralMarketing</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// AWS Partner Central Marketing API for campaign and asset management.
    /// </summary>
    public partial class AmazonPartnerCentralMarketingClient : AmazonServiceClient, IAmazonPartnerCentralMarketing
    {
        private static IServiceMetadata serviceMetadata = new AmazonPartnerCentralMarketingMetadata();
        private IPartnerCentralMarketingPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPartnerCentralMarketingPaginatorFactory Paginators
        {
            get
            {
                if (this._paginators == null)
                {
                    this._paginators = new PartnerCentralMarketingPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        /// <summary>
        /// Constructs AmazonPartnerCentralMarketingClient with the credentials loaded from the application's
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
        public AmazonPartnerCentralMarketingClient() : base(new AmazonPartnerCentralMarketingConfig()) { }

        /// <summary>
        /// Constructs AmazonPartnerCentralMarketingClient with the credentials loaded from the application's
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
        public AmazonPartnerCentralMarketingClient(RegionEndpoint region) : base(new AmazonPartnerCentralMarketingConfig { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonPartnerCentralMarketingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPartnerCentralMarketingClient Configuration Object</param>
        public AmazonPartnerCentralMarketingClient(AmazonPartnerCentralMarketingConfig config) : base(config) { }

        /// <summary>
        /// Constructs AmazonPartnerCentralMarketingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPartnerCentralMarketingClient(AWSCredentials credentials)
            : this(credentials, new AmazonPartnerCentralMarketingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralMarketingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralMarketingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPartnerCentralMarketingConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralMarketingClient with AWS Credentials and an
        /// AmazonPartnerCentralMarketingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPartnerCentralMarketingClient Configuration Object</param>
        public AmazonPartnerCentralMarketingClient(AWSCredentials credentials, AmazonPartnerCentralMarketingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralMarketingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPartnerCentralMarketingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPartnerCentralMarketingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralMarketingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralMarketingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPartnerCentralMarketingConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralMarketingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPartnerCentralMarketingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPartnerCentralMarketingClient Configuration Object</param>
        public AmazonPartnerCentralMarketingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPartnerCentralMarketingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralMarketingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPartnerCentralMarketingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPartnerCentralMarketingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralMarketingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralMarketingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPartnerCentralMarketingConfig { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralMarketingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPartnerCentralMarketingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPartnerCentralMarketingClient Configuration Object</param>
        public AmazonPartnerCentralMarketingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPartnerCentralMarketingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPartnerCentralMarketingEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPartnerCentralMarketingAuthSchemeHandler());
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

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Instantiates one or more of the campaign template's blueprints as assets of this campaign.
        /// The only asset-create operation: DG-038 deleted the singular CreateCampaignAsset,
        /// and AWS Batch Operations makes exposing a singular alongside a batch optional ("which
        /// MAY actually be exposed in addition"). It also replaced kit instantiation -- CreateCampaign
        /// creates zero assets, so this is the only path by which an asset comes into existence.
        /// Errors here are whole-request only, and nothing is written when one is thrown. Per-entry
        /// failures ride in the response's `Errors` list with a 200. ServiceQuotaExceededException
        /// is deliberately absent: a campaign holds at most one asset per blueprint (I-15), so
        /// the ceiling is the size of the bound kit and a request of unique valid entries cannot
        /// exceed it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateCampaignAsset service method.</param>
        /// <returns>The response from the BatchCreateCampaignAsset service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/BatchCreateCampaignAsset">REST API Reference for BatchCreateCampaignAsset Operation</seealso>
        public virtual BatchCreateCampaignAssetResponse BatchCreateCampaignAsset(BatchCreateCampaignAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateCampaignAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateCampaignAssetResponseUnmarshaller.Instance;

            return Invoke<BatchCreateCampaignAssetResponse>(request, options);
        }
#else
        internal virtual BatchCreateCampaignAssetResponse BatchCreateCampaignAsset(BatchCreateCampaignAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateCampaignAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateCampaignAssetResponseUnmarshaller.Instance;

            return Invoke<BatchCreateCampaignAssetResponse>(request, options);
        }
#endif

        /// <summary>
        /// Instantiates one or more of the campaign template's blueprints as assets of this campaign.
        /// The only asset-create operation: DG-038 deleted the singular CreateCampaignAsset,
        /// and AWS Batch Operations makes exposing a singular alongside a batch optional ("which
        /// MAY actually be exposed in addition"). It also replaced kit instantiation -- CreateCampaign
        /// creates zero assets, so this is the only path by which an asset comes into existence.
        /// Errors here are whole-request only, and nothing is written when one is thrown. Per-entry
        /// failures ride in the response's `Errors` list with a 200. ServiceQuotaExceededException
        /// is deliberately absent: a campaign holds at most one asset per blueprint (I-15), so
        /// the ceiling is the size of the bound kit and a request of unique valid entries cannot
        /// exceed it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateCampaignAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the BatchCreateCampaignAsset service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/BatchCreateCampaignAsset">REST API Reference for BatchCreateCampaignAsset Operation</seealso>
        public virtual Task<BatchCreateCampaignAssetResponse> BatchCreateCampaignAssetAsync(BatchCreateCampaignAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchCreateCampaignAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateCampaignAssetResponseUnmarshaller.Instance;

            return InvokeAsync<BatchCreateCampaignAssetResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new marketing campaign. Returns the identity of the new campaign, not the
        /// campaign. Growing a response is backward compatible and shrinking one is not, and
        /// the caller's next step is a `GetCampaign` anyway — a write that supplies an audience
        /// cannot report its scan verdict, because that is decided after it commits.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign service method.</param>
        /// <returns>The response from the CreateCampaign service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual CreateCampaignResponse CreateCampaign(CreateCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return Invoke<CreateCampaignResponse>(request, options);
        }
#else
        internal virtual CreateCampaignResponse CreateCampaign(CreateCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return Invoke<CreateCampaignResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new marketing campaign. Returns the identity of the new campaign, not the
        /// campaign. Growing a response is backward compatible and shrinking one is not, and
        /// the caller's next step is a `GetCampaign` anyway — a write that supplies an audience
        /// cannot report its scan verdict, because that is decided after it commits.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateCampaign service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual Task<CreateCampaignResponse> CreateCampaignAsync(CreateCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCampaignResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a single-use URL the partner visits to authorize publishing on a platform.
        /// Serves a first connect, connecting a further account, and re-authorizing an expired
        /// one: consenting with an account that is already connected re-authorizes that connection
        /// and keeps its id; any other account adds a connection. Poll ListSocialConnections
        /// for the outcome. Deliberately not idempotent and takes no client token: every call
        /// must mint a fresh single-use URL, so replaying a cached response would hand back a
        /// dead one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSocialConnectionAuthorizationUrl service method.</param>
        /// <returns>The response from the CreateSocialConnectionAuthorizationUrl service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/CreateSocialConnectionAuthorizationUrl">REST API Reference for CreateSocialConnectionAuthorizationUrl Operation</seealso>
        public virtual CreateSocialConnectionAuthorizationUrlResponse CreateSocialConnectionAuthorizationUrl(CreateSocialConnectionAuthorizationUrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSocialConnectionAuthorizationUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSocialConnectionAuthorizationUrlResponseUnmarshaller.Instance;

            return Invoke<CreateSocialConnectionAuthorizationUrlResponse>(request, options);
        }
#else
        internal virtual CreateSocialConnectionAuthorizationUrlResponse CreateSocialConnectionAuthorizationUrl(CreateSocialConnectionAuthorizationUrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSocialConnectionAuthorizationUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSocialConnectionAuthorizationUrlResponseUnmarshaller.Instance;

            return Invoke<CreateSocialConnectionAuthorizationUrlResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a single-use URL the partner visits to authorize publishing on a platform.
        /// Serves a first connect, connecting a further account, and re-authorizing an expired
        /// one: consenting with an account that is already connected re-authorizes that connection
        /// and keeps its id; any other account adds a connection. Poll ListSocialConnections
        /// for the outcome. Deliberately not idempotent and takes no client token: every call
        /// must mint a fresh single-use URL, so replaying a cached response would hand back a
        /// dead one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSocialConnectionAuthorizationUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateSocialConnectionAuthorizationUrl service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/CreateSocialConnectionAuthorizationUrl">REST API Reference for CreateSocialConnectionAuthorizationUrl Operation</seealso>
        public virtual Task<CreateSocialConnectionAuthorizationUrlResponse> CreateSocialConnectionAuthorizationUrlAsync(CreateSocialConnectionAuthorizationUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSocialConnectionAuthorizationUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSocialConnectionAuthorizationUrlResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSocialConnectionAuthorizationUrlResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Stops a live campaign asset: an email's scheduled send is withdrawn, a social post
        /// is removed before it publishes. On a completed campaign, it also removes a published
        /// document, banner or landing page. Synchronous, and safe to repeat. Does not delete
        /// the asset record, so a stopped email or social post can be started again. Not every
        /// asset can be stopped, and the reasons differ in kind. An email that has begun sending
        /// **cannot** be recalled: the send is gone. A document, a banner or a landing page is
        /// **refused** with `ASSET_NOT_DEACTIVATABLE` until the campaign has completed (the UTC
        /// date is after its `EndOn`). Until then the partner fixes one in place by updating
        /// it and activating it again, which keeps its URL, so every email that already linked
        /// to it keeps working. Once the campaign has completed, the removal is permanent, because
        /// a completed campaign can't activate anything again: - A document's published PDF is
        /// deleted. Its URL stops serving within about a minute (the CDN revalidates), and `PublicUrl`
        /// is no longer returned. Anything that linked to it, such as a landing page's download
        /// button or a sent email, reaches an error page. The export still contains the document.
        /// - A banner's or landing page's published object is taken down at the delivery platform,
        /// and the images the partner put on it are deleted. A landing page stops capturing leads,
        /// and its `PublicUrl` is no longer returned. A partner site that embedded a banner shows
        /// nothing there. The platform's own CDN can keep serving a copy a visitor already cached,
        /// which collects nothing. A landing page and a document it links to can be removed in
        /// either order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateCampaignAsset service method.</param>
        /// <returns>The response from the DeactivateCampaignAsset service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/DeactivateCampaignAsset">REST API Reference for DeactivateCampaignAsset Operation</seealso>
        public virtual DeactivateCampaignAssetResponse DeactivateCampaignAsset(DeactivateCampaignAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivateCampaignAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateCampaignAssetResponseUnmarshaller.Instance;

            return Invoke<DeactivateCampaignAssetResponse>(request, options);
        }
#else
        internal virtual DeactivateCampaignAssetResponse DeactivateCampaignAsset(DeactivateCampaignAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivateCampaignAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateCampaignAssetResponseUnmarshaller.Instance;

            return Invoke<DeactivateCampaignAssetResponse>(request, options);
        }
#endif

        /// <summary>
        /// Stops a live campaign asset: an email's scheduled send is withdrawn, a social post
        /// is removed before it publishes. On a completed campaign, it also removes a published
        /// document, banner or landing page. Synchronous, and safe to repeat. Does not delete
        /// the asset record, so a stopped email or social post can be started again. Not every
        /// asset can be stopped, and the reasons differ in kind. An email that has begun sending
        /// **cannot** be recalled: the send is gone. A document, a banner or a landing page is
        /// **refused** with `ASSET_NOT_DEACTIVATABLE` until the campaign has completed (the UTC
        /// date is after its `EndOn`). Until then the partner fixes one in place by updating
        /// it and activating it again, which keeps its URL, so every email that already linked
        /// to it keeps working. Once the campaign has completed, the removal is permanent, because
        /// a completed campaign can't activate anything again: - A document's published PDF is
        /// deleted. Its URL stops serving within about a minute (the CDN revalidates), and `PublicUrl`
        /// is no longer returned. Anything that linked to it, such as a landing page's download
        /// button or a sent email, reaches an error page. The export still contains the document.
        /// - A banner's or landing page's published object is taken down at the delivery platform,
        /// and the images the partner put on it are deleted. A landing page stops capturing leads,
        /// and its `PublicUrl` is no longer returned. A partner site that embedded a banner shows
        /// nothing there. The platform's own CDN can keep serving a copy a visitor already cached,
        /// which collects nothing. A landing page and a document it links to can be removed in
        /// either order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateCampaignAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeactivateCampaignAsset service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/DeactivateCampaignAsset">REST API Reference for DeactivateCampaignAsset Operation</seealso>
        public virtual Task<DeactivateCampaignAssetResponse> DeactivateCampaignAssetAsync(DeactivateCampaignAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivateCampaignAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateCampaignAssetResponseUnmarshaller.Instance;

            return InvokeAsync<DeactivateCampaignAssetResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Permanently deletes a campaign, its assets and their stored files. A hard delete with
        /// no undo: the campaign leaves ListCampaigns and every read of it returns ResourceNotFoundException.
        /// Its tags are removed with it. Refused with ConflictException while the campaign has
        /// a live asset (`CAMPAIGN_HAS_ACTIVE_ASSETS`), because deleting the record would orphan
        /// what the delivery platform still serves or sends: deactivate those assets first. Also
        /// refused while an activation task is running (`CAMPAIGN_ACTIVATION_IN_PROGRESS`). A
        /// completed campaign can be deleted. Idempotent in effect: deleting a campaign that
        /// is already gone returns ResourceNotFoundException, and nothing is left behind by a
        /// retry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
        /// <returns>The response from the DeleteCampaign service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        public virtual DeleteCampaignResponse DeleteCampaign(DeleteCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return Invoke<DeleteCampaignResponse>(request, options);
        }
#else
        internal virtual DeleteCampaignResponse DeleteCampaign(DeleteCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return Invoke<DeleteCampaignResponse>(request, options);
        }
#endif

        /// <summary>
        /// Permanently deletes a campaign, its assets and their stored files. A hard delete with
        /// no undo: the campaign leaves ListCampaigns and every read of it returns ResourceNotFoundException.
        /// Its tags are removed with it. Refused with ConflictException while the campaign has
        /// a live asset (`CAMPAIGN_HAS_ACTIVE_ASSETS`), because deleting the record would orphan
        /// what the delivery platform still serves or sends: deactivate those assets first. Also
        /// refused while an activation task is running (`CAMPAIGN_ACTIVATION_IN_PROGRESS`). A
        /// completed campaign can be deleted. Idempotent in effect: deleting a campaign that
        /// is already gone returns ResourceNotFoundException, and nothing is left behind by a
        /// retry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteCampaign service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        public virtual Task<DeleteCampaignResponse> DeleteCampaignAsync(DeleteCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCampaignResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Permanently deletes a campaign asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignAsset service method.</param>
        /// <returns>The response from the DeleteCampaignAsset service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/DeleteCampaignAsset">REST API Reference for DeleteCampaignAsset Operation</seealso>
        public virtual DeleteCampaignAssetResponse DeleteCampaignAsset(DeleteCampaignAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignAssetResponseUnmarshaller.Instance;

            return Invoke<DeleteCampaignAssetResponse>(request, options);
        }
#else
        internal virtual DeleteCampaignAssetResponse DeleteCampaignAsset(DeleteCampaignAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignAssetResponseUnmarshaller.Instance;

            return Invoke<DeleteCampaignAssetResponse>(request, options);
        }
#endif

        /// <summary>
        /// Permanently deletes a campaign asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteCampaignAsset service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/DeleteCampaignAsset">REST API Reference for DeleteCampaignAsset Operation</seealso>
        public virtual Task<DeleteCampaignAssetResponse> DeleteCampaignAssetAsync(DeleteCampaignAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignAssetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCampaignAssetResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Revokes and deletes one social connection; other connections on the same platform
        /// are untouched. Idempotent: deleting an unknown or already-deleted connection succeeds
        /// rather than returning a not-found error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSocialConnection service method.</param>
        /// <returns>The response from the DeleteSocialConnection service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/DeleteSocialConnection">REST API Reference for DeleteSocialConnection Operation</seealso>
        public virtual DeleteSocialConnectionResponse DeleteSocialConnection(DeleteSocialConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSocialConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSocialConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteSocialConnectionResponse>(request, options);
        }
#else
        internal virtual DeleteSocialConnectionResponse DeleteSocialConnection(DeleteSocialConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSocialConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSocialConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteSocialConnectionResponse>(request, options);
        }
#endif

        /// <summary>
        /// Revokes and deletes one social connection; other connections on the same platform
        /// are untouched. Idempotent: deleting an unknown or already-deleted connection succeeds
        /// rather than returning a not-found error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSocialConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteSocialConnection service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/DeleteSocialConnection">REST API Reference for DeleteSocialConnection Operation</seealso>
        public virtual Task<DeleteSocialConnectionResponse> DeleteSocialConnectionAsync(DeleteSocialConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSocialConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSocialConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSocialConnectionResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a campaign by its identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign service method.</param>
        /// <returns>The response from the GetCampaign service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/GetCampaign">REST API Reference for GetCampaign Operation</seealso>
        public virtual GetCampaignResponse GetCampaign(GetCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignResponseUnmarshaller.Instance;

            return Invoke<GetCampaignResponse>(request, options);
        }
#else
        internal virtual GetCampaignResponse GetCampaign(GetCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignResponseUnmarshaller.Instance;

            return Invoke<GetCampaignResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves a campaign by its identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCampaign service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/GetCampaign">REST API Reference for GetCampaign Operation</seealso>
        public virtual Task<GetCampaignResponse> GetCampaignAsync(GetCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignResponseUnmarshaller.Instance;

            return InvokeAsync<GetCampaignResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves an asset by its identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignAsset service method.</param>
        /// <returns>The response from the GetCampaignAsset service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/GetCampaignAsset">REST API Reference for GetCampaignAsset Operation</seealso>
        public virtual GetCampaignAssetResponse GetCampaignAsset(GetCampaignAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignAssetResponseUnmarshaller.Instance;

            return Invoke<GetCampaignAssetResponse>(request, options);
        }
#else
        internal virtual GetCampaignAssetResponse GetCampaignAsset(GetCampaignAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignAssetResponseUnmarshaller.Instance;

            return Invoke<GetCampaignAssetResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves an asset by its identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCampaignAsset service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/GetCampaignAsset">REST API Reference for GetCampaignAsset Operation</seealso>
        public virtual Task<GetCampaignAssetResponse> GetCampaignAssetAsync(GetCampaignAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignAssetResponseUnmarshaller.Instance;

            return InvokeAsync<GetCampaignAssetResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Reads a campaign's current activation task. Keyed on the **campaign**, with no task
        /// identifier, because a campaign has at most one activation task: runs are serialised,
        /// so there is no collection to address into. The caller always holds the task id anyway,
        /// because Start returned it — the id is a correlation value, not an address. Returns
        /// the campaign's most recent task. A new task overwrites the previous one, so this is
        /// not a history: the durable per-asset record is on the assets themselves. Returns ResourceNotFoundException
        /// when the campaign has never had a task, or when its last one has expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignAssetActivationTask service method.</param>
        /// <returns>The response from the GetCampaignAssetActivationTask service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/GetCampaignAssetActivationTask">REST API Reference for GetCampaignAssetActivationTask Operation</seealso>
        public virtual GetCampaignAssetActivationTaskResponse GetCampaignAssetActivationTask(GetCampaignAssetActivationTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignAssetActivationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignAssetActivationTaskResponseUnmarshaller.Instance;

            return Invoke<GetCampaignAssetActivationTaskResponse>(request, options);
        }
#else
        internal virtual GetCampaignAssetActivationTaskResponse GetCampaignAssetActivationTask(GetCampaignAssetActivationTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignAssetActivationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignAssetActivationTaskResponseUnmarshaller.Instance;

            return Invoke<GetCampaignAssetActivationTaskResponse>(request, options);
        }
#endif

        /// <summary>
        /// Reads a campaign's current activation task. Keyed on the **campaign**, with no task
        /// identifier, because a campaign has at most one activation task: runs are serialised,
        /// so there is no collection to address into. The caller always holds the task id anyway,
        /// because Start returned it — the id is a correlation value, not an address. Returns
        /// the campaign's most recent task. A new task overwrites the previous one, so this is
        /// not a history: the durable per-asset record is on the assets themselves. Returns ResourceNotFoundException
        /// when the campaign has never had a task, or when its last one has expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignAssetActivationTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCampaignAssetActivationTask service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/GetCampaignAssetActivationTask">REST API Reference for GetCampaignAssetActivationTask Operation</seealso>
        public virtual Task<GetCampaignAssetActivationTaskResponse> GetCampaignAssetActivationTaskAsync(GetCampaignAssetActivationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignAssetActivationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignAssetActivationTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetCampaignAssetActivationTaskResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a campaign asset export task by its identifier, reporting its status and,
        /// when the task is COMPLETED, a freshly minted short-lived presigned URL for downloading
        /// the ZIP archive. The download URL is minted on each call and is valid for at most
        /// 15 minutes; clients should download promptly rather than caching it. When the task
        /// has FAILED, FailureReason explains why. Poll this operation (roughly every 2-5 seconds)
        /// until the task reaches a terminal state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignAssetExportTask service method.</param>
        /// <returns>The response from the GetCampaignAssetExportTask service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/GetCampaignAssetExportTask">REST API Reference for GetCampaignAssetExportTask Operation</seealso>
        public virtual GetCampaignAssetExportTaskResponse GetCampaignAssetExportTask(GetCampaignAssetExportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignAssetExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignAssetExportTaskResponseUnmarshaller.Instance;

            return Invoke<GetCampaignAssetExportTaskResponse>(request, options);
        }
#else
        internal virtual GetCampaignAssetExportTaskResponse GetCampaignAssetExportTask(GetCampaignAssetExportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignAssetExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignAssetExportTaskResponseUnmarshaller.Instance;

            return Invoke<GetCampaignAssetExportTaskResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves a campaign asset export task by its identifier, reporting its status and,
        /// when the task is COMPLETED, a freshly minted short-lived presigned URL for downloading
        /// the ZIP archive. The download URL is minted on each call and is valid for at most
        /// 15 minutes; clients should download promptly rather than caching it. When the task
        /// has FAILED, FailureReason explains why. Poll this operation (roughly every 2-5 seconds)
        /// until the task reaches a terminal state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignAssetExportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCampaignAssetExportTask service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/GetCampaignAssetExportTask">REST API Reference for GetCampaignAssetExportTask Operation</seealso>
        public virtual Task<GetCampaignAssetExportTaskResponse> GetCampaignAssetExportTaskAsync(GetCampaignAssetExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignAssetExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignAssetExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<GetCampaignAssetExportTaskResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves full detail of one campaign template, including its ordered asset templates
        /// with their field schema and layout previews.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignTemplate service method.</param>
        /// <returns>The response from the GetCampaignTemplate service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/GetCampaignTemplate">REST API Reference for GetCampaignTemplate Operation</seealso>
        public virtual GetCampaignTemplateResponse GetCampaignTemplate(GetCampaignTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignTemplateResponseUnmarshaller.Instance;

            return Invoke<GetCampaignTemplateResponse>(request, options);
        }
#else
        internal virtual GetCampaignTemplateResponse GetCampaignTemplate(GetCampaignTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignTemplateResponseUnmarshaller.Instance;

            return Invoke<GetCampaignTemplateResponse>(request, options);
        }
#endif

        /// <summary>
        /// Retrieves full detail of one campaign template, including its ordered asset templates
        /// with their field schema and layout previews.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetCampaignTemplate service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/GetCampaignTemplate">REST API Reference for GetCampaignTemplate Operation</seealso>
        public virtual Task<GetCampaignTemplateResponse> GetCampaignTemplateAsync(GetCampaignTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetCampaignTemplateResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists assets for a campaign with pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCampaignAssets service method.</param>
        /// <returns>The response from the ListCampaignAssets service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/ListCampaignAssets">REST API Reference for ListCampaignAssets Operation</seealso>
        public virtual ListCampaignAssetsResponse ListCampaignAssets(ListCampaignAssetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCampaignAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCampaignAssetsResponseUnmarshaller.Instance;

            return Invoke<ListCampaignAssetsResponse>(request, options);
        }
#else
        internal virtual ListCampaignAssetsResponse ListCampaignAssets(ListCampaignAssetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCampaignAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCampaignAssetsResponseUnmarshaller.Instance;

            return Invoke<ListCampaignAssetsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists assets for a campaign with pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCampaignAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCampaignAssets service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/ListCampaignAssets">REST API Reference for ListCampaignAssets Operation</seealso>
        public virtual Task<ListCampaignAssetsResponse> ListCampaignAssetsAsync(ListCampaignAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCampaignAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCampaignAssetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCampaignAssetsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists campaigns with optional filters and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns service method.</param>
        /// <returns>The response from the ListCampaigns service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        public virtual ListCampaignsResponse ListCampaigns(ListCampaignsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCampaignsResponseUnmarshaller.Instance;

            return Invoke<ListCampaignsResponse>(request, options);
        }
#else
        internal virtual ListCampaignsResponse ListCampaigns(ListCampaignsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCampaignsResponseUnmarshaller.Instance;

            return Invoke<ListCampaignsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists campaigns with optional filters and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCampaigns service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        public virtual Task<ListCampaignsResponse> ListCampaignsAsync(ListCampaignsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCampaignsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCampaignsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the partner's social connections, optionally filtered by platform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSocialConnections service method.</param>
        /// <returns>The response from the ListSocialConnections service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/ListSocialConnections">REST API Reference for ListSocialConnections Operation</seealso>
        public virtual ListSocialConnectionsResponse ListSocialConnections(ListSocialConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSocialConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSocialConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListSocialConnectionsResponse>(request, options);
        }
#else
        internal virtual ListSocialConnectionsResponse ListSocialConnections(ListSocialConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSocialConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSocialConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListSocialConnectionsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the partner's social connections, optionally filtered by platform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSocialConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListSocialConnections service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/ListSocialConnections">REST API Reference for ListSocialConnections Operation</seealso>
        public virtual Task<ListSocialConnectionsResponse> ListSocialConnectionsAsync(ListSocialConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSocialConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSocialConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSocialConnectionsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the tags applied to a Partner Central Marketing resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }
#else
        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the tags applied to a Partner Central Marketing resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Searches and browses the AWS-authored campaign template catalog. With no SearchText
        /// it returns the whole catalog in the default order, so browse and keyword search share
        /// one shape; GetCampaignTemplate reads one template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchCampaignTemplates service method.</param>
        /// <returns>The response from the SearchCampaignTemplates service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/SearchCampaignTemplates">REST API Reference for SearchCampaignTemplates Operation</seealso>
        public virtual SearchCampaignTemplatesResponse SearchCampaignTemplates(SearchCampaignTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchCampaignTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchCampaignTemplatesResponseUnmarshaller.Instance;

            return Invoke<SearchCampaignTemplatesResponse>(request, options);
        }
#else
        internal virtual SearchCampaignTemplatesResponse SearchCampaignTemplates(SearchCampaignTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchCampaignTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchCampaignTemplatesResponseUnmarshaller.Instance;

            return Invoke<SearchCampaignTemplatesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Searches and browses the AWS-authored campaign template catalog. With no SearchText
        /// it returns the whole catalog in the default order, so browse and keyword search share
        /// one shape; GetCampaignTemplate reads one template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchCampaignTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SearchCampaignTemplates service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/SearchCampaignTemplates">REST API Reference for SearchCampaignTemplates Operation</seealso>
        public virtual Task<SearchCampaignTemplatesResponse> SearchCampaignTemplatesAsync(SearchCampaignTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchCampaignTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchCampaignTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchCampaignTemplatesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Activates 1–25 of a campaign's assets as one ordered unit, and returns a task to poll.
        /// Takes a **list** because the service owns the ordering. Assets link to one another
        /// by URL — an email's call-to-action carries the landing page's URL, the landing page's
        /// download field carries the document's — and a URL does not exist until the asset it
        /// points at is activated. Those edges are derived by the service from the campaign's
        /// pinned template, so reconstructing and topologically sorting them is work the service
        /// has already done, and getting it wrong arms an email with a dead link. Name every
        /// asset you want live and the service sequences them; "activate everything" is the list
        /// with every id in it, which ListCampaignAssets already gave you. Asynchronous, because
        /// activating an asset installs or arms behaviour that runs later and an email activation
        /// bulk-loads its audience into the delivery platform. Everything decidable **without**
        /// a write to the delivery platform is evaluated before this returns; everything else
        /// lands on the task. A refusal that applies to one asset does not fail the request:
        /// that asset is on the task already FAILED, with its reason, and the rest run. A refusal
        /// that applies to the whole request — a malformed list, an unknown campaign, another
        /// task already running on this campaign, this service's service-linked role being deleted
        /// (ConflictException `SERVICE_LINKED_ROLE_DELETION_IN_PROGRESS`), a campaign setting
        /// an asset in the request needs (ValidationException `CAMPAIGN_INCOMPLETE`), a campaign
        /// sender that no longer passes `CreateCampaign`'s sender rules while the request names
        /// an email (ValidationException with no `FieldList`, whose message ends with one `Reason:
        /// &lt;c&gt;` token per failed rule: `PATTERN_MISMATCH`, `SENDER_DOMAIN_NOT_ALLIANCE_LEAD`,
        /// or `SENDER_DOMAIN_DKIM_MISSING` and/or `SENDER_DOMAIN_DMARC_MISSING`) — is thrown,
        /// and nothing starts. One task runs on a campaign at a time. A second concurrent call
        /// is refused with ConflictException / CAMPAIGN_ACTIVATION_IN_PROGRESS, whose `ResourceId`
        /// names the task already holding the campaign. Two tasks over *disjoint* asset sets
        /// are refused too: the guard is deliberately campaign-wide, because overlapping runs
        /// made the per-asset status misleading rather than merely contended.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCampaignAssetActivationTask service method.</param>
        /// <returns>The response from the StartCampaignAssetActivationTask service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/StartCampaignAssetActivationTask">REST API Reference for StartCampaignAssetActivationTask Operation</seealso>
        public virtual StartCampaignAssetActivationTaskResponse StartCampaignAssetActivationTask(StartCampaignAssetActivationTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCampaignAssetActivationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCampaignAssetActivationTaskResponseUnmarshaller.Instance;

            return Invoke<StartCampaignAssetActivationTaskResponse>(request, options);
        }
#else
        internal virtual StartCampaignAssetActivationTaskResponse StartCampaignAssetActivationTask(StartCampaignAssetActivationTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCampaignAssetActivationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCampaignAssetActivationTaskResponseUnmarshaller.Instance;

            return Invoke<StartCampaignAssetActivationTaskResponse>(request, options);
        }
#endif

        /// <summary>
        /// Activates 1–25 of a campaign's assets as one ordered unit, and returns a task to poll.
        /// Takes a **list** because the service owns the ordering. Assets link to one another
        /// by URL — an email's call-to-action carries the landing page's URL, the landing page's
        /// download field carries the document's — and a URL does not exist until the asset it
        /// points at is activated. Those edges are derived by the service from the campaign's
        /// pinned template, so reconstructing and topologically sorting them is work the service
        /// has already done, and getting it wrong arms an email with a dead link. Name every
        /// asset you want live and the service sequences them; "activate everything" is the list
        /// with every id in it, which ListCampaignAssets already gave you. Asynchronous, because
        /// activating an asset installs or arms behaviour that runs later and an email activation
        /// bulk-loads its audience into the delivery platform. Everything decidable **without**
        /// a write to the delivery platform is evaluated before this returns; everything else
        /// lands on the task. A refusal that applies to one asset does not fail the request:
        /// that asset is on the task already FAILED, with its reason, and the rest run. A refusal
        /// that applies to the whole request — a malformed list, an unknown campaign, another
        /// task already running on this campaign, this service's service-linked role being deleted
        /// (ConflictException `SERVICE_LINKED_ROLE_DELETION_IN_PROGRESS`), a campaign setting
        /// an asset in the request needs (ValidationException `CAMPAIGN_INCOMPLETE`), a campaign
        /// sender that no longer passes `CreateCampaign`'s sender rules while the request names
        /// an email (ValidationException with no `FieldList`, whose message ends with one `Reason:
        /// &lt;c&gt;` token per failed rule: `PATTERN_MISMATCH`, `SENDER_DOMAIN_NOT_ALLIANCE_LEAD`,
        /// or `SENDER_DOMAIN_DKIM_MISSING` and/or `SENDER_DOMAIN_DMARC_MISSING`) — is thrown,
        /// and nothing starts. One task runs on a campaign at a time. A second concurrent call
        /// is refused with ConflictException / CAMPAIGN_ACTIVATION_IN_PROGRESS, whose `ResourceId`
        /// names the task already holding the campaign. Two tasks over *disjoint* asset sets
        /// are refused too: the guard is deliberately campaign-wide, because overlapping runs
        /// made the per-asset status misleading rather than merely contended.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCampaignAssetActivationTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartCampaignAssetActivationTask service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/StartCampaignAssetActivationTask">REST API Reference for StartCampaignAssetActivationTask Operation</seealso>
        public virtual Task<StartCampaignAssetActivationTaskResponse> StartCampaignAssetActivationTaskAsync(StartCampaignAssetActivationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCampaignAssetActivationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCampaignAssetActivationTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartCampaignAssetActivationTaskResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Starts an asynchronous task that packages a campaign's assets into a single downloadable
        /// ZIP archive. Fire-and-return: the campaign is validated (it must exist and not be
        /// cancelled), a task record is persisted, an asynchronous execution is started, and
        /// the task id is returned with status IN_PROGRESS. This operation does not inspect assets
        /// — all resolution, exclusion, and failure are determined by the execution and surfaced
        /// only by GetCampaignAssetExportTask. Every campaign is exportable, including one never
        /// activated, because renderable assets are composed on demand at export time rather
        /// than requiring finished, launched deliverables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCampaignAssetExportTask service method.</param>
        /// <returns>The response from the StartCampaignAssetExportTask service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/StartCampaignAssetExportTask">REST API Reference for StartCampaignAssetExportTask Operation</seealso>
        public virtual StartCampaignAssetExportTaskResponse StartCampaignAssetExportTask(StartCampaignAssetExportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCampaignAssetExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCampaignAssetExportTaskResponseUnmarshaller.Instance;

            return Invoke<StartCampaignAssetExportTaskResponse>(request, options);
        }
#else
        internal virtual StartCampaignAssetExportTaskResponse StartCampaignAssetExportTask(StartCampaignAssetExportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCampaignAssetExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCampaignAssetExportTaskResponseUnmarshaller.Instance;

            return Invoke<StartCampaignAssetExportTaskResponse>(request, options);
        }
#endif

        /// <summary>
        /// Starts an asynchronous task that packages a campaign's assets into a single downloadable
        /// ZIP archive. Fire-and-return: the campaign is validated (it must exist and not be
        /// cancelled), a task record is persisted, an asynchronous execution is started, and
        /// the task id is returned with status IN_PROGRESS. This operation does not inspect assets
        /// — all resolution, exclusion, and failure are determined by the execution and surfaced
        /// only by GetCampaignAssetExportTask. Every campaign is exportable, including one never
        /// activated, because renderable assets are composed on demand at export time rather
        /// than requiring finished, launched deliverables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCampaignAssetExportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartCampaignAssetExportTask service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/StartCampaignAssetExportTask">REST API Reference for StartCampaignAssetExportTask Operation</seealso>
        public virtual Task<StartCampaignAssetExportTaskResponse> StartCampaignAssetExportTaskAsync(StartCampaignAssetExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartCampaignAssetExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCampaignAssetExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartCampaignAssetExportTaskResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Adds or replaces tags on a Partner Central Marketing resource. Idempotent: applying
        /// a tag that is already present with the same value is a no-op, and supplying a key
        /// that already exists replaces its value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }
#else
        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Adds or replaces tags on a Partner Central Marketing resource. Idempotent: applying
        /// a tag that is already present with the same value is a no-op, and supplying a key
        /// that already exists replaces its value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Removes tags from a Partner Central Marketing resource. Idempotent: removing a key
        /// that is not present succeeds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }
#else
        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Removes tags from a Partner Central Marketing resource. Idempotent: removing a key
        /// that is not present succeeds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Edits a campaign in place. Partial update: an omitted field is left unchanged, which
        /// is the standard meaning of an `Update` verb — a full replacement would be a `Put`.
        /// Change-only, with no way to clear a field back to empty, because the campaign's file
        /// members cannot round-trip: they are written as an `s3://` reference and read back
        /// as a URL or as metadata, so a replacement payload could not resend an unchanged recipient
        /// list without re-uploading it. Refused while an activation task runs (`CAMPAIGN_ACTIVATION_IN_PROGRESS`)
        /// and once the campaign is completed (`CAMPAIGN_COMPLETED`, the UTC date is after its
        /// `EndOn`). Last-writer-wins, with no concurrency token: this is low-contention metadata
        /// owned by one partner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign service method.</param>
        /// <returns>The response from the UpdateCampaign service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
        public virtual UpdateCampaignResponse UpdateCampaign(UpdateCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignResponse>(request, options);
        }
#else
        internal virtual UpdateCampaignResponse UpdateCampaign(UpdateCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignResponse>(request, options);
        }
#endif

        /// <summary>
        /// Edits a campaign in place. Partial update: an omitted field is left unchanged, which
        /// is the standard meaning of an `Update` verb — a full replacement would be a `Put`.
        /// Change-only, with no way to clear a field back to empty, because the campaign's file
        /// members cannot round-trip: they are written as an `s3://` reference and read back
        /// as a URL or as metadata, so a replacement payload could not resend an unchanged recipient
        /// list without re-uploading it. Refused while an activation task runs (`CAMPAIGN_ACTIVATION_IN_PROGRESS`)
        /// and once the campaign is completed (`CAMPAIGN_COMPLETED`, the UTC date is after its
        /// `EndOn`). Last-writer-wins, with no concurrency token: this is low-contention metadata
        /// owned by one partner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateCampaign service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
        public virtual Task<UpdateCampaignResponse> UpdateCampaignAsync(UpdateCampaignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCampaignResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates an asset's field values, layout or send time. Refused with `ConflictException`
        /// while the campaign's running activation task still owns the asset (`ASSET_START_IN_PROGRESS`),
        /// and for a live email or social post (`ASSET_ALREADY_ACTIVE`): deactivate it first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignAsset service method.</param>
        /// <returns>The response from the UpdateCampaignAsset service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/UpdateCampaignAsset">REST API Reference for UpdateCampaignAsset Operation</seealso>
        public virtual UpdateCampaignAssetResponse UpdateCampaignAsset(UpdateCampaignAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignAssetResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignAssetResponse>(request, options);
        }
#else
        internal virtual UpdateCampaignAssetResponse UpdateCampaignAsset(UpdateCampaignAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignAssetResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignAssetResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates an asset's field values, layout or send time. Refused with `ConflictException`
        /// while the campaign's running activation task still owns the asset (`ASSET_START_IN_PROGRESS`),
        /// and for a live email or social post (`ASSET_ALREADY_ACTIVE`): deactivate it first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateCampaignAsset service method, as returned by PartnerCentralMarketing.</returns>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. An IAM denial carries no
        /// `Reason`. A refusal for the caller's Partner Central state carries one, so a client
        /// tells the two apart by its presence.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralMarketing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. A caller branches
        /// on `Reason`, and where the rejection is attributable to particular fields it reads
        /// `FieldList` rather than parsing `Message`, which is prose and may change.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-marketing-2026-05-31/UpdateCampaignAsset">REST API Reference for UpdateCampaignAsset Operation</seealso>
        public virtual Task<UpdateCampaignAssetResponse> UpdateCampaignAssetAsync(UpdateCampaignAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignAssetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCampaignAssetResponse>(request, options, cancellationToken);
        }

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
    }
}
