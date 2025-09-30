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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MediaPackageV2.Model;
using Amazon.MediaPackageV2.Model.Internal.MarshallTransformations;
using Amazon.MediaPackageV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.MediaPackageV2
{
    /// <summary>
    /// <para>Implementation for accessing MediaPackageV2</para>
    ///
    /// <note> 
    /// <para>
    /// This guide is intended for creating AWS Elemental MediaPackage resources in MediaPackage
    /// Version 2 (v2) starting from May 2023. To get started with MediaPackage v2, create
    /// your MediaPackage resources. There isn't an automated process to migrate your resources
    /// from MediaPackage v1 to MediaPackage v2. 
    /// 
    ///  
    /// <para>
    /// The names of the entities that you use to access this API, like URLs and ARNs, all
    /// have the versioning information added, like &quot;v2&quot;, to distinguish from the
    /// prior version. If you used MediaPackage prior to this release, you can't use the MediaPackage
    /// v2 CLI or the MediaPackage v2 API to access any MediaPackage v1 resources.
    /// </para>
    ///  
    /// <para>
    /// If you created resources in MediaPackage v1, use video on demand (VOD) workflows,
    /// and aren't looking to migrate to MediaPackage v2 yet, see the <a href="https://docs.aws.amazon.com/mediapackage/latest/apireference/what-is.html">MediaPackage
    /// v1 Live API Reference</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// This is the AWS Elemental MediaPackage v2 Live REST API Reference. It describes all
    /// the MediaPackage API operations for live content in detail, and provides sample requests,
    /// responses, and errors for the supported web services protocols.
    /// </para>
    ///  
    /// <para>
    /// We assume that you have the IAM permissions that you need to use MediaPackage via
    /// the REST API. We also assume that you are familiar with the features and operations
    /// of MediaPackage, as described in the AWS Elemental MediaPackage User Guide.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonMediaPackageV2Client : AmazonServiceClient, IAmazonMediaPackageV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonMediaPackageV2Metadata();
        private IMediaPackageV2PaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMediaPackageV2PaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MediaPackageV2PaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonMediaPackageV2Client with the credentials loaded from the application's
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
        public AmazonMediaPackageV2Client()
            : base(new AmazonMediaPackageV2Config()) { }

        /// <summary>
        /// Constructs AmazonMediaPackageV2Client with the credentials loaded from the application's
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
        public AmazonMediaPackageV2Client(RegionEndpoint region)
            : base(new AmazonMediaPackageV2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMediaPackageV2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMediaPackageV2Client Configuration Object</param>
        public AmazonMediaPackageV2Client(AmazonMediaPackageV2Config config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonMediaPackageV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMediaPackageV2Client(AWSCredentials credentials)
            : this(credentials, new AmazonMediaPackageV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaPackageV2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMediaPackageV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageV2Client with AWS Credentials and an
        /// AmazonMediaPackageV2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMediaPackageV2Client Configuration Object</param>
        public AmazonMediaPackageV2Client(AWSCredentials credentials, AmazonMediaPackageV2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMediaPackageV2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaPackageV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaPackageV2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaPackageV2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaPackageV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMediaPackageV2Client Configuration Object</param>
        public AmazonMediaPackageV2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonMediaPackageV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMediaPackageV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaPackageV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaPackageV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaPackageV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaPackageV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaPackageV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMediaPackageV2Client Configuration Object</param>
        public AmazonMediaPackageV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMediaPackageV2Config clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMediaPackageV2EndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMediaPackageV2AuthSchemeHandler());
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


        #region  CancelHarvestJob


        /// <summary>
        /// Cancels an in-progress harvest job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelHarvestJob service method.</param>
        /// 
        /// <returns>The response from the CancelHarvestJob service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CancelHarvestJob">REST API Reference for CancelHarvestJob Operation</seealso>
        public virtual CancelHarvestJobResponse CancelHarvestJob(CancelHarvestJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelHarvestJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelHarvestJobResponseUnmarshaller.Instance;

            return Invoke<CancelHarvestJobResponse>(request, options);
        }


        /// <summary>
        /// Cancels an in-progress harvest job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelHarvestJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelHarvestJob service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CancelHarvestJob">REST API Reference for CancelHarvestJob Operation</seealso>
        public virtual Task<CancelHarvestJobResponse> CancelHarvestJobAsync(CancelHarvestJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelHarvestJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelHarvestJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelHarvestJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateChannel


        /// <summary>
        /// Create a channel to start receiving content streams. The channel represents the input
        /// to MediaPackage for incoming live content from an encoder such as AWS Elemental MediaLive.
        /// The channel receives content, and after packaging it, outputs it through an origin
        /// endpoint to downstream devices (such as video players or CDNs) that request the content.
        /// You can create only one channel with each request. We recommend that you spread out
        /// channels between channel groups, such as putting redundant channels in the same AWS
        /// Region in different channel groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelResponse>(request, options);
        }


        /// <summary>
        /// Create a channel to start receiving content streams. The channel represents the input
        /// to MediaPackage for incoming live content from an encoder such as AWS Elemental MediaLive.
        /// The channel receives content, and after packaging it, outputs it through an origin
        /// endpoint to downstream devices (such as video players or CDNs) that request the content.
        /// You can create only one channel with each request. We recommend that you spread out
        /// channels between channel groups, such as putting redundant channels in the same AWS
        /// Region in different channel groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual Task<CreateChannelResponse> CreateChannelAsync(CreateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateChannelGroup


        /// <summary>
        /// Create a channel group to group your channels and origin endpoints. A channel group
        /// is the top-level resource that consists of channels and origin endpoints that are
        /// associated with it and that provides predictable URLs for stream delivery. All channels
        /// and origin endpoints within the channel group are guaranteed to share the DNS. You
        /// can create only one channel group with each request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelGroup service method.</param>
        /// 
        /// <returns>The response from the CreateChannelGroup service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateChannelGroup">REST API Reference for CreateChannelGroup Operation</seealso>
        public virtual CreateChannelGroupResponse CreateChannelGroup(CreateChannelGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelGroupResponseUnmarshaller.Instance;

            return Invoke<CreateChannelGroupResponse>(request, options);
        }


        /// <summary>
        /// Create a channel group to group your channels and origin endpoints. A channel group
        /// is the top-level resource that consists of channels and origin endpoints that are
        /// associated with it and that provides predictable URLs for stream delivery. All channels
        /// and origin endpoints within the channel group are guaranteed to share the DNS. You
        /// can create only one channel group with each request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannelGroup service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateChannelGroup">REST API Reference for CreateChannelGroup Operation</seealso>
        public virtual Task<CreateChannelGroupResponse> CreateChannelGroupAsync(CreateChannelGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateChannelGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateHarvestJob


        /// <summary>
        /// Creates a new harvest job to export content from a MediaPackage v2 channel to an S3
        /// bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHarvestJob service method.</param>
        /// 
        /// <returns>The response from the CreateHarvestJob service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateHarvestJob">REST API Reference for CreateHarvestJob Operation</seealso>
        public virtual CreateHarvestJobResponse CreateHarvestJob(CreateHarvestJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateHarvestJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHarvestJobResponseUnmarshaller.Instance;

            return Invoke<CreateHarvestJobResponse>(request, options);
        }


        /// <summary>
        /// Creates a new harvest job to export content from a MediaPackage v2 channel to an S3
        /// bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHarvestJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHarvestJob service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateHarvestJob">REST API Reference for CreateHarvestJob Operation</seealso>
        public virtual Task<CreateHarvestJobResponse> CreateHarvestJobAsync(CreateHarvestJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateHarvestJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHarvestJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateHarvestJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOriginEndpoint


        /// <summary>
        /// The endpoint is attached to a channel, and represents the output of the live content.
        /// You can associate multiple endpoints to a single channel. Each endpoint gives players
        /// and downstream CDNs (such as Amazon CloudFront) access to the content for playback.
        /// Content can't be served from a channel until it has an endpoint. You can create only
        /// one endpoint with each request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateOriginEndpoint service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateOriginEndpoint">REST API Reference for CreateOriginEndpoint Operation</seealso>
        public virtual CreateOriginEndpointResponse CreateOriginEndpoint(CreateOriginEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOriginEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOriginEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateOriginEndpointResponse>(request, options);
        }


        /// <summary>
        /// The endpoint is attached to a channel, and represents the output of the live content.
        /// You can associate multiple endpoints to a single channel. Each endpoint gives players
        /// and downstream CDNs (such as Amazon CloudFront) access to the content for playback.
        /// Content can't be served from a channel until it has an endpoint. You can create only
        /// one endpoint with each request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOriginEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOriginEndpoint service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/CreateOriginEndpoint">REST API Reference for CreateOriginEndpoint Operation</seealso>
        public virtual Task<CreateOriginEndpointResponse> CreateOriginEndpointAsync(CreateOriginEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOriginEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOriginEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateOriginEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChannel


        /// <summary>
        /// Delete a channel to stop AWS Elemental MediaPackage from receiving further content.
        /// You must delete the channel's origin endpoints before you can delete the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelResponse>(request, options);
        }


        /// <summary>
        /// Delete a channel to stop AWS Elemental MediaPackage from receiving further content.
        /// You must delete the channel's origin endpoints before you can delete the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChannelGroup


        /// <summary>
        /// Delete a channel group. You must delete the channel group's channels and origin endpoints
        /// before you can delete the channel group. If you delete a channel group, you'll lose
        /// access to the egress domain and will have to create a new channel group to replace
        /// it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteChannelGroup service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteChannelGroup">REST API Reference for DeleteChannelGroup Operation</seealso>
        public virtual DeleteChannelGroupResponse DeleteChannelGroup(DeleteChannelGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChannelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelGroupResponse>(request, options);
        }


        /// <summary>
        /// Delete a channel group. You must delete the channel group's channels and origin endpoints
        /// before you can delete the channel group. If you delete a channel group, you'll lose
        /// access to the egress domain and will have to create a new channel group to replace
        /// it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannelGroup service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteChannelGroup">REST API Reference for DeleteChannelGroup Operation</seealso>
        public virtual Task<DeleteChannelGroupResponse> DeleteChannelGroupAsync(DeleteChannelGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChannelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteChannelGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChannelPolicy


        /// <summary>
        /// Delete a channel policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteChannelPolicy service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteChannelPolicy">REST API Reference for DeleteChannelPolicy Operation</seealso>
        public virtual DeleteChannelPolicyResponse DeleteChannelPolicy(DeleteChannelPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChannelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelPolicyResponse>(request, options);
        }


        /// <summary>
        /// Delete a channel policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannelPolicy service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteChannelPolicy">REST API Reference for DeleteChannelPolicy Operation</seealso>
        public virtual Task<DeleteChannelPolicyResponse> DeleteChannelPolicyAsync(DeleteChannelPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChannelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteChannelPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteOriginEndpoint


        /// <summary>
        /// Origin endpoints can serve content until they're deleted. Delete the endpoint if it
        /// should no longer respond to playback requests. You must delete all endpoints from
        /// a channel before you can delete the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteOriginEndpoint service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteOriginEndpoint">REST API Reference for DeleteOriginEndpoint Operation</seealso>
        public virtual DeleteOriginEndpointResponse DeleteOriginEndpoint(DeleteOriginEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOriginEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOriginEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteOriginEndpointResponse>(request, options);
        }


        /// <summary>
        /// Origin endpoints can serve content until they're deleted. Delete the endpoint if it
        /// should no longer respond to playback requests. You must delete all endpoints from
        /// a channel before you can delete the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOriginEndpoint service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteOriginEndpoint">REST API Reference for DeleteOriginEndpoint Operation</seealso>
        public virtual Task<DeleteOriginEndpointResponse> DeleteOriginEndpointAsync(DeleteOriginEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOriginEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOriginEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteOriginEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteOriginEndpointPolicy


        /// <summary>
        /// Delete an origin endpoint policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginEndpointPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteOriginEndpointPolicy service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteOriginEndpointPolicy">REST API Reference for DeleteOriginEndpointPolicy Operation</seealso>
        public virtual DeleteOriginEndpointPolicyResponse DeleteOriginEndpointPolicy(DeleteOriginEndpointPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOriginEndpointPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOriginEndpointPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteOriginEndpointPolicyResponse>(request, options);
        }


        /// <summary>
        /// Delete an origin endpoint policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOriginEndpointPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOriginEndpointPolicy service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/DeleteOriginEndpointPolicy">REST API Reference for DeleteOriginEndpointPolicy Operation</seealso>
        public virtual Task<DeleteOriginEndpointPolicyResponse> DeleteOriginEndpointPolicyAsync(DeleteOriginEndpointPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOriginEndpointPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOriginEndpointPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteOriginEndpointPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetChannel


        /// <summary>
        /// Retrieves the specified channel that's configured in AWS Elemental MediaPackage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannel service method.</param>
        /// 
        /// <returns>The response from the GetChannel service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetChannel">REST API Reference for GetChannel Operation</seealso>
        public virtual GetChannelResponse GetChannel(GetChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelResponseUnmarshaller.Instance;

            return Invoke<GetChannelResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the specified channel that's configured in AWS Elemental MediaPackage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChannel service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetChannel">REST API Reference for GetChannel Operation</seealso>
        public virtual Task<GetChannelResponse> GetChannelAsync(GetChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetChannelGroup


        /// <summary>
        /// Retrieves the specified channel group that's configured in AWS Elemental MediaPackage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelGroup service method.</param>
        /// 
        /// <returns>The response from the GetChannelGroup service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetChannelGroup">REST API Reference for GetChannelGroup Operation</seealso>
        public virtual GetChannelGroupResponse GetChannelGroup(GetChannelGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChannelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelGroupResponseUnmarshaller.Instance;

            return Invoke<GetChannelGroupResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the specified channel group that's configured in AWS Elemental MediaPackage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChannelGroup service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetChannelGroup">REST API Reference for GetChannelGroup Operation</seealso>
        public virtual Task<GetChannelGroupResponse> GetChannelGroupAsync(GetChannelGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChannelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetChannelGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetChannelPolicy


        /// <summary>
        /// Retrieves the specified channel policy that's configured in AWS Elemental MediaPackage.
        /// With policies, you can specify who has access to AWS resources and what actions they
        /// can perform on those resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelPolicy service method.</param>
        /// 
        /// <returns>The response from the GetChannelPolicy service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetChannelPolicy">REST API Reference for GetChannelPolicy Operation</seealso>
        public virtual GetChannelPolicyResponse GetChannelPolicy(GetChannelPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChannelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelPolicyResponseUnmarshaller.Instance;

            return Invoke<GetChannelPolicyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the specified channel policy that's configured in AWS Elemental MediaPackage.
        /// With policies, you can specify who has access to AWS resources and what actions they
        /// can perform on those resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChannelPolicy service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetChannelPolicy">REST API Reference for GetChannelPolicy Operation</seealso>
        public virtual Task<GetChannelPolicyResponse> GetChannelPolicyAsync(GetChannelPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChannelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetChannelPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHarvestJob


        /// <summary>
        /// Retrieves the details of a specific harvest job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHarvestJob service method.</param>
        /// 
        /// <returns>The response from the GetHarvestJob service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetHarvestJob">REST API Reference for GetHarvestJob Operation</seealso>
        public virtual GetHarvestJobResponse GetHarvestJob(GetHarvestJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHarvestJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHarvestJobResponseUnmarshaller.Instance;

            return Invoke<GetHarvestJobResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the details of a specific harvest job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHarvestJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHarvestJob service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetHarvestJob">REST API Reference for GetHarvestJob Operation</seealso>
        public virtual Task<GetHarvestJobResponse> GetHarvestJobAsync(GetHarvestJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetHarvestJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHarvestJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetHarvestJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOriginEndpoint


        /// <summary>
        /// Retrieves the specified origin endpoint that's configured in AWS Elemental MediaPackage
        /// to obtain its playback URL and to view the packaging settings that it's currently
        /// using.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetOriginEndpoint service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetOriginEndpoint">REST API Reference for GetOriginEndpoint Operation</seealso>
        public virtual GetOriginEndpointResponse GetOriginEndpoint(GetOriginEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOriginEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOriginEndpointResponseUnmarshaller.Instance;

            return Invoke<GetOriginEndpointResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the specified origin endpoint that's configured in AWS Elemental MediaPackage
        /// to obtain its playback URL and to view the packaging settings that it's currently
        /// using.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOriginEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOriginEndpoint service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetOriginEndpoint">REST API Reference for GetOriginEndpoint Operation</seealso>
        public virtual Task<GetOriginEndpointResponse> GetOriginEndpointAsync(GetOriginEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOriginEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOriginEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOriginEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOriginEndpointPolicy


        /// <summary>
        /// Retrieves the specified origin endpoint policy that's configured in AWS Elemental
        /// MediaPackage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOriginEndpointPolicy service method.</param>
        /// 
        /// <returns>The response from the GetOriginEndpointPolicy service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetOriginEndpointPolicy">REST API Reference for GetOriginEndpointPolicy Operation</seealso>
        public virtual GetOriginEndpointPolicyResponse GetOriginEndpointPolicy(GetOriginEndpointPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOriginEndpointPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOriginEndpointPolicyResponseUnmarshaller.Instance;

            return Invoke<GetOriginEndpointPolicyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the specified origin endpoint policy that's configured in AWS Elemental
        /// MediaPackage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOriginEndpointPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOriginEndpointPolicy service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/GetOriginEndpointPolicy">REST API Reference for GetOriginEndpointPolicy Operation</seealso>
        public virtual Task<GetOriginEndpointPolicyResponse> GetOriginEndpointPolicyAsync(GetOriginEndpointPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOriginEndpointPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOriginEndpointPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOriginEndpointPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChannelGroups


        /// <summary>
        /// Retrieves all channel groups that are configured in Elemental MediaPackage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelGroups service method.</param>
        /// 
        /// <returns>The response from the ListChannelGroups service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListChannelGroups">REST API Reference for ListChannelGroups Operation</seealso>
        public virtual ListChannelGroupsResponse ListChannelGroups(ListChannelGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelGroupsResponseUnmarshaller.Instance;

            return Invoke<ListChannelGroupsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves all channel groups that are configured in Elemental MediaPackage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannelGroups service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListChannelGroups">REST API Reference for ListChannelGroups Operation</seealso>
        public virtual Task<ListChannelGroupsResponse> ListChannelGroupsAsync(ListChannelGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListChannelGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChannels


        /// <summary>
        /// Retrieves all channels in a specific channel group that are configured in AWS Elemental
        /// MediaPackage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves all channels in a specific channel group that are configured in AWS Elemental
        /// MediaPackage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual Task<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListChannelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHarvestJobs


        /// <summary>
        /// Retrieves a list of harvest jobs that match the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHarvestJobs service method.</param>
        /// 
        /// <returns>The response from the ListHarvestJobs service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListHarvestJobs">REST API Reference for ListHarvestJobs Operation</seealso>
        public virtual ListHarvestJobsResponse ListHarvestJobs(ListHarvestJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListHarvestJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHarvestJobsResponseUnmarshaller.Instance;

            return Invoke<ListHarvestJobsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of harvest jobs that match the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHarvestJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHarvestJobs service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListHarvestJobs">REST API Reference for ListHarvestJobs Operation</seealso>
        public virtual Task<ListHarvestJobsResponse> ListHarvestJobsAsync(ListHarvestJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListHarvestJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHarvestJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListHarvestJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOriginEndpoints


        /// <summary>
        /// Retrieves all origin endpoints in a specific channel that are configured in AWS Elemental
        /// MediaPackage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOriginEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListOriginEndpoints service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListOriginEndpoints">REST API Reference for ListOriginEndpoints Operation</seealso>
        public virtual ListOriginEndpointsResponse ListOriginEndpoints(ListOriginEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOriginEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOriginEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListOriginEndpointsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves all origin endpoints in a specific channel that are configured in AWS Elemental
        /// MediaPackage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOriginEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOriginEndpoints service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListOriginEndpoints">REST API Reference for ListOriginEndpoints Operation</seealso>
        public virtual Task<ListOriginEndpointsResponse> ListOriginEndpointsAsync(ListOriginEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOriginEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOriginEndpointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOriginEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags assigned to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags assigned to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutChannelPolicy


        /// <summary>
        /// Attaches an IAM policy to the specified channel. With policies, you can specify who
        /// has access to AWS resources and what actions they can perform on those resources.
        /// You can attach only one policy with each request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutChannelPolicy service method.</param>
        /// 
        /// <returns>The response from the PutChannelPolicy service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/PutChannelPolicy">REST API Reference for PutChannelPolicy Operation</seealso>
        public virtual PutChannelPolicyResponse PutChannelPolicy(PutChannelPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutChannelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutChannelPolicyResponseUnmarshaller.Instance;

            return Invoke<PutChannelPolicyResponse>(request, options);
        }


        /// <summary>
        /// Attaches an IAM policy to the specified channel. With policies, you can specify who
        /// has access to AWS resources and what actions they can perform on those resources.
        /// You can attach only one policy with each request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutChannelPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutChannelPolicy service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/PutChannelPolicy">REST API Reference for PutChannelPolicy Operation</seealso>
        public virtual Task<PutChannelPolicyResponse> PutChannelPolicyAsync(PutChannelPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutChannelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutChannelPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutChannelPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutOriginEndpointPolicy


        /// <summary>
        /// Attaches an IAM policy to the specified origin endpoint. You can attach only one policy
        /// with each request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOriginEndpointPolicy service method.</param>
        /// 
        /// <returns>The response from the PutOriginEndpointPolicy service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/PutOriginEndpointPolicy">REST API Reference for PutOriginEndpointPolicy Operation</seealso>
        public virtual PutOriginEndpointPolicyResponse PutOriginEndpointPolicy(PutOriginEndpointPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutOriginEndpointPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutOriginEndpointPolicyResponseUnmarshaller.Instance;

            return Invoke<PutOriginEndpointPolicyResponse>(request, options);
        }


        /// <summary>
        /// Attaches an IAM policy to the specified origin endpoint. You can attach only one policy
        /// with each request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOriginEndpointPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutOriginEndpointPolicy service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/PutOriginEndpointPolicy">REST API Reference for PutOriginEndpointPolicy Operation</seealso>
        public virtual Task<PutOriginEndpointPolicyResponse> PutOriginEndpointPolicyAsync(PutOriginEndpointPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutOriginEndpointPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutOriginEndpointPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutOriginEndpointPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetChannelState


        /// <summary>
        /// Resetting the channel can help to clear errors from misconfigurations in the encoder.
        /// A reset refreshes the ingest stream and removes previous content. 
        /// 
        ///  
        /// <para>
        ///  Be sure to stop the encoder before you reset the channel, and wait at least 30 seconds
        /// before you restart the encoder. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetChannelState service method.</param>
        /// 
        /// <returns>The response from the ResetChannelState service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ResetChannelState">REST API Reference for ResetChannelState Operation</seealso>
        public virtual ResetChannelStateResponse ResetChannelState(ResetChannelStateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetChannelStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetChannelStateResponseUnmarshaller.Instance;

            return Invoke<ResetChannelStateResponse>(request, options);
        }


        /// <summary>
        /// Resetting the channel can help to clear errors from misconfigurations in the encoder.
        /// A reset refreshes the ingest stream and removes previous content. 
        /// 
        ///  
        /// <para>
        ///  Be sure to stop the encoder before you reset the channel, and wait at least 30 seconds
        /// before you restart the encoder. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetChannelState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetChannelState service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ResetChannelState">REST API Reference for ResetChannelState Operation</seealso>
        public virtual Task<ResetChannelStateResponse> ResetChannelStateAsync(ResetChannelStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetChannelStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetChannelStateResponseUnmarshaller.Instance;
            
            return InvokeAsync<ResetChannelStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetOriginEndpointState


        /// <summary>
        /// Resetting the origin endpoint can help to resolve unexpected behavior and other content
        /// packaging issues. It also helps to preserve special events when you don't want the
        /// previous content to be available for viewing. A reset clears out all previous content
        /// from the origin endpoint.
        /// 
        ///  
        /// <para>
        /// MediaPackage might return old content from this endpoint in the first 30 seconds after
        /// the endpoint reset. For best results, when possible, wait 30 seconds from endpoint
        /// reset to send playback requests to this endpoint. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetOriginEndpointState service method.</param>
        /// 
        /// <returns>The response from the ResetOriginEndpointState service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ResetOriginEndpointState">REST API Reference for ResetOriginEndpointState Operation</seealso>
        public virtual ResetOriginEndpointStateResponse ResetOriginEndpointState(ResetOriginEndpointStateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetOriginEndpointStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetOriginEndpointStateResponseUnmarshaller.Instance;

            return Invoke<ResetOriginEndpointStateResponse>(request, options);
        }


        /// <summary>
        /// Resetting the origin endpoint can help to resolve unexpected behavior and other content
        /// packaging issues. It also helps to preserve special events when you don't want the
        /// previous content to be available for viewing. A reset clears out all previous content
        /// from the origin endpoint.
        /// 
        ///  
        /// <para>
        /// MediaPackage might return old content from this endpoint in the first 30 seconds after
        /// the endpoint reset. For best results, when possible, wait 30 seconds from endpoint
        /// reset to send playback requests to this endpoint. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetOriginEndpointState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetOriginEndpointState service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/ResetOriginEndpointState">REST API Reference for ResetOriginEndpointState Operation</seealso>
        public virtual Task<ResetOriginEndpointStateResponse> ResetOriginEndpointStateAsync(ResetOriginEndpointStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetOriginEndpointStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetOriginEndpointStateResponseUnmarshaller.Instance;
            
            return InvokeAsync<ResetOriginEndpointStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one of more tags (key-value pairs) to the specified MediaPackage resource.
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions, by granting a user permission to access or change only resources
        /// with certain tag values. You can use the TagResource operation with a resource that
        /// already has tags. If you specify a new tag key for the resource, this tag is appended
        /// to the list of tags associated with the resource. If you specify a tag key that is
        /// already associated with the resource, the new tag value that you specify replaces
        /// the previous value for that tag.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Assigns one of more tags (key-value pairs) to the specified MediaPackage resource.
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions, by granting a user permission to access or change only resources
        /// with certain tag values. You can use the TagResource operation with a resource that
        /// already has tags. If you specify a new tag key for the resource, this tag is appended
        /// to the list of tags associated with the resource. If you specify a tag key that is
        /// already associated with the resource, the new tag value that you specify replaces
        /// the previous value for that tag.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
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
        /// <returns>The response from the UntagResource service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateChannel


        /// <summary>
        /// Update the specified channel. You can edit if MediaPackage sends ingest or egress
        /// access logs to the CloudWatch log group, if content will be encrypted, the description
        /// on a channel, and your channel's policy settings. You can't edit the name of the channel
        /// or CloudFront distribution details.
        /// 
        ///  
        /// <para>
        /// Any edits you make that impact the video output may not be reflected for a few minutes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelResponse>(request, options);
        }


        /// <summary>
        /// Update the specified channel. You can edit if MediaPackage sends ingest or egress
        /// access logs to the CloudWatch log group, if content will be encrypted, the description
        /// on a channel, and your channel's policy settings. You can't edit the name of the channel
        /// or CloudFront distribution details.
        /// 
        ///  
        /// <para>
        /// Any edits you make that impact the video output may not be reflected for a few minutes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual Task<UpdateChannelResponse> UpdateChannelAsync(UpdateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateChannelGroup


        /// <summary>
        /// Update the specified channel group. You can edit the description on a channel group
        /// for easier identification later from the AWS Elemental MediaPackage console. You can't
        /// edit the name of the channel group.
        /// 
        ///  
        /// <para>
        /// Any edits you make that impact the video output may not be reflected for a few minutes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateChannelGroup service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UpdateChannelGroup">REST API Reference for UpdateChannelGroup Operation</seealso>
        public virtual UpdateChannelGroupResponse UpdateChannelGroup(UpdateChannelGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChannelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelGroupResponse>(request, options);
        }


        /// <summary>
        /// Update the specified channel group. You can edit the description on a channel group
        /// for easier identification later from the AWS Elemental MediaPackage console. You can't
        /// edit the name of the channel group.
        /// 
        ///  
        /// <para>
        /// Any edits you make that impact the video output may not be reflected for a few minutes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChannelGroup service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UpdateChannelGroup">REST API Reference for UpdateChannelGroup Operation</seealso>
        public virtual Task<UpdateChannelGroupResponse> UpdateChannelGroupAsync(UpdateChannelGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChannelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateChannelGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateOriginEndpoint


        /// <summary>
        /// Update the specified origin endpoint. Edit the packaging preferences on an endpoint
        /// to optimize the viewing experience. You can't edit the name of the endpoint.
        /// 
        ///  
        /// <para>
        /// Any edits you make that impact the video output may not be reflected for a few minutes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOriginEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateOriginEndpoint service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UpdateOriginEndpoint">REST API Reference for UpdateOriginEndpoint Operation</seealso>
        public virtual UpdateOriginEndpointResponse UpdateOriginEndpoint(UpdateOriginEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOriginEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOriginEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateOriginEndpointResponse>(request, options);
        }


        /// <summary>
        /// Update the specified origin endpoint. Edit the packaging preferences on an endpoint
        /// to optimize the viewing experience. You can't edit the name of the endpoint.
        /// 
        ///  
        /// <para>
        /// Any edits you make that impact the video output may not be reflected for a few minutes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOriginEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOriginEndpoint service method, as returned by MediaPackageV2.</returns>
        /// <exception cref="Amazon.MediaPackageV2.Model.AccessDeniedException">
        /// Access is denied because either you don't have permissions to perform the requested
        /// operation or MediaPackage is getting throttling errors with CDN authorization. The
        /// user or role that is making the request must have at least one IAM permissions policy
        /// attached that grants the required permissions. For more information, see Access Management
        /// in the IAM User Guide. Or, if you're using CDN authorization, you will receive this
        /// exception if MediaPackage receives a throttling error from Secrets Manager.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ConflictException">
        /// Updating or deleting this resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.InternalServerException">
        /// Indicates that an error from the service occurred while trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.MediaPackageV2.Model.ValidationException">
        /// The input failed to meet the constraints specified by the AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediapackagev2-2022-12-25/UpdateOriginEndpoint">REST API Reference for UpdateOriginEndpoint Operation</seealso>
        public virtual Task<UpdateOriginEndpointResponse> UpdateOriginEndpointAsync(UpdateOriginEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOriginEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOriginEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateOriginEndpointResponse>(request, options, cancellationToken);
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